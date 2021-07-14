using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3714_NoRegisteredAssessmentSeriesSteps: NoRegisteredAssessmentSeriesPage
    {
        private readonly ScenarioContext _scenarioContext;
        public _3714_NoRegisteredAssessmentSeriesSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Then(@"I should see learner does not have assessment page")]
        public void ThenIShouldSeeLearnerDoesNotHaveAssessmentPage()
        {
            VerifyNoAssessmentPage();
        }
        [Then(@"Back link should takes back to seach learnerpage")]
        public void ThenBackLinkShouldTakesBackToSeachLearnerpage()
        {
            string uln = _scenarioContext["uln"] as string;
            VerifyBackLink(uln);
        }
        [Then(@"clicking Search again button takes to serch learner page")]
        public void ThenClickingSearchAgainButtonTakesToSerchLearnerPage()
        {
            PressSearchBtn();
            PressStartAgainBtn();
            ReviewsAndAppealsSearchLearner.VerifySearchLearnerPage();
        }
        [Then(@"clicking on back to home takes to dashboard page")]
        public void ThenClickingOnBackToHomeTakesToDashboardPage()
        {
            PressBackToHomeBtn();
            TlevelDashboardPage.VerifyTLevelHeader();
        }
    }
}
