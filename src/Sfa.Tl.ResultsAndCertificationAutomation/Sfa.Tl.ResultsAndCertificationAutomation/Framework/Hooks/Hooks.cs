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
            var driver = webDriverFactory.GetWebDriver(browser);
            WebDriver = driver;

            WebDriver.Manage().Window.Maximize();
        }

        [After]
        public static void CleanUp()
        {
            WebDriver.Dispose();
        }

        public static void TakeScreenshotOnFailure()
        {
            if (ScenarioContext.Current.TestError != null)
            {
                try
                {
                    DateTime dateTime = DateTime.Now;
                    String featureTitle = FeatureContext.Current.FeatureInfo.Title;
                    String scenarioTitle = ScenarioContext.Current.ScenarioInfo.Title;
                    String failureImageName = dateTime.ToString("HH-mm-ss")
                                              + "_"
                                              + scenarioTitle
                                              + ".png";
                    String screenshotsDirectory = AppDomain.CurrentDomain.BaseDirectory
                                                  + "../../"
                                                  + "\\Project\\Screenshots\\"
                                                  + dateTime.ToString("dd-MM-yyyy")
                                                  + "\\";
                    if (!Directory.Exists(screenshotsDirectory))
                    {
                        Directory.CreateDirectory(screenshotsDirectory);
                    }

                    ITakesScreenshot screenshotHandler = WebDriver as ITakesScreenshot;
                    Screenshot screenshot = screenshotHandler.GetScreenshot();
                    String screenshotPath = Path.Combine(screenshotsDirectory, failureImageName);
                    screenshot.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);
                    Console.WriteLine(scenarioTitle
                                      + " -- Sceario failed and the screenshot is available at -- "
                                      + screenshotPath);
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Exception occurred while taking screenshot - " + exception);
                }
            }
        }
    }
}
