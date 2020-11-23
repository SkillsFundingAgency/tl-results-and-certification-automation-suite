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
            var browser = ConfigHelper.GetBrowser();
            WebDriver = webDriverFactory.GetWebDriver(browser);
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(400);
        }

        [After]
        public static void CleanUp()
        {
            WebDriver.Dispose();
        }
    }
}
