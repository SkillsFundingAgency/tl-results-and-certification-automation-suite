using System;
using System.IO;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Framework.Hooks
{
    [Binding]
    public class Hooks
    {
        public static IWebDriver WebDriver { get; set;}
                
        [Before]
        public static void SetUp()
        {
            var webDriverFactory = new WebDriverFactory();
            var browser = WebDriverFactory.Config["Browser"];
            WebDriver = webDriverFactory.GetWebDriver(browser);
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(10);
            WebDriver.Manage().Window.Maximize();
        }

        [After]
        public static void CleanUp()
        {
                WebDriver.Dispose();
        }

        [Obsolete]
        public static void TakeScreenshotOnFailure()
        {
            DateTime dateTime = DateTime.Now;
            string featureTitle = FeatureContext.Current.FeatureInfo.Title;
            string scenarioTitle = ScenarioContext.Current.ScenarioInfo.Title;
            string failureImageName = dateTime.ToString("HH-mm-ss")
                                      + "_"
                                      + featureTitle
                                      + scenarioTitle
                                      + ".png";
            string screenshotsDirectory = AppDomain.CurrentDomain.BaseDirectory
                                          // + "../../"
                                          + "\\Project\\Screenshots\\"
                                          + dateTime.ToString("dd-MM-yyyy")
                                          + "\\";
            if (!Directory.Exists(screenshotsDirectory))
            {
                   Directory.CreateDirectory(screenshotsDirectory);
            }

            _ = WebDriver as ITakesScreenshot;
            Screenshot screenshot = ((ITakesScreenshot)WebDriver).GetScreenshot();
            string screenshotPath = Path.Combine(screenshotsDirectory, failureImageName);
            screenshot.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);
            Console.WriteLine(scenarioTitle
                              + " -- Sceario failed and the screenshot is available at -- "
                              + screenshotPath);
        }
    }
}
