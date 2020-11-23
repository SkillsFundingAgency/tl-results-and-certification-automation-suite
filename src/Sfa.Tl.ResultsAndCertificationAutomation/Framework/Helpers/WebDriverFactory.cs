using System;
using System.Collections.Generic;
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
            switch (browser)
            {
                case var _ when browser == "FireFox":
                    return new FirefoxDriver();
                case var _ when browser == "Edge":
                    return new EdgeDriver();
                case var _ when browser == "IE":
                    return new InternetExplorerDriver();
                case var _ when browser == "Chrome":
                    var chromeOptions = new ChromeOptions();
                    if (ConfigHelper.GetHeadless())
                    {
                        chromeOptions.AddArguments(new List<string> {"--incognito", "headless"});
                    }
                    chromeOptions.AddUserProfilePreference("download.default_directory", FileHelper.GetDownloadFolder());
                    return new ChromeDriver(chromeOptions);

                default:
                    throw new Exception($"Driver name - {browser} does not match OR this framework does not support the webDriver specified");
            }
        }
    }
}
