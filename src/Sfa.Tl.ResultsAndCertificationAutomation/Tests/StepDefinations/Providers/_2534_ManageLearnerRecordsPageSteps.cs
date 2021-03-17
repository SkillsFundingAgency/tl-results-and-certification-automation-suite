using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2534_ManageLearnerRecordsPageSteps : LearnerManageLearnerRecordsPage
    {
        [Then(@"I should see Manage learner records page")]
        public void ThenIShouldSeeManageLearnerRecordsPage()
        {
            VerifyManageLearnerRecordsPage();
        }
        
        [Then(@"I should see ""(.*)"" and ""(.*)"" links")]
        public void ThenIShouldSeeAndLinks(string p0, string p1)
        {
            VerifyLinksOnManageLearnerRecordsPage(p0, p1);
        }
        
        [Then(@"I should be back to dashboard page when i click on home breadcrumb")]
        public void ThenIShouldBeBackToDashboardPageWhenIClickOnHomeBreadcrumb()
        {
            ClickHomeLink();
            TlevelDashboardPage.VerifyDashboardpage();
        }
    }
}
