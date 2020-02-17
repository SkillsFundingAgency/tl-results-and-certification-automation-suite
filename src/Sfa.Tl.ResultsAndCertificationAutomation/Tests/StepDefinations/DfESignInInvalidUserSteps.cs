using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class DfESignInInvalidUserSteps : DfESignInPage
    {
        [Given(@"I have entered invalid Username or Password")]
        public void GivenIHaveEnteredInvalidUsernameOrPassword()
        {
            WebDriver.FindElement(UserIdTxtBox).SendKeys(DfeInvalidUserName);
            WebDriver.FindElement(PasswordTxtBox).SendKeys(DfeInvalidPassword);
        }
        
        [Then(@"User should not logged to see Tlevel Dashboard page")]
        public void ThenUserShouldNotLoggedToSeeTlevelDashboardPage()
        {
            Assert.AreNotEqual(WebDriver.Url, Constants.TlevelDashboardUrl);
        }
        
        [Then(@"an Error Message should be displayed for Invalid username")]
        public void ThenAnErrorMessageShouldBeDisplayedForInvalidUsername()
        {
            PageHelper.WaitForElement(DfESignInErrorMessage, 30);
            Assert.AreEqual(SigninError, WebDriver.FindElement(DfESignInErrorMessage).Text);
        }
    }
}
