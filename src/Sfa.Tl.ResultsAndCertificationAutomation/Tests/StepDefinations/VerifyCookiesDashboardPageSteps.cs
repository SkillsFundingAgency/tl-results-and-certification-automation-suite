using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using NUnit.Framework;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class VerifyCookiesDashboardPageSteps : StartPage
    {
        private static string DfEUserName = WebDriverFactory.Config["DfEUserName"];
        private static string DfEPassword = WebDriverFactory.Config["DfEPassword"];

        [Given(@"Tlevel Start page")]
        public void GivenTlevelStartPage()
        {
            WebDriver.Navigate().GoToUrl(StartPageUrl);
        }
        
        [When(@"user logged in with valid user name and password")]
        public void WhenUserLoggedInWithValidUserNameAndPassword()
        {
            WebDriver.FindElement(StartNowButton).Click();
            DfESignInPage.DfESignIn(DfEUserName, DfEPassword);
        }
        
        [When(@"click on Cooke link in Dahsboard page")]
        public void WhenClickOnCookeLinkInDahsboardPage()
        {
            PageHelper.WaitForUrl(TlevelDashboardPage.DashboardUrl);
            WebDriver.FindElement(CookieLink).Click();
        }
        
        [Then(@"Cookeis page should open")]
        public void ThenCookeisPageShouldOpen()
        {
            PageHelper.WaitForUrl(CookieUrl);
            PageHelper.VerifyPageUrl(WebDriver.Url, CookieUrl);
            Assert.AreEqual("Cookies", WebDriver.FindElement(CookieTitle).Text);
        }
    }
}
