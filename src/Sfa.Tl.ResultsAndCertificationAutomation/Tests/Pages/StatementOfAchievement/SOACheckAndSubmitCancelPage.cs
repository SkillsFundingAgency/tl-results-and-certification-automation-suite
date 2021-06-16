using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement
{
    public class SOACheckAndSubmitCancelPage : ElementHelper
    {
        private static string PageUrl { get; } = "request-statement-of-achievement-cancel";
        private static string PageTitle { get; } = "Cancel statement of achievement request page – Manage T Level results – GOV.UK";
        private static string ErrorPageTitle { get; } = "Error: Cancel statement of achievement request page – Manage T Level results – GOV.UK";
        private static string PageHeader { get; } = "Are you sure you want to cancel this request?";
        private static By PageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        public static By CancelYes { get; } = By.Id("cancelrequest");
        public static By CancelNo { get; } = By.Id("cancelrequest-no");
        private static By ContinueBtn { get; } = By.XPath("//button[contains(text(),'Continue')]");
        private static By BackLink { get; } = By.Id("backLink");
        public static void VerifySoaCancelPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(PageHeader, WebDriver.FindElement(PageHeaderElement).Text);
        }
        public static void VerifySoaCancelErrorPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(ErrorPageTitle, WebDriver.Title);
            Assert.AreEqual(PageHeader, WebDriver.FindElement(PageHeaderElement).Text);
        }
        public static void VerifyRadioOptions()
        {
            Assert.AreEqual(false, WebDriver.FindElement(CancelYes).Selected);
            Assert.AreEqual(false, WebDriver.FindElement(CancelNo).Selected);
        }
        public static void ClickContinueBtn()
        {
            ClickElement(ContinueBtn);
        }
        public static void ClickBackLink()
        {
            ClickElement(BackLink);
        }
    }
}
