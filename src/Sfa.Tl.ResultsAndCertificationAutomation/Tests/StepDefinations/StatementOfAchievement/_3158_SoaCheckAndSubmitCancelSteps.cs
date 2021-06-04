using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.StatementOfAchievement
{
    [Binding]
    public class _3158_SoaCheckAndSubmitCancelSteps : SOACheckAndSubmitCancelPage
    {
        [Then(@"I should see SOA cancel request page")]
        public void ThenIShouldSeeSOACancelRequestPage()
        {
            VerifySoaCancelPage();
            VerifyRadioOptions();
        }
        [Then(@"Back link should takes me to SOA check and submit page")]
        public void ThenBackLinkShouldTakesMeToSOACheckAndSubmitPage()
        {
            ClickBackLink();
            SOACheckAndSubmitPage.VerifySOACheckAndSubmitPage();
        }
        [Then(@"I should see the following error message")]
        public void ThenIShouldSeeTheFollowingErrorMessage(Table table)
        {
            CommonPage.VerifyValidationMessage(table);
        }
        [When(@"I select No, do not cancel radio option")]
        public void WhenISelectNoDoNotCancelRadioOption()
        {
            ClickElement(CancelNo);
        }

        [Then(@"It should takes me to SOA check and submit page")]
        public void ThenItShouldTakesMeToSOACheckAndSubmitPage()
        {
            SOACheckAndSubmitPage.VerifySOACheckAndSubmitPage();
        }
        [When(@"I select Yes cancel radio option")]
        public void WhenISelectYesCancelRadioOption()
        {
            ClickElement(CancelYes);
        }

        [Then(@"It should takes me to home page")]
        public void ThenItShouldTakesMeToHomePage()
        {
            Assert.AreEqual(TlevelDashboardPage.DashboardUrl, WebDriver.Url);
        }
    }
}
