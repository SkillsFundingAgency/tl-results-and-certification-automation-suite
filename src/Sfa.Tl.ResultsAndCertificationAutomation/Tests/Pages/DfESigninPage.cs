using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Hooks;
using Sfa.Tl.ResultsAndCertificationAutomation.ObjectRepository;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class DfESignInPage : Hooks
    {
        public static string DfeSignInUrl;
        public static string DfeUserName;
        public static string DfePassword;
        public static string DfeInvalidUserName;
        public static string DfeInvalidPassword;
        public By UserIdTxtBox = By.Id("username");
        public By PasswordTxtBox = By.Id("password");
        public By SignInButton = By.XPath("//button[contains(text(),'Sign in')]");
        public string ExpectedUrl = DfESignInPageElements.DfEExpectedUrl;
        public const string SigninError = "Information missing or incorrect";
        public By DfESignInErrorMessage = By.Id("error-summary");
        
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
            //PageHelper.WaitForUrl(TlevelDashboardPage.StartPageUrl);
        }
    }
}
