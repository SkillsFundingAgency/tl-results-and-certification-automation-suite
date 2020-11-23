using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Hooks;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class DfESignInPage : Hooks
    {
        public static readonly string DfeInvalidUserName = "test@tleveltest.com";
        private static readonly string AOAdminUser = ConfigHelper.GetAOAdminUser();
        private static readonly string PearsonAdminUser = ConfigHelper.GetPearsonAdminUser();
        private static readonly string AOAllUser = ConfigHelper.GetAOAllUser();
        private static readonly string AORevProvUser = ConfigHelper.GetAPRevProUser();
        private static readonly string AOReviewerUser = ConfigHelper.GetAOReviewer();
        private static readonly string AOProviderUser = ConfigHelper.GetAOProviderEditor();
        private static readonly string AORegistrationUser = ConfigHelper.GetAORegistrationEditor();
        private static readonly string AONoRoleUser = ConfigHelper.GetAONoRole();
        private static readonly string AONoServiceUser = ConfigHelper.GetAONoService();
        public static readonly string AOAppPassword = ConfigHelper.GetAOPassword();
        public static string DashboardUrl = string.Concat(StartPage.StartPageUrl, "home");
        public static readonly By SignInButton = By.XPath("//button[contains(text(),'Sign in')]");
        public const string SigninError = "Information missing or incorrect";
        protected static readonly By PageHeader = By.XPath("//*[@id='main-content']//h1");
        public static By UserIdTxtBox { get; } = By.Id("username");
        public static By PasswordTxtBox { get; } = By.Id("password");
        public static By StartNowButton { get; set; } = By.XPath("//a[@role='button' and contains(text(),'Start now')]");
        public By DfESignInErrorMessage { get; set; } = By.Id("error-summary");

        public static void DfESignIn(string username, string password)
        {
            WebDriver.FindElement(UserIdTxtBox).SendKeys(username);
            WebDriver.FindElement(PasswordTxtBox).SendKeys(password);
            WebDriver.FindElement(SignInButton).Click();
        }

        public static void TLevelSignIn(string username, string password)
        {
            WebDriver.Navigate().GoToUrl(StartPage.StartPageUrl);
            WebDriver.FindElement(by: StartNowButton).Click();
            PageHelper.WaitForPageElementBy(10, UserIdTxtBox);
            WebDriver.FindElement(UserIdTxtBox).SendKeys(username);
            WebDriver.FindElement(PasswordTxtBox).SendKeys(password);
            PageHelper.WaitForPageElementBy(10, SignInButton);
            WebDriver.FindElement(SignInButton).Click();
            PageHelper.WaitForUrl(DashboardUrl);
        }

        public static void SigninAsAOApprover()
        {
            TLevelSignIn(AOAdminUser, AOAppPassword);
        }

        public static void SigninAsAOCentre()
        {
            TLevelSignIn(AOReviewerUser, AOAppPassword);
        }

        public static void SigninAsSiteAdmin()
        {
            TLevelSignIn(AOAdminUser, AOAppPassword);
        }
        public static void SigninAsPearsonSiteAdmin()
        {
            TLevelSignIn(PearsonAdminUser, AOAppPassword);
        }

        public static void SigninAsAllUser()
        {
            TLevelSignIn(AOAllUser, AOAppPassword);
        }

        public static void SigninAsRevProvUser()
        {
            TLevelSignIn(AORevProvUser, AOAppPassword);
        }
        public static void SigninAsReviewer()
        {
            TLevelSignIn(AOReviewerUser, AOAppPassword);
        }
        public static void SigninAsProvider()
        {
            TLevelSignIn(AOProviderUser, AOAppPassword);
        }
        public static void SigninAsRegistrationEditor()
        {
            TLevelSignIn(AORegistrationUser, AOAppPassword);
        }
        public static void SigninAsNoRoleNoServiceUser()
        {
            TLevelSignIn(AONoRoleUser, AOAppPassword);
        }
        public static void SigninAsNoServiceUser()
        {
            WebDriver.Navigate().GoToUrl(StartPage.StartPageUrl);
            WebDriver.FindElement(by: StartNowButton).Click();
            WebDriver.FindElement(UserIdTxtBox).SendKeys(AONoServiceUser);
            WebDriver.FindElement(PasswordTxtBox).SendKeys(AOAppPassword);
            WebDriver.FindElement(SignInButton).Click();
            PageHelper.WaitForUrl(StartPage.Error403);
        }
    }
}
