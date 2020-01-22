using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Xunit;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class DfESignInInvalidUserSteps : DfESignInPage
    {
        [Given(@"I have entered invalid Username or Password")]
        public void GivenIHaveEnteredInvalidUsernameOrPassword()
        {
            WebDriver.FindElement(UserIdTxtBox).SendKeys(dfeInvalidUserName);
            WebDriver.FindElement(PasswordTxtBox).SendKeys(dfeInvalidPassword);
        }
        
        [Then(@"User should not logged to see Tlevel Dashboard page")]
        public void ThenUserShouldNotLoggedToSeeTlevelDashboardPage()
        {
            Assert.DoesNotContain(WebDriver.Url, Constants.TlevelDashboardUrl);
        }
        
        [Then(@"an Error Message should be displayed for Invalid username")]
        public void ThenAnErrorMessageShouldBeDisplayedForInvalidUsername()
        {
            Assert.Equal(DfSigninError, WebDriver.FindElement(DfESignInErrorMessage).Text);
        }
    }
}
