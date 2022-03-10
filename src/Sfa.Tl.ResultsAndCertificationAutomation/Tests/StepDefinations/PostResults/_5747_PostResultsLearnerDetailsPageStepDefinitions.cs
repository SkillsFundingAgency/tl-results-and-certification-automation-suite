using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostResults
{
    [Binding]
    public class _5747_PostResultsLearnerDetailsPageStepDefinitions : PostResultsLearnerDetailsPage
    {
        [Then(@"learner details page is shown")]
        public void ThenLearnerDetailsPageIsShown()
        {
            VerifyPostResultsLearnerDetailsPage();
        }

        [Then(@"add ROMM button is enabled for current assessment series")]
        public void ThenAddROMMButtonIsEnabledForCurrentAssessmentSeries()
        {
            VerifyCountOfAddRommButtons();
        }
        [Then(@"clicking on search again button takes me to Search post result learner page")]
        public void ThenClickingOnSearchAgainButtonTakesMeToSearchPostResultLearnerPage()
        {
            ClickSearchAgainBtn();
            SearchForLearnerPage.VerifySearchLearnerPage();
        }

    }
}
