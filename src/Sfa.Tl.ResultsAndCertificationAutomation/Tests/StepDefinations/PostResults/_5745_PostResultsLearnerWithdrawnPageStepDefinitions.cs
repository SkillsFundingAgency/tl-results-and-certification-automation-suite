using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostResults
{
    [Binding]
    public class _5745_PostResultsLearnerWithdrawnPageStepDefinitions : LearnerWithdrawnPage
    {
        private readonly ScenarioContext _scenarioContext;
        public _5745_PostResultsLearnerWithdrawnPageStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Then(@"learner withdrawn page is shown")]
        public void ThenLearnerWithdrawnPageIsShown()
        {
            VerifyLearnerWithdrawnPage();
        }

        [Then(@"back link takes me to search learner page with uln populated")]
        public void ThenBackLinkTakesMeToSearchLearnerPageWithUlnPopulated()
        {
            var uln = _scenarioContext["uln"] as string;
            VerifyBackLink(uln);
        }
    }
}
