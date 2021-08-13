using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3995_Exceptions_ComponentGradeStatusPageSteps : SqlQueries
    {
        [Given(@"I set the End date for the Autumn Assessment Series to a date in the past")]
        public void GivenISetTheEndDateForTheAutumnAssessmentSeriesToADateInThePast()
        {
            UpdateAutumn2021AssessmentSeriesWithPastDate();
        }

        [Then(@"the End date for the Summer Assessment Series is reset to the date in the future")]
        public void ThenTheEndDateForTheAutumnAssessmentSeriesIsResetToTheDateInTheFuture()
        {
            UpdateAutumn2021AssessmentSeriesWithFutureDate();
        }

        [Then(@"the user will be shown text to state the result is final as the date for appeal has passed")]
        public void ThenTheUserWillBeShownTextToStateTheResultIsFinalAsTheDateForAppealHasPassed()
        {
            RAULearnersComponentGradesStatusPage.VerifyResultIsFinalBecauseAppealDateHasPassedTextIsDisplayed();
        }
    }
}
