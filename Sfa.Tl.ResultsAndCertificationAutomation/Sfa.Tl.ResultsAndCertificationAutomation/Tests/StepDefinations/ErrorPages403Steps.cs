using System.Threading;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;
using Xunit;

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
            Assert.Equal(Constants.SelectOrganisation,WebDriver.FindElement(PageHeader).Text);
            WebDriver.FindElement(SelectOrgNcfe).Click();
            Thread.Sleep(2000);
            WebDriver.FindElement(OrgContinueBtn).Click();
            Thread.Sleep(2000);
            
            // TODO: REMOVE ME
            if (WebDriver.FindElement(PageHeader).Text == Constants.SelectOrganisation)
            {
                WebDriver.FindElement(SelectOrgNcfe).Click();
                Thread.Sleep(2000);
                WebDriver.FindElement(OrgContinueBtn).Click();
            }
        }

        [Then(@"I should see access denied error")]
        public void ThenIShouldSeeAccessDeniedError()
        {
            PageHelper.WaitForPageElementBy(5, PageHeader);
            Assert.Equal(StartPage.Error403, WebDriver.Url);
            Assert.Equal(Constants.Error401, WebDriver.FindElement(PageHeader).Text);
        }
    }
}
