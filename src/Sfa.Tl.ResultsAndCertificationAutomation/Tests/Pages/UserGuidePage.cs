using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class UserGuidePage : ElementHelper
    {
        private static string PageURL => string.Concat(StartPage.StartPageUrl, "user-guide");

        private static string PageTitle = "User guide page – Manage T Level results – GOV.UK";
        private static string PageHeaderText = "Manage T Level results user guide";
        public static By PageHeader = By.XPath("//*[@id='content']//h1");
        public static By LastUpdated = By.XPath("//*[@id='history']/p");
        private static string LastUpdatedText = "Published 5 January 2021";


        public static void CheckUserGuidePage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(PageURL));
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.FindElement(PageHeader).Text.Contains(PageHeaderText));
            Assert.IsTrue(WebDriver.FindElement(LastUpdated).Text.Contains(LastUpdatedText));
        }

    }
}
