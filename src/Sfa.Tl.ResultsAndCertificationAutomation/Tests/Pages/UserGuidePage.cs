using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class UserGuidePage : ElementHelper
    {
        private static string PageURL => string.Concat(StartPage.StartPageUrl, "user-guide");

        private static readonly string PageTitle = "User guide page – Manage T Level results – GOV.UK";
        private static readonly string PageHeaderText = "Manage T Level results user guide";
        public static By PageHeader = By.XPath("//*[@id='content']//h1");
        public static By LastUpdated = By.XPath("//*[@id='history']/p");

        public static void CheckUserGuidePage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(PageURL));
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.FindElement(PageHeader).Text.Contains(PageHeaderText));
        }

    }
}
