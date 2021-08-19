using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.TLevelReview
{
    public class SelectTLevelPage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "select-tlevel");
        private static string pageTitle { get; } = "Select T Level – Manage T Level results – GOV.UK";
        private static string pageHeader { get; } = "Which T Level do you want to review?";
        private static readonly By pageHeaderElement = By.XPath("//*[@id='main-content']//h1");

        private static By homeBreadcrumb { get; } = By.Id("breadcrumb0");
        private static By tLevelsBreadcrumb { get; } = By.Id("breadcrumb1");
        private static By continueButton { get; } = By.Id("continueButton");
        private static By mainErrorMesg = By.ClassName("govuk-error-summary__body");
        private static By subErrorMesg = By.ClassName("govuk-error-message");
        private static By contactUsLink = By.XPath("//*[contains(text(),'contact us')]");
        private static By iCannotFindATLevelLink = By.XPath("//*[contains(text(),'I cannot find a T Level')]");

        public static void VerifySelectTLevelPage()
        {          
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(WebDriver.Title, pageTitle);
            Assert.AreEqual(WebDriver.FindElement(pageHeaderElement).Text, pageHeader);
        }

        public static void ClickHomeBreadcrumb()
        {
            ClickElement(homeBreadcrumb);
        }

        public static void ClickTLevelsBreadcrumb()
        {
            ClickElement(tLevelsBreadcrumb);
        }
        public static void ClickContinueBtn()
        {
            ClickElement(continueButton);
        }

        public static void ClickContactUsLink()
        {
            ClickElement(contactUsLink);
        }
        public static void ClickICannotFinaATLevelLink()
        {
            ClickElement(iCannotFindATLevelLink);
        }

        public static void VerifyErrorMessage(string ErrorMsg)
        {
            Assert.IsTrue(WebDriver.FindElement(mainErrorMesg).Text.Contains(ErrorMsg));
            Assert.IsTrue(WebDriver.FindElement(subErrorMesg).Text.Contains(ErrorMsg));
        }
    }
}
