using System;
using System.Configuration;
using System.IO;
using Microsoft.Extensions.Configuration;
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
            IWebDriver webDriver;
            switch (browser)
            {
                case "FireFox":
                    webDriver = new FirefoxDriver();
                    break;
                case "Edge":
                    webDriver = new EdgeDriver();
                    break;
                case "IE":
                    webDriver = new InternetExplorerDriver();
                    break;
                case "Chrome":
                    webDriver = new ChromeDriver();
                    break;
                default:
                    throw new Exception("Driver name - " + browser + "does not match OR this framework does not support the webDriver specified");
            }

            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(30);
            return webDriver;
        }

        public static string GetSetting(string name)
        {
            return ConfigurationManager.AppSettings[name];
        }

        public static void Main1(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            Console.WriteLine(configuration.GetConnectionString("Storage"));
        }
    }
}
