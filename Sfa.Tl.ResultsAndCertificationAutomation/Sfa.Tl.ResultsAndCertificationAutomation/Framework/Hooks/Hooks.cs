using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Framework.Hooks
{
    [Binding]
    public class Hooks
    {
        public static IWebDriver Driver { get; set; }

        [BeforeScenario]
        public static void SetUp()
        {
            var webDriverFactory = new WebDriverFactory();
            var browser = webDriverFactory.GetSetting("Browser");
            var driver = webDriverFactory.GetWebDriver(browser);
            Driver = driver;

            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public static void TearDown()
        {
            Driver.Quit();
        }

        [AfterTestRun]
        public static void CleanUp()
        {
            Driver.Dispose();
        }
    }
}
