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
        public static void NavigateSearchForLearnerPage()
        {
            ClickElement(RequestSoaLink);
            ClickButton(ContinueBtn);
        }

    }
}
