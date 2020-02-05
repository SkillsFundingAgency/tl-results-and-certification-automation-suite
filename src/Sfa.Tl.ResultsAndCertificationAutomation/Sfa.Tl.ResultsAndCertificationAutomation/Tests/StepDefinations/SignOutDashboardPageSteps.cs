using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System.Threading;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using NUnit.Framework;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class SignOutDashboardPageSteps : StartPage
    {
        private static string DfEUserName = WebDriverFactory.Config["DfEUserName"];
        private static string DfEPassword = WebDriverFactory.Config["DfEPassword"];

        [Given(@"i sign in with valid DfE Username and password")]
        public void GivenISignInWithValidDfEUsernameAndPassword()
        {
            DfESignInPage.DfESignIn(DfEUserName, DfEPassword);
        }
        
        [When(@"I click on Sign Out link")]
        public void WhenIClickOnSignOutLink()
        {
            WebDriver.FindElement(TlevelDashboardPage.SignOutLink).Click();
            Thread.Sleep(2000);
        }
        
        [Then(@"I should be redirectted to Tlevel Start page")]
        public void ThenIShouldBeRedirecttedToTlevelStartPage()
        {
            Assert.AreEqual(StartPageUrl, WebDriver.Url);
        }
    }
}
