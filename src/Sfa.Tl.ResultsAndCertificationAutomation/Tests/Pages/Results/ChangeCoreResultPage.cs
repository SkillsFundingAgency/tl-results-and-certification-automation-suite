using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Results
{
    public class ChangeCoreResultPage : ElementHelper
    {
        private static string PageUrl { get; } = "change-core-result";
        private static string PageTitle { get; } = "Change core result – Manage T Level results – GOV.UK";
        private static string ErrorPageTitle { get; } = "Error: Change core result – Manage T Level results – GOV.UK";
        private  static  By ChangeBtn { get; } = By.Id("changeButton");

        protected static void VerifyChangeCoreResultsPage()
        {
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        }

        protected static void VerifyChangeCoreResultsErrorPage()
        {
            Assert.AreEqual(ErrorPageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        }

        protected static void ClickChangeBtn()
        {
            ClickButton(ChangeBtn);
        }
    }
}
