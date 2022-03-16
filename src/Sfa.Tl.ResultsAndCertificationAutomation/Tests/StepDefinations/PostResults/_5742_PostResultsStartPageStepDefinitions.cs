using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostResults
{
    [Binding]
    public class _5742_PostResultsStartPageStepDefinitions : PostResultsStartPage
    {
        [Then(@"I should see Post results start page")]
        public void ThenIShouldSeePostResultsStartPage()
        {
            VerifyReviewAndAppealsStartPage();
        }

        [Then(@"clicking Home breadcrumb takes me to home page")]
        public void ThenClickingHomeBreadcrumbTakesMeToHomePage()
        {
            ClickHomeBreadcrumb();
        }
    }
}
