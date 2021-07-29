using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3758_BlockResultUpdateManualBeingAppealSteps : CrateRegistrationInDb
    {
        private readonly ScenarioContext _scenarioContext;
        public _3758_BlockResultUpdateManualBeingAppealSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I have registration in appeal state")]
        public void GivenIHaveRegistrationInAppealState()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            CreateRegWithAppealState(uln);
        }
        
        [When(@"I search the Uln to update result")]
        public void WhenISearchTheUlnToUpdateResult()
        {
            ResultsDashboardPage.ClickResultsLink();
            var uln = _scenarioContext["uln"] as string;
            ResultsDashboardPage.searchResult(uln);
        }
        
        [Then(@"I should see a being appealed message on the page")]
        public void ThenIShouldSeeABeingAppealedMessageOnThePage()
        {
            ResultsLearnersResultsPage.VerifyLearnerResultPage();
            ResultsLearnersResultsPage.VerifyBeingAppealed();
        }
        
        [Then(@"Search again button takes me to search result page")]
        public void ThenSearchAgainButtonTakesMeToSearchResultPage()
        {
            ResultsLearnersResultsPage.ClickSearchAgainBtn();
        }
    }
}
