using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class UserGuidePage : ElementHelper
    {
        private static string PageUrl => string.Concat(StartPage.StartPageUrl, "user-guide");

        private const string PageTitle = "User guide page – Manage T Level results – GOV.UK";
        private const string PageHeaderText = "Manage T Level results user guide";
        private static readonly By PageHeader = By.XPath("//*[@id='content']//h1");

        public static void CheckUserGuidePage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.FindElement(PageHeader).Text.Contains(PageHeaderText));
        }

    }
}
