using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class TLRC1863_AssessmentEntriesDashboardPageSteps : AssessmentEntriesPage
    {
        [Given(@"I click on ""(.*)"" link")]
        [When(@"I click on ""(.*)"" link")]
        public void WhenIClickOnLink(string link)
        {
            ClickLinkByLabel(link);
        }
        
        [Then(@"I should see Assessment entry dashboard page")]
        public void ThenIShouldSeeAssessmentEntryDashboardPage()
        {
            VerifyAssessmentEntriesPage();
            CheckLinksOnAssessmentEntriesPage();
        }
    }
}
