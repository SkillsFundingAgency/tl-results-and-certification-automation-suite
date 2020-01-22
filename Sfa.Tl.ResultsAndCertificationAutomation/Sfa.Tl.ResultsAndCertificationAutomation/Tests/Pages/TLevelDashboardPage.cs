using System.Configuration;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Hooks;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class TlevelDashboardPage : Hooks
    {
        public static string StartPageUrl => ConfigurationManager.AppSettings["BaseUrl"];
        public static string DashBoadrdUrl => string.Concat(StartPageUrl, "/Help/Dashboard");
        public static string DashboardUrl => string.Concat(StartPageUrl, "/Dashboard");
        public IWebElement StartNowButton => WebDriver.FindElement(By.XPath("//a[@role='button' and contains(text(),'Start now')]"));
        public IWebElement CookiesLink => WebDriver.FindElement(By.LinkText("Cookies"));
        public static string HelpUrl => string.Concat(StartPageUrl, "/Help");
        public static string CookieUrl => string.Concat(HelpUrl, "/Cookies");
        public static By BannerInfo = By.XPath("//span[@class='govuk-phase-banner__text']");
        public static string BannerText = "This is a new service – your feedback will help us to improve it.";
        public static By SignOutLink = By.LinkText("Sign out");
    }
}
