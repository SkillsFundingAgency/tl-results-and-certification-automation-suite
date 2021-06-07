using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement
{
    public class SOACheckAndSubmitPage : ElementHelper
    {

        private static string SOACheckAndSubmitPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "request-statement-of-achievement-check-and-submit");
        private static string SOACheckAndSubmitPageHeader { get; } = "Check the learner's details before sending your request";
        private static string SOACheckAndSubmitPageTitle { get; } = "Request statement of achievement – Check the learner’s details page – Manage T Level results – GOV.UK";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");

        private static By AcceptAndRequestBtn { get; } = By.ClassName("govuk-button");
        private static By CheckAndSubmitTextArea = By.ClassName("govuk-grid-column-two-thirds-from-desktop");
        private static By LearnerTLevelComponentChangeLink = By.XPath("//*[@href ='/request-statement-of-achievement-change-learner-components");
        private static By PostalAddressChangeLink = By.XPath("//*[@href ='//*[@href ='request-statement-of-achievement-change-postal-address']");
        private static By HomeBreadcrumb = By.Id("breadcrumb0");
        private static By RequestSOABreadcrumb = By.Id("breadcrumb1");
        private static By SearchForLearnerBreadcrumb = By.Id("breadcrumb2");
        private static By TLevelComponentAchievementChangeLink { get; } = By.XPath("//a[contains(@href,'change-learner-component')]");

        public static void VerifySOACheckAndSubmitPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(SOACheckAndSubmitPageUrl));
            Assert.AreEqual(SOACheckAndSubmitPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(SOACheckAndSubmitPageTitle, WebDriver.Title);
        }

        public static void ClickAcceptAndRequestBtn()
        {
            ClickElement(AcceptAndRequestBtn);
        }

        public static void ClickPostalAddressChangeLink()
        {
            ClickElement(PostalAddressChangeLink);
        }

        public static void ClickTLevelComponentChangeLink()
        {
            ClickElement(LearnerTLevelComponentChangeLink);
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

        public static void ClickTLevelComponentAchievement_ChangeLink()
        {
            ClickElement(TLevelComponentAchievementChangeLink);
        }
    }
}
