using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Hooks;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using NUnit.Framework;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class StartPage : Hooks
    {
        public static string StartPageUrl => WebDriverFactory.Config["BaseUrl"];
        public static string HelpUrl => string.Concat(StartPageUrl, "Help");
        public static string CookieUrl => string.Concat(StartPageUrl, "cookies");
        public static string CookieDetailsUrl => string.Concat(StartPageUrl, "cookie-details");
        public static string PrivacyUrl => string.Concat(HelpUrl, "/Privacy");
        public static string Expected404 => string.Concat(WebDriverFactory.Config["BaseUrl"], "page-not-found");
        public static string Error404 => string.Concat(StartPageUrl, "test");
        public static string Error401 => string.Concat(StartPageUrl, "access-denied-wrong-role");
        public static string Error500 => string.Concat(StartPageUrl, "Error/500");
        public static string ExpectedError500 => string.Concat(StartPageUrl, "problem-with-service");
        public static string Error403 => string.Concat(StartPageUrl, "service-access-denied");
        public static string TermsUrl => string.Concat(StartPageUrl, "terms-and-conditions");
        public static string TechSpecPageUrl => string.Concat(StartPageUrl, "download-registration-data-format-and-rules-guide");
        public static string PageTitle = "Sign in to submit T Levels registration and results details";
        public IWebElement CheckPageTitle => WebDriver.FindElement(By.TagName("h1"));
        public static By CookieTitle { get; } = By.XPath("//*[@id='main-content']//h1");
        public static By TlevelCookies { get; } = By.XPath("//*[@id='main-content']/div/div/h1");
        public By StartNowButton = By.XPath("//a[@role='button' and contains(text(),'Start now')]");
        public IWebElement CookiesLink => WebDriver.FindElement(By.LinkText("Cookies"));
        public By CookieLink = By.XPath("//a[contains(text(),'Cookies')]");
        public By PrivacyLink = By.XPath("//a[contains(text(),'Privacy')]");
        public By PrivacyTitle = By.TagName("h1");
        public By TCLink = By.XPath("//a[contains(text(),'Terms and conditions')]");
        public By TCTitle = By.TagName("h1");
        protected readonly By PageHeader = By.XPath("//*[@id='main-content']//h1");
        private const string TechSpecPageTitle = "Download registration data: format and rules guide page – Manage T Level results – GOV.UK";
        private const string TechSpecPageHeader = "T Levels registration data: format and rules guide";


        public void CheckCookies()
        {
            PageHelper.VerifyPageUrl(WebDriver.Url, CookieUrl);
            Assert.AreEqual(Constants.CookieHeader, CheckPageTitle.Text);
        }
        public static void VerifyTechSpecPage()
        {
            Assert.AreEqual(TechSpecPageTitle, WebDriver.Title);
            Assert.AreEqual(TechSpecPageHeader, WebDriver.FindElement(CookieTitle).Text);
        }
    }
}
