using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Hooks;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Xunit;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class StartPage : Hooks
    {
        public static string StartPageUrl => Constants.BaseUrl;
        public static string HelpUrl => string.Concat(StartPageUrl, "Help");
        public static string CookieUrl => string.Concat(HelpUrl, "/Cookies");
        public static string PrivacyUrl => string.Concat(HelpUrl, "/Privacy");
        public static string TermsUrl => string.Concat(HelpUrl, "/TermsAndConditions");
        public static string PageTitle = "Sign in to submit T Levels registration and results details";
        public IWebElement CheckPageTitle => WebDriver.FindElement(By.TagName("h1"));
        public By CookieTitle = By.TagName("h1");
        public By StartNowButton = By.XPath("//a[@role='button' and contains(text(),'Start now')]");
        public IWebElement CookiesLink => WebDriver.FindElement(By.LinkText("Cookies"));
        public By CookieLink = By.LinkText("Cookies");
        public By PrivacyLink = By.LinkText("Privacy");
        public By PrivacyTitle = By.TagName("h1");
        public By TCLink = By.LinkText("Terms and conditions");
        public By TCTitle = By.TagName("h1");
        
        public void CheckCookies()
        {
            PageHelper.VerifyPageURL(WebDriver.Url, CookieUrl);
            Assert.Equal(Constants.CookieHeader, CheckPageTitle.Text);
        }
    }
}
