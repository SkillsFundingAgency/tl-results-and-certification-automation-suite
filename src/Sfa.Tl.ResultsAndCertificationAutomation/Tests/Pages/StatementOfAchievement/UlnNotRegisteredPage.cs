using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement
{
    public class UlnNotRegisteredPage : ElementHelper
    {
        private static string UlnNotRegisteredPageUrl { get; } = "request-statement-of-achievement-ULN-not-registered";
        private static string UlnNotRegisteredPageTitle { get; } = "Request statement of achievement – ULN not registered page – Manage T Level results – GOV.UK";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By BackLink { get; } = By.Id("backLink");
        private static By BackToHomeBtn { get; } = By.Id("buttonHome");
        private static By RequestSoaLink { get; } = By.LinkText("Request statement of achievement");
        private static By ContinueBtn { get; } = By.Id("continueButton");
        // Uln not withdrawn pge
        private static string UlnNotWithdrawnPageUrl { get; } = "request-statement-of-achievement-ULN-not-withdrawn";
        private static string UlnNotWithdrawnPageTitle { get; } = "Request statement of achievement - ULN not withdrawn page – Manage T Level results – GOV.UK";
        private static string UlnNotWithdrawnPageHeader { get; } = "Learner has not been withdrawn by the exam board";
        private static By MainContent { get; } = By.Id("main-content");
        private static By BackToHome { get; } = By.Id("backButton");

        public static void VerifyUlnNotRegisteredPage(string uln)
        {
            string ExpectedPageHeader = "ULN (" + uln + ") has not been registered in this service by an exam board";
            Assert.IsTrue( WebDriver.Url.Contains(UlnNotRegisteredPageUrl));
            Assert.AreEqual(ExpectedPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(UlnNotRegisteredPageTitle, WebDriver.Title);
        }
        public static void VerifyBackLink(string uln)
        {
            ClickElement(BackLink);
            RequestSOA_SearchForALearnerPage.VerifySearchLearnerPage();
            RequestSOA_SearchForALearnerPage.VerifySeachUlnField(uln);
        }
        public static void VerifyBackToHome()
        {
            ClickButton(BackToHomeBtn);
            Assert.IsTrue(WebDriver.Url.Contains("home"));
        }
        public static void VerifyBackToHomeNavigation()
        {
            ClickButton(BackToHome);
            Assert.IsTrue(WebDriver.Url.Contains("home"));
        }
        public static void NavigateSearchForLearnerPage()
        {
            ClickElement(RequestSoaLink);
            ClickButton(ContinueBtn);
        }
        public static void VerifyUlnNotWithdrawnPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(UlnNotWithdrawnPageUrl));
            Assert.AreEqual(UlnNotWithdrawnPageTitle, WebDriver.Title);
            Assert.AreEqual(UlnNotWithdrawnPageHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyUlnNotWithdrawnContent(string uln)
        {
            Assert.IsTrue(WebDriver.FindElement(MainContent).Text.Contains(uln));
            Assert.IsTrue(WebDriver.FindElement(MainContent).Text.Contains("Db FirstName Db LastName"));
            Assert.IsTrue(WebDriver.FindElement(MainContent).Text.Contains("01 January 2001"));
            Assert.IsTrue(WebDriver.FindElement(MainContent).Text.Contains("Barnsley College (10000536)"));
            Assert.IsTrue(WebDriver.FindElement(MainContent).Text.Contains("T Level in Agriculture, Environmental and Animal Care"));
        }

    }
}
