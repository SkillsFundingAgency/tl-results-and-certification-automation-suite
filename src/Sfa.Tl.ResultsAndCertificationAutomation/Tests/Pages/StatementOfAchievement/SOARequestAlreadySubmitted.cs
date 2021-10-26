using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using System;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement
{
    public class SOARequestAlreadySubmitted : ElementHelper
    {

        private static string SOARequestAlreadySubmittedPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "request-statement-of-achievement-already-requested");
        private static string SOARequestAlreadySubmittedPageHeader { get; } = "Statement of achievement has already been requested";
        private static string SOARequestAlreadySubmittedPageTitle { get; } = "Request statement of achievement – Statement of achievement already requested page – Manage T Level results – GOV.UK";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");

        private static By AcceptAndRequestBtn { get; } = By.Id("acceptAndSendButton");
        private static By CheckAndSubmitTextArea = By.ClassName("govuk-grid-column-three-quarters");
        private static By HomeBreadcrumb = By.Id("breadcrumb0");
        private static By RequestSOABreadcrumb = By.Id("breadcrumb1");
        private static By SearchForLearnerBreadcrumb = By.Id("breadcrumb2");
        private static By BackToHomeBtn = By.Id("backToHomeButton");

        public static void VerifySOARequestAlreadySubmittedtPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(SOARequestAlreadySubmittedPageUrl));
            Assert.AreEqual(SOARequestAlreadySubmittedPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(SOARequestAlreadySubmittedPageTitle, WebDriver.Title);
        }

        public static void ClickBackToHomeBtn()
        {
            ClickElement(BackToHomeBtn);
        }

        public static void VerifyRequestedByDetails()
        {
            string ExpectedDate = DateTime.Now.ToString("dd MMMM yyyy");
            Assert.IsTrue(WebDriver.FindElement(CheckAndSubmitTextArea).Text.Contains(ExpectedDate));
            Assert.IsTrue(WebDriver.FindElement(CheckAndSubmitTextArea).Text.Contains("Barnsley Provider administrator"));
        }

        public static void VerifyLearnersTLevelComponentAchievements(string EngAndMathAchievementStatus, string IndustryPlacementStatus)
        {
            Assert.IsTrue(WebDriver.FindElement(CheckAndSubmitTextArea).Text.Contains(EngAndMathAchievementStatus));
            Assert.IsTrue(WebDriver.FindElement(CheckAndSubmitTextArea).Text.Contains(IndustryPlacementStatus));
        }

        public static void VerifyLearnerDetails(string ULN)
        {
            Assert.IsTrue(WebDriver.FindElement(CheckAndSubmitTextArea).Text.Contains(ULN));
            Assert.IsTrue(WebDriver.FindElement(CheckAndSubmitTextArea).Text.Contains("Db FirstName Db LastName"));
            Assert.IsTrue(WebDriver.FindElement(CheckAndSubmitTextArea).Text.Contains("01 January 2001"));
            Assert.IsTrue(WebDriver.FindElement(CheckAndSubmitTextArea).Text.Contains("Barnsley College (10000536)"));
        }

        public static void VerifyQualificationDetails()
        {
            Assert.IsTrue(WebDriver.FindElement(CheckAndSubmitTextArea).Text.Contains("T Level in Agriculture, Environmental and Animal Care"));
            Assert.IsTrue(WebDriver.FindElement(CheckAndSubmitTextArea).Text.Contains("Agriculture, Environmental and Animal Care (77777777)"));
            Assert.IsTrue(WebDriver.FindElement(CheckAndSubmitTextArea).Text.Contains("Grade: A"));
            Assert.IsTrue(WebDriver.FindElement(CheckAndSubmitTextArea).Text.Contains("Agriculture, Land Management and Production (70000002)"));
            Assert.IsTrue(WebDriver.FindElement(CheckAndSubmitTextArea).Text.Contains("Grade: None"));
        }

        public static void VerifyPostalAddress()
        {
            Assert.IsTrue(WebDriver.FindElement(CheckAndSubmitTextArea).Text.Contains("Department"));
            Assert.IsTrue(WebDriver.FindElement(CheckAndSubmitTextArea).Text.Contains("BARNSLEY COLLEGE"));
            Assert.IsTrue(WebDriver.FindElement(CheckAndSubmitTextArea).Text.Contains("CHURCH STREET"));
            Assert.IsTrue(WebDriver.FindElement(CheckAndSubmitTextArea).Text.Contains("BARNSLEY"));
            Assert.IsTrue(WebDriver.FindElement(CheckAndSubmitTextArea).Text.Contains("S70 2AX"));
        }

        public static void ClickBreadCrumb(string name)
        {
            switch (name)
            {
                case "Search for a learner":
                    ClickElement(SearchForLearnerBreadcrumb);
                    break;
                case "Request statement of achievement":
                    ClickElement(RequestSOABreadcrumb);
                    break;
                case "Home":
                    ClickElement(HomeBreadcrumb);
                    break;
            }
        }        
    }
}
