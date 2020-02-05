using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;
using NUnit;
using NUnit.Framework;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class ErrorPages401Steps : StartPage
    {
        private static string DfEUserName = WebDriverFactory.Config["DfEUserName"];
        private static string DfEPassword = WebDriverFactory.Config["DfEPassword"];

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
            PageHelper.WaitForPageElementBy(5, PageHeader);
            Assert.AreEqual(Error401, WebDriver.Url);
            Assert.AreEqual(Constants.Error401, WebDriver.FindElement(PageHeader).Text);
        }
    }
}
