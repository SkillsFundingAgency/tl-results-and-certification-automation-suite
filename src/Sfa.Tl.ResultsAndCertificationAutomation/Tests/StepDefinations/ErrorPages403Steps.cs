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

        [When(@"I enter Ao_No_Roles username and password and click on signin button")]
        public void WhenIEnterAo_No_RolesUsernameAndPasswordAndClickOnSigninButton()
        {
            DfESignInPage.DfESignIn(DfEUserName, DfEPassword);
        }

        [When(@"I have selected Organisation and click on Continue button")]
        public void WhenISelectOrganisationAndClickOnContinuebutton()
        {
            PageHelper.WaitForElement(SelectOrgNcfe, 30);
            Assert.AreEqual(Constants.SelectOrganisation,WebDriver.FindElement(PageHeader).Text);
            WebDriver.FindElement(SelectOrgNcfe).Click();
            WebDriver.FindElement(OrgContinueBtn).Click();
            
            // TODO: REMOVE ME
            if (WebDriver.FindElement(PageHeader).Text == Constants.SelectOrganisation)
            {
                PageHelper.WaitForElement(SelectOrgNcfe, 30);
                WebDriver.FindElement(SelectOrgNcfe).Click();
                WebDriver.FindElement(OrgContinueBtn).Click();
            }
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
