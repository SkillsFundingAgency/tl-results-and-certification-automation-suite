using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Hooks;
using Sfa.Tl.ResultsAndCertificationAutomation.ObjectRepository;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using WaitHelpers = SeleniumExtras.WaitHelpers;


namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class DfESignInPage : Hooks
    {
        public static string DfeSignInUrl;
        public static string DfeUserName;
        public static string DfePassword;
        public static string DfeInvalidUserName;
        public static string DfeInvalidPassword;
        public static string AOAppUsername = WebDriverFactory.Config["AOAppUser"];
        public static string AOAppPassword = WebDriverFactory.Config["AOAppPW"];
        public static string AOCentreUsername = WebDriverFactory.Config["AOCentreUser"];
        public static string AOCentrePassword = WebDriverFactory.Config["AOCentrePW"];
        public static string AOStandardUsername = WebDriverFactory.Config["AOStandardUser"];
        public static string AOStandardPassword = WebDriverFactory.Config["AOStandardUserPW"];
        private static string SiteAdminUser = WebDriverFactory.Config["SiteAdminUser"];
        private static string SiteAdminPassword = WebDriverFactory.Config["SiteAminPW"];
        private static string AllUser = WebDriverFactory.Config["AllUser"];
        private static string AllUserPassword = WebDriverFactory.Config["AllUserPW"];
        private static string RevProvUser = WebDriverFactory.Config["RevProUser"];
        private static string RevProvPassword = WebDriverFactory.Config["RevProPW"];
        private static string ReviewerUser = WebDriverFactory.Config["ReviewerUser"];
        private static string ReviewerPassword = WebDriverFactory.Config["ReviewerPW"];
        private static string ProviderUser = WebDriverFactory.Config["ProviderUser"];
        private static string ProviderPassword = WebDriverFactory.Config["ProviderPW"];
        private static string NoRoleNoServiceUser = WebDriverFactory.Config["NoRoleNoSerUser"];
        private static string NoRoleNoServicePassword = WebDriverFactory.Config["NoRoleNoSerPW"];
        public static By StartNowButton = By.XPath("//a[@role='button' and contains(text(),'Start now')]");
        public static string DashboardUrl = string.Concat(StartPage.StartPageUrl, "Dashboard");
        public By UserIdTxtBox = By.Id("username");
        public By PasswordTxtBox = By.Id("password");
        public By SignInButton = By.XPath("//button[contains(text(),'Sign in')]");
        public string ExpectedUrl = DfESignInPageElements.DfEExpectedUrl;
        public const string SigninError = "Information missing or incorrect";
        public By DfESignInErrorMessage = By.Id("error-summary");
        public static By Ncfe = By.Id("848D7FB9-ADBD-47EC-A975-3FF9314323EA");
        private static By NcfeOrg = By.XPath("//*[contains(text(),'NCFE')]");
        public static By Pearson = By.Id("13BE668D-833B-410F-A9E4-D7AB3CF14DCD");
        public static By OrgContinueButton = By.XPath("//input[@value='Continue']");
        protected static readonly By PageHeader = By.TagName("h1");

        public DfESignInPage()
        {
            DfeSignInUrl = WebDriverFactory.Config["DfESignInUrl"];
            DfeUserName = WebDriverFactory.Config["DfEUserName"];
            DfePassword = WebDriverFactory.Config["DfEPassword"];
            DfeInvalidUserName = Constants.DfEInvalidUserName;
            DfeInvalidPassword = Constants.DfEInvalidPassword;
        }
        
        public static void DfESignIn(string username, string password)
        {
            WebDriver.FindElement(By.Id("username")).SendKeys(username);
            WebDriver.FindElement(By.Id("password")).SendKeys(password);
            WebDriver.FindElement(By.XPath("//button[contains(text(),'Sign in')]")).Click();
        }

        public static void TLevelSignIn(string username, string password)
        {
            WebDriver.Navigate().GoToUrl(StartPage.StartPageUrl);
            WebDriver.FindElement(by: StartNowButton).Click();
            WebDriver.FindElement(By.Id("username")).SendKeys(username);
            WebDriver.FindElement(By.Id("password")).SendKeys(password);
            WebDriver.FindElement(By.XPath("//button[contains(text(),'Sign in')]")).Click();
            SelectOrganisation();
            PageHelper.WaitForUrl(DashboardUrl);
        }

        public static void SigninAsAOApprover()
        {
            TLevelSignIn(AOAppUsername, AOAppPassword);
        }

        public static void SigninAsAOCentre()
        {
            TLevelSignIn(AOCentreUsername, AOCentrePassword);
        }

        public static void SigninAsStandardUser()
        {
            TLevelSignIn(AOStandardUsername, AOStandardPassword);
        }

        public static void SigninAsSiteAdmin()
        {
            TLevelSignIn(SiteAdminUser, SiteAdminPassword);
        }

        public static void SigninAsAllUser()
        {
            TLevelSignIn(AllUser, AllUserPassword);
        }

        public static void SigninAsRevProvUser()
        {
            TLevelSignIn(RevProvUser, RevProvPassword);
        }
        public static void SigninAsReviewer()
        {
            TLevelSignIn(ReviewerUser, ReviewerPassword);
        }
        public static void SigninAsProvider()
        {
            TLevelSignIn(ProviderUser, ProviderPassword);
        }
        public static void SigninAsNoRoleNoServiceUser()
        {
            TLevelSignIn(NoRoleNoServiceUser, NoRoleNoServicePassword);
        }
        public static void SelectOrganisation()
        {
            ElementHelper.WaitForElementVisible(NcfeOrg, 10);
            Assert.AreEqual(Constants.SelectOrganisation, WebDriver.FindElement(PageHeader).Text);
            WebDriver.FindElement(NcfeOrg).Click();
            WebDriver.FindElement(OrgContinueButton).Click();
            // TODO: REMOVE ME
            ElementHelper.WaitForElementVisible(NcfeOrg, 10);
            WebDriver.FindElement(Ncfe).Click();
            WebDriver.FindElement(OrgContinueButton).Click();
        }
    }
}
