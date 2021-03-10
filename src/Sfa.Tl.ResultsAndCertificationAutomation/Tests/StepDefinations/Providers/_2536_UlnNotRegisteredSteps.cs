using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2536_UlnNotRegisteredSteps : Pages.CommonUlnDbSteps
    {
        private readonly ScenarioContext _scenarioContext;
        public _2536_UlnNotRegisteredSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Then(@"I should see Uln is not registered page")]
        public void ThenIShouldSeeUlnIsNotRegisteredPage()
        {
            var uln = _scenarioContext["uln"] as string;
            VerifyUlnNotRegisteredPage(uln);
        }
        
        [Then(@"I should be back to Add learner page")]
        public void ThenIShouldBeBackToAddLearnerPage()
        {
            VerifyAddANewLearnerRecordPage();
        }

        [Then(@"I should be back to Add learner page when i click Back to search button")]
        public void ThenIShouldBeBackToAddLearnerPageWhenIClickBackToSearchButton()
        {
            ClickContinue();
            ClickButton(BackToSearchBtn);
            VerifyAddANewLearnerRecordPage();
        }

    }
}
