using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults
{
    public class CancelRequestChangePage : ElementHelper
    {
        private static string PageUrl { get; } = "post-results-cancel-final-grade-change-request";
        private static string PageTitle { get; } = "Cancel request to change a ‘final’ grade - Post-results – Manage T Level results – GOV.UK";
        private static string PageErrorTitle { get; } = "Error: Cancel request to change a ‘final’ grade - Post-results – Manage T Level results – GOV.UK";
        private static string PageHeader { get; } = "Are you sure you want to cancel the request to change the grade?";
        private static readonly By PageHeaderElement = By.XPath("//*[@id='main-content']//h1");
        private static readonly By NoCancelRadio = By.Id("areyousuretocancel-no");
        private static readonly By ContinueBtn = By.Id("continueButton");

        protected static void VerifyCancelChangeRequestPage()
        {
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(PageHeader, WebDriver.FindElement(PageHeaderElement).Text);
        }

        protected static void VerifyCancelChangeRequestErrorPage()
        {
            Assert.AreEqual(PageErrorTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        }

        protected static void CheckNoCancelRadio()
        {
            ClickElement(NoCancelRadio);
            ClickButton(ContinueBtn);
        }

        protected static void ClickContinueBtn()
        {
            ClickButton(ContinueBtn);
        }
    }
}
