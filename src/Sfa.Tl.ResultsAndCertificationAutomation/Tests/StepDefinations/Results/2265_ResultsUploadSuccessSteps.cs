using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class ResultsUploadSuccessSteps : ResultsDashboardPage
    {
        [Then(@"I should see results upload success page")]
        public void ThenIShouldSeeResultsUploadSuccessPage()
        {
            VerifyUploadResultsSuccessPage();
        }
        
        [Then(@"I should see number of records been uploaded message")]
        public void ThenIShouldSeeNumberOfRecordsBeenUploadedMessage()
        {
            VerifyResultsUploadCount(ResultsSuccessCountMsg);
        }
        
        [Then(@"I should go back to results dashboad on clicking Back to Results button")]
        public void ThenIShouldGoBackToResultsDashboadOnClickingBackToResultsButton()
        {
            VerifyBackToResultsBtn();
        }
    }
}
