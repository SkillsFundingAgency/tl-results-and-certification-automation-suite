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
        private static string DfEUserName = WebDriverFactory.Config["AoNoRolesUser"];
        private static string DfEPassword = WebDriverFactory.Config["AoNoRolePw"];

        [Given(@"I login with No User account")]
        public void GivenILoginWithNoUserAccount()
        {
            WebDriver.Navigate().GoToUrl(StartPageUrl);
            WebDriver.FindElement(DfESignInPage.StartNowButton).Click();
            DfESignInPage.DfESignIn(DfEUserName, DfEPassword);
        }

        [When(@"I select Organisation and click on Continue button")]
        public void WhenISelectOrganisationAndClickOnContinuebutton()
        {
            DfESignInPage.SelectOrganisation();
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
