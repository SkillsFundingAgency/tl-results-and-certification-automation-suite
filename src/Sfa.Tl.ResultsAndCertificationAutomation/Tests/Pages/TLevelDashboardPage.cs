using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class TlevelDashboardPage : ElementHelper
    {
        public static string StartPageUrl => WebDriverFactory.Config["BaseUrl"];
        public static string DashboardUrl => string.Concat(StartPageUrl, "home");
        public IWebElement StartNowButton => WebDriver.FindElement(By.XPath("//a[@role='button' and contains(text(),'Start now')]"));
        public IWebElement CookiesLink => WebDriver.FindElement(By.LinkText("Cookies"));
        public static string CookieUrl => string.Concat(StartPageUrl, "cookie-policy");
        public static string TlevelPageUrl => string.Concat(StartPageUrl, "Tlevel/Index");
        public static By BannerInfo = By.XPath("//span[@class='govuk-phase-banner__text']");
        public static string BannerText = "This is a new service – your feedback will help us to improve it.";
        public static By SignOutLink = By.LinkText("Sign out");
        protected readonly By PageHeader = By.TagName("h1");
        public static By SelectOrgNcfe = By.Id("848D7FB9-ADBD-47EC-A975-3FF9314323EA");
        public static By SelectOrgPearson = By.Id("13BE668D-833B-410F-A9E4-D7AB3CF14DCD");
        public static By OrgContinueBtn = By.XPath("//input[@value='Continue']");
        public static By DashboardHeadLink = By.XPath("//a[@href='/home']");
        public static By UserAccountLink = By.XPath("//a[contains(text(), 'Account')]");
        public static By CentresLink = By.XPath("//a[contains(text(), 'Providers')]");
        public static By TlevelLink = By.XPath("//a[@href='/tlevels']");
        private readonly By MenuBtn = By.XPath("//button[contains(text(),'Menu')]");
        private static readonly By PageTitle = By.TagName("h1");
        private static readonly string ManageCentresPageHeader = "Your T Levels";
        private static readonly By ViewCookieBannerBtn = By.XPath("//a[@class='govuk-button' and @href='/cookie-policy']");
        public By AccesslibilityLink = By.XPath("//a[contains(text(),'Accessibility statement')]");

        public void ViewUserAccount()
        {
            WebDriver.FindElement(UserAccountLink).Click();
            //TODO: Add Check Point
        }

        public void ManageCentres()
        {
            ClickElement(CentresLink);
            PageHelper.WaitForPageLoad(2);
            Assert.AreEqual(WebDriver.FindElement(PageTitle).Text, ManageCentresPageHeader);
        }

        public void ManageTlevels()
        {
            //WebDriver.FindElement(TlevelLink).Click();
            ClickElement(TlevelLink);
            PageHelper.VerifyPageUrl(WebDriver.Url, TlevelPageUrl);
        }

        public void SignoutFromMenu()
        {
            //WebDriver.FindElement(MenuBtn).Click();
            ClickElement(MenuBtn);
            //WebDriver.FindElement(SignOutLink).Click();
            ClickElement(SignOutLink);
        }

        public void CheckServiceBannerLink()
        {
            //WebDriver.FindElement(DashboardHeadLink).Click();
            ClickElement(DashboardHeadLink);
            PageHelper.VerifyPageUrl(WebDriver.Url, DashboardUrl);
        }

        public static void VerifyTLevelHeader()
        {
            PageHelper.VerifyPageUrl(WebDriver.Url, DashboardUrl);
            Assert.AreEqual(Constants.DashBoardHeader, WebDriver.FindElement(PageTitle).Text);
        }

        public static void CheckDashboardpage()
        {
            PageHelper.VerifyPageUrl(WebDriver.Url, DashboardUrl);
            Assert.AreEqual(Constants.DashBoardHeader, WebDriver.FindElement(PageTitle).Text);
            Assert.IsTrue(PageHelper.CheckForLink(StartPage.CookieUrl));
            Assert.IsTrue(PageHelper.CheckForLink(StartPage.PrivacyUrl));
            Assert.IsTrue(PageHelper.CheckForLink(StartPage.TermsUrl));
        }

        public static void ViewCookieBanner()
        {
            ClickElement(ViewCookieBannerBtn);
        }
    }
}
