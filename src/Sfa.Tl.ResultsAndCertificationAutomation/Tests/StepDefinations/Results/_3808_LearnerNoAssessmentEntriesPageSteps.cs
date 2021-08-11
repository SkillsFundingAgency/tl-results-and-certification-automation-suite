using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Results;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class _3808_LearnerNoAssessmentEntriesPageSteps : LearnerResultNoAssessmentPage
    {
        [Then(@"I should see learner result no assessment page")]
        public void ThenIShouldSeeLearnerResultNoAssessmentPage()
        {
            VerifyLearnerNoAssessmentPage();
        }
    }
}
