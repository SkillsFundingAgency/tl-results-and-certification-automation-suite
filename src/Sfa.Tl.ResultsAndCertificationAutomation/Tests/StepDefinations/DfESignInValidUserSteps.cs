using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class DfESignInValidUserSteps : DfESignInPage
    {
        [Given(@"I have navigated to DfE sign in page")]
        public void GivenIHaveNavigatedToDfESignInPage()
        {
            WebDriver.Navigate().GoToUrl(DfeSignInUrl);
        }
        
        [Given(@"I have entered valid username and password")]
        public void GivenIHaveEnteredValidUsernameAndPassword()
        {
            WebDriver.FindElement(UserIdTxtBox).SendKeys(DfeUserName);
            WebDriver.FindElement(PasswordTxtBox).SendKeys(DfePassword);
        }
        
        [When(@"I have clicked on sign in button")]
        public void WhenIHaveClickedOnSignInButton()
        {
            WebDriver.FindElement(SignInButton).Click();
        }
        
        [Then(@"user logged in to seen Tlevel Dashboard page")]
        public void ThenUserLoggedInToSeenTlevelDashboardPage()
        {
            PageHelper.WaitForUrl(TlevelDashboardPage.DashboardUrl);
            PageHelper.VerifyPageUrl(WebDriver.Url, TlevelDashboardPage.DashboardUrl);
        }
    }
}
