using System.Threading;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Hooks;
using Sfa.Tl.ResultsAndCertificationAutomation.ObjectRepository;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class DfESignInPage : Hooks
    {
        public static string dfeSignInUrl;
        public static string dfeUserName;
        public static string dfePassword;
        public static string dfeInvalidUserName;
        public static string dfeInvalidPassword;
        public By UserIdTxtBox = By.Id("username");
        public By PasswordTxtBox = By.Id("password");
        public By SignInButton = By.XPath("//button[contains(text(),'Sign in')]");
        public string expectedUrl = DfESignInPageElements.DfEExpectedUrl;
        public const string DfSigninError = "Information missing or incorrect";
        public By DfESignInErrorMessage = By.Id("error-summary");
        
        public DfESignInPage()
        {
            dfeSignInUrl = Constants.DfESignInUrl;
            dfeUserName = Constants.DfEUserName;
            dfePassword = Constants.DfEPassword;
            dfeInvalidUserName = Constants.DfEInvalidUserName;
            dfeInvalidPassword = Constants.DfEInvalidPassword;
        }
        
        public static void DfESignIn(string username, string password)
        {
            WebDriver.FindElement(By.Id("username")).SendKeys(username);
            WebDriver.FindElement(By.Id("password")).SendKeys(password);
            WebDriver.FindElement(By.XPath("//button[contains(text(),'Sign in')]")).Click();
            Thread.Sleep(5000);
        }
    }
}
