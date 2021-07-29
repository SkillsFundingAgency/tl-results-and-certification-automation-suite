using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3772_BlockResultUpdateForFinalSteps : CrateRegistrationInDb
    {
        private readonly ScenarioContext _scenarioContext;
        public _3772_BlockResultUpdateForFinalSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I have registration in final state")]
        public void GivenIHaveRegistrationInFinalState()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            CreateRegWithFinalState(uln);
        }
        
        [Then(@"I should see a Final tag on the page")]
        public void ThenIShouldSeeAFinalTagOnThePage()
        {
            ResultsLearnersResultsPage.VerifyLearnerResultPage();
            ResultsLearnersResultsPage.VerifyFinalHeader();
        }
    }
}
