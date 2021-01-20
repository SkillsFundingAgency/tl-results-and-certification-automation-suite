using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class ResultDashboardSteps : ResultsDashboardPage
    {
        [When(@"I click on results link")]
        public void WhenIClickOnResultsLink()
        {
            ClickResultsLink();
        }
        
        [Then(@"I should be navigated to Results dashboard page")]
        public void ThenIShouldBeNavigatedToResultsDashboardPage()
        {
            VerifyResultsDashboardPage();
        }
        
        [Then(@"I should see Upload results file and Search for learner links")]
        public void ThenIShouldSeeUploadResultsFileAndSearchForLearnerLinks()
        {
            VerifyLinksInResultsPage();
        }
    }
}
