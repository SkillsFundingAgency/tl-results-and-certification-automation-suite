using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2867_IntegrateULNHasNotBeenAddedWithEnterULNPageSteps : CrateRegistrationInDb
    {
        private readonly ScenarioContext _scenarioContext;
        public _2867_IntegrateULNHasNotBeenAddedWithEnterULNPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [When(@"I click on Continue button on Uln not added page")]
        public void WhenIClickOnContinueButtonOnUlnNotAddedPage()
        {
            var uln = _scenarioContext["uln"] as string;
            UpdateLearnerSearchPage.VerifyUlnNotAddedPage(uln);
            UpdateLearnerSearchPage.ClickContinueBtn();
        }

        [Then(@"I should see add learner record page")]
        public void ThenIShouldSeeAddLearnerRecordPage()
        {
            Pages.CommonUlnDbSteps.VerifyAddANewLearnerRecordPage();
        }
        
        [Then(@"Uln should be retained in the text box")]
        public void ThenUlnShouldBeRetainedInTheTextBox()
        {
            var uln = _scenarioContext["uln"] as string;
            Pages.CommonUlnDbSteps.VerifySeachUlnField(uln);
        }
        [Then(@"clicking on Back link should show Uln not added page")]
        public void ThenClickingOnBackLinkShouldShowUlnNotAddedPage()
        {
            ClickElement(UpdateLearnerSearchPage.backLink);
            var uln = _scenarioContext["uln"] as string;
            UpdateLearnerSearchPage.VerifyUlnNotAddedPage(uln);
        }

    }
}
