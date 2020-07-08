using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Hooks;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class DfESignInPage : Hooks
    {
        public static string DfeSignInUrl;
        public static string DfeUserName;
        public static string DfePassword;
        public static string DfeInvalidUserName = "test@tleveltest.com";
        public static string AOAdminUser = WebDriverFactory.Config["AOAdminUser"];
        public static string AOAllUser = WebDriverFactory.Config["AOAllUser"];
        public static string AORevProvUser = WebDriverFactory.Config["APRevProUser"];
        public static string AOReviewerUser = WebDriverFactory.Config["AOReviewer"];
        public static string AOProviderUser = WebDriverFactory.Config["AOProviderEditor"];
        public static string AORegistrationUser = WebDriverFactory.Config["AORegistrationEditor"];
        public static string AONoRoleUser = WebDriverFactory.Config["AONoRole"];
        public static string AONoServiceUser = WebDriverFactory.Config["AONoService"];
        public static string AOAppPassword = WebDriverFactory.Config["AOPassword"];
        public static string DashboardUrl = string.Concat(StartPage.StartPageUrl, "home");
        public static readonly By SignInButton = By.XPath("//button[contains(text(),'Sign in')]");
        public const string SigninError = "Information missing or incorrect";
        protected static readonly By PageHeader = By.TagName("h1");

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
            WebDriver.FindElement(UserIdTxtBox).SendKeys(username);
            WebDriver.FindElement(PasswordTxtBox).SendKeys(password);
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
            WebDriver.Navigate().GoToUrl(StartPage.StartPageUrl);
            WebDriver.FindElement(by: StartNowButton).Click();
            WebDriver.FindElement(UserIdTxtBox).SendKeys(AOProviderUser);
            WebDriver.FindElement(PasswordTxtBox).SendKeys(AOAppPassword);
            WebDriver.FindElement(SignInButton).Click();
            PageHelper.WaitForUrl(DashboardUrl);
        }
        public static void SigninAsRegistrationEditor()
        {
            TLevelSignIn(AORegistrationUser, AOAppPassword);
        }
        public static void SigninAsNoRoleNoServiceUser()
        {
            TLevelSignIn(AONoRoleUser, AOAppPassword);
        }
    }
}
