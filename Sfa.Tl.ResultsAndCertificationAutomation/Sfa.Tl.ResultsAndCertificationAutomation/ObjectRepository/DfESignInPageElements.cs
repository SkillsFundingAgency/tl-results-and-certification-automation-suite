using System.Configuration;
using OpenQA.Selenium;

namespace Sfa.Tl.ResultsAndCertificationAutomation.ObjectRepository
{
    public class DfESignInPageElements
    {
        private readonly IWebDriver _webDriver;
        
        public DfESignInPageElements(IWebDriver webDriver)
        {
            this._webDriver = webDriver;
        }

        public static string DfESigninUrl => ConfigurationManager.AppSettings["DfESignInUrl"];
        public static string DfEExpectedUrl => ConfigurationManager.AppSettings["TLevelHomePageUrl"];

        public static string DfEUserName => ConfigurationManager.AppSettings["DfEUserName"];
        public static string DfEPassword => ConfigurationManager.AppSettings["DfEPassword"];
        
        public IWebElement DfEUserNameTxtBox => this._webDriver.FindElement(By.Id("Signin-username"));
        public IWebElement DfEPasswordTxtBox => this._webDriver.FindElement(By.Id("Signin-password"));
        public IWebElement DfESignInButton => this._webDriver.FindElement(By.XPath("//button[contains(text(),'Sign in')]"));
    }
}
