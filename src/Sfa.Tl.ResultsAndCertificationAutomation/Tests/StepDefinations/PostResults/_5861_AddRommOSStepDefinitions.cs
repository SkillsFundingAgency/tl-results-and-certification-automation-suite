using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostResults
{
    [Binding]
    public class _5861_AddRommOSStepDefinitions : AddRommPage
    {
        [Then(@"specialism(.*) details shown in the summary")]
        public void ThenSpecialismDetailsShownInTheSummary(int p0)
        {
            VerifyLearnerOs1DetailsAdddRommPage();
        }
        [Then(@"specialism(.*) details are shown in the summary")]
        public void ThenSpecialismDetailsAreShownInTheSummary(int p0)
        {
            VerifyLearnerOs2DetailsAdddRommPage();
        }

    }
}
