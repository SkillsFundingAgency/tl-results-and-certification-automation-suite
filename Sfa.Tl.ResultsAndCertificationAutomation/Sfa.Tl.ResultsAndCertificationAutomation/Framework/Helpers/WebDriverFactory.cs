using System;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers
{
    public class WebDriverFactory
    {
        public IWebDriver GetWebDriver(string browser)
        {
            IWebDriver driver;
            switch (browser)
            {
                case "FireFox":
                    driver = new FirefoxDriver();
                    break;
                case "Edge":
                    driver = new EdgeDriver();
                    break;
                case "IE":
                    driver = new InternetExplorerDriver();
                    break;
                case "Chrome":
                    driver = new ChromeDriver();
                    break;
                default:
                    throw new Exception("Driver name - " + browser + "does not match OR this framework does not support the webDriver specified");
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(30);
            return driver;
        }

        public string GetSetting(string name)
        {
            return ConfigurationManager.AppSettings[name];
        }
    }
}
