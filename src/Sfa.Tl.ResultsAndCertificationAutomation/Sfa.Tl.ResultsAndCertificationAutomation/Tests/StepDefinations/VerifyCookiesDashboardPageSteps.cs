using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System.Threading;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using NUnit;
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
            Thread.Sleep(2000);
            DfESignInPage.DfESignIn(DfEUserName, DfEPassword);
        }
        
        [When(@"click on Cooke link in Dahsboard page")]
        public void WhenClickOnCookeLinkInDahsboardPage()
        {
            WebDriver.FindElement(CookieLink).Click();
            Thread.Sleep(2000);
        }
        
        [Then(@"Cookeis page should open")]
        public void ThenCookeisPageShouldOpen()
        {
            Assert.AreEqual(CookieUrl, WebDriver.Url);
            Assert.AreEqual("Cookies", WebDriver.FindElement(CookieTitle).Text);
        }
    }
}
