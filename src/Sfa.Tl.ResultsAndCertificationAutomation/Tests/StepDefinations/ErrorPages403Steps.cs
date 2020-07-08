using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class ErrorPages403Steps : TlevelDashboardPage
    {
        private static readonly string DfEUserName = WebDriverFactory.Config["AONoService"];
        private static readonly string DfEPassword = WebDriverFactory.Config["AOPassword"];

        [Given(@"I login with No User account")]
        public void GivenILoginWithNoUserAccount()
        {
            WebDriver.Navigate().GoToUrl(StartPageUrl);
        }

        [When(@"I select Organisation and click on Continue button")]
        public void WhenISelectOrganisationAndClickOnContinuebutton()
        {
            WebDriver.FindElement(DfESignInPage.StartNowButton).Click();
            DfESignInPage.DfESignIn(DfEUserName, DfEPassword);
        }

        [Then(@"I should see access denied error")]
        public void ThenIShouldSeeAccessDeniedError()
        {
            PageHelper.WaitForUrl(StartPage.Error403);
            PageHelper.VerifyPageUrl(WebDriver.Url, StartPage.Error403);
            Assert.AreEqual(Constants.Error401, WebDriver.FindElement(PageHeader).Text);
        }
    }
}
