using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Threading;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class ErrorPages401Steps : StartPage
    {
        private static readonly string DfEUserName = ConfigHelper.GetAOAllUser();
        private static readonly string DfEPassword = ConfigHelper.GetAOPassword();

        [Given(@"I have entered Access Denied Url in the browser")]
        public void GivenIHaveEnteredAccessDeniedUrlInTheBrowser()
        {
            WebDriver.Navigate().GoToUrl(Error401);
        }
        
        [When(@"I enter valid DfE signin username and password and click on Sign in button")]
        public void WhenIEnterValidDfESigninUsernameAndPasswordAndClickOnSignInButton()
        {
            DfESignInPage.DfESignIn(DfEUserName, DfEPassword);
        }
        
        [Then(@"I should see Access Denied error")]
        public void ThenIShouldSeeAccessDeniedError()
        {
            Thread.Sleep(3000);
            PageHelper.VerifyPageUrl(WebDriver.Url, Error401);
            Assert.IsTrue(WebDriver.FindElement(PageHeader).Text.Contains(Constants.Error401));
        }
    }
}
