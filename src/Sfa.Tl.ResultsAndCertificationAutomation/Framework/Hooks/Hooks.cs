using System;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Framework.Hooks
{
    [Binding]
    public class Hooks
    {
        public static IWebDriver WebDriver { get; set; }

        [Before]
        public static void SetUp()
        {
            var webDriverFactory = new WebDriverFactory();
            var browser = WebDriverFactory.Config["Browser"];
            WebDriver = webDriverFactory.GetWebDriver(browser);
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(10);
        }

        [After]
        public static void CleanUp()
        {
            //SqlQueries.DeleteFromRegistrationTables();
            WebDriver.Dispose();
        }
    }
}
