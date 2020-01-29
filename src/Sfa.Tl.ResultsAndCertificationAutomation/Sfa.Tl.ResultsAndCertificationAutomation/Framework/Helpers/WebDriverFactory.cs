﻿using System;
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
        private static IConfigurationRoot _config;

        public static IConfigurationRoot Config
        {
            get
            {
                if (_config == null)
                {
                    var builder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                    _config = builder.Build();
                    return _config;
                }
                else
                {
                    return _config;
                }
            }
        }

        public IWebDriver GetWebDriver(string browser)
        {
            var webDriver = browser switch
            {
                "FireFox" => (IWebDriver) new FirefoxDriver(),
                "Edge" => new EdgeDriver(),
                "IE" => new InternetExplorerDriver(),
                "Chrome" => new ChromeDriver(),
                _ => throw new Exception("Driver name - " + browser +
                                         "does not match OR this framework does not support the webDriver specified")
            };

            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(10);
            return webDriver;
        }

        public static string GetSetting(string name)
        {
            return ConfigurationManager.AppSettings[name];
        }
    }
}