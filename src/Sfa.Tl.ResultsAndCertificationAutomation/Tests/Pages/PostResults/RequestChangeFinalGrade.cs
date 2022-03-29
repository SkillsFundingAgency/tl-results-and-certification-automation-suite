using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults
{
    public class RequestChangeFinalGrade : ElementHelper
    {
        private static string PageUrl { get; } = "post-results-final-grade-change-request";
        private static string PageTitle { get; } = "Change a ‘final’ grade - Post-results – Manage T Level results – GOV.UK";
        private static string PageErrorTitle { get; } = "Error: Change a ‘final’ grade - Post-results – Manage T Level results – GOV.UK";
        private static string PageHeader { get; } = "Request to change a 'FINAL' grade";
        private static readonly By PageHeaderElement = By.XPath("//*[@id='main-content']//h1");
        private static readonly By SendBtn = By.Id("sendButton");
        private static readonly By CancelLink = By.Id("cancelLink");

        public static void VerifyChangeRequestFinalGradePage()
        {
            Assert.AreEqual(PageTitle,WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(PageHeader,WebDriver.FindElement(PageHeaderElement).Text);
        }
        public static void VerifyChangeRequestFinalGradeErrorPage()
        {
            Assert.AreEqual(PageErrorTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        }

        protected static void ClickSendBtn() => ClickButton(SendBtn);
    }
}
