using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Results;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class _3823_LearnerWithdrawnPageSteps : LearnerWithdrawnPage
    {
        private readonly ScenarioContext _scenarioContext;
        public _3823_LearnerWithdrawnPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Then(@"I should see learner withdrawn page")]
        public void ThenIShouldSeeLearnerWithdrawnPage()
        {
            VerifyLearnerWithdrawnPage();
        }

        [Then(@"Back link should take me to searhc learner page with Uln")]
        public void ThenBackLinkShouldTakeMeToSearhcLearnerPageWithUln()
        {
            var uln = _scenarioContext["uln"] as string;
            VerifyBackLink(uln);
        }

        [Then(@"Search again shoud take me to searhc learner page without Uln")]
        public void ThenSearchAgainShoudTakeMeToSearhcLearnerPageWithoutUln()
        {
            ClickSearchBtn();
            VerifySearchAgain();
        }
        [Then(@"click on back to home should takes me to dashboard page")]
        public void ThenClickOnBackToHomeShouldTakesMeToDashboardPage()
        {
            VerifyBackToHome();
        }
    }
}
