using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using OpenQA.Selenium;

namespace Sfa.Tl.ResultsAndCertificationAutomation.ObjectRepository
{
    public class StartPageElements
    {
        private readonly IWebDriver _webDriver;

        public StartPageElements(IWebDriver webDriver)
        {
            this._webDriver = webDriver;
        }

        public static string StartPageUrl => ConfigurationManager.AppSettings["BaseUrl"];
        public static string HelpUrl => string.Concat(StartPageUrl, "/Help");
        public static string CookieUrl => string.Concat(HelpUrl, "/Cookies");
        public static string PrivacyUrl => string.Concat(HelpUrl, "/Privacy");
        public static string TermsUrl => string.Concat(HelpUrl, "/TermsAndConditions");
        public static string DashboardUrl => string.Concat(StartPageUrl, "/Dashboard");
        public static string PageTitle = "Sign in to submit T Levels registration and results details";
        public By CheckPageTitle = By.TagName("h1");
        public By StartNowButton =By.XPath("//a[@role='button' and contains(text(),'Start now')]");
    }
}
