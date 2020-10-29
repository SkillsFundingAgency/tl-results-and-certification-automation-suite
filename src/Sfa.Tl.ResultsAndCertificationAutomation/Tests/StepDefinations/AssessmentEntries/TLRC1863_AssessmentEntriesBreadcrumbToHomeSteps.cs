using Sfa.Tl.ResultsAndCertificationAutomation.ObjectRepository;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class TLRC1863_AssessmentEntriesBreadcrumbToHomeSteps : AssessmentEntriesPage
    {
        [When(@"I click on ""(.*)"" in breadcrumbs")]
        public void WhenIClickOnInBreadcrumbs(string BreadcrumbHome)
        {
            ClickElement(CommonObjects.BreadcrumbHome);
        }
        
        [Then(@"I should be navigated back to home page")]
        public void ThenIShouldBeNavigatedBackToHomePage()
        {
            TlevelDashboardPage.VerifyDashboardpage();
        }
    }
}
