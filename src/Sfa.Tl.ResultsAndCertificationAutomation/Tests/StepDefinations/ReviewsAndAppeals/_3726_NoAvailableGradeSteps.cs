using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3726_NoAvailableGradeSteps : NoRegisteredGradesPage
    {
        [Then(@"I should see learner does not have grade page")]
        public void ThenIShouldSeeLearnerDoesNotHaveGradePage()
        {
            VerifyNoRegisteredGradesPage();
        }
        [When(@"I click on add result link")]
        public void WhenIClickOnAddResultLink()
        {
            ClickAddResultLink();
        }

        [Then(@"I should see Learner results page")]
        public void ThenIShouldSeeLearnerResultsPage()
        {
            ResultsLearnersResultsPage.VerifyLearnerResultPage();
        }

    }
}
