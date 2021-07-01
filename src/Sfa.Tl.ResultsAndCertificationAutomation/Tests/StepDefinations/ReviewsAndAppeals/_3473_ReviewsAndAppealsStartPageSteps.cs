using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3473_ReviewsAndAppealsStartPageSteps : ReviewAndAppealsStartPage
    {
        [Then(@"I should see Reviews and appeals start page")]
        public void ThenIShouldSeeReviewsAndAppealsStartPage()
        {
            VerifyReviewAndAppealsStartPage();
        }
        
        [Then(@"clicking on home breadcrumb takes me to home page")]
        public void ThenClickingOnHomeBreadcrumbTakesMeToHomePage()
        {
            ClickHomeBreadcrumb();
        }
    }
}
