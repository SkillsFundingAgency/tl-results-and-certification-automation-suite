using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Hooks;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using NUnit;
using NUnit.Framework;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class StartPage : Hooks
    {
        public static string StartPageUrl => WebDriverFactory.Config["BaseUrl"];
        public static string HelpUrl => string.Concat(StartPageUrl, "Help");
        public static string CookieUrl => string.Concat(HelpUrl, "/Cookies");
        public static string PrivacyUrl => string.Concat(HelpUrl, "/Privacy");
        public static string Expected404 => string.Concat(WebDriverFactory.Config["BaseUrl"], "page-not-found");
        public static string Error404 => string.Concat(WebDriverFactory.Config["BaseUrl"], "test");
        public static string Error401 => string.Concat(WebDriverFactory.Config["BaseUrl"], "Error/AccessDenied");
        public static string Error500 => string.Concat(WebDriverFactory.Config["BaseUrl"], "Error/500");
        public static string Error403 => string.Concat(WebDriverFactory.Config["BaseUrl"], "no-service-permission");
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
        protected readonly By PageHeader = By.TagName("h1");
        
        public void CheckCookies()
        {
            PageHelper.VerifyPageUrl(WebDriver.Url, CookieUrl);
            Assert.AreEqual(Constants.CookieHeader, CheckPageTitle.Text);
        }
    }
}
