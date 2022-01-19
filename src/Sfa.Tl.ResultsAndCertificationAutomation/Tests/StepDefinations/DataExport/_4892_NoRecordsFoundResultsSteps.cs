using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.DataExport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.DataExport
{
    [Binding]
    public class _4892_NoRecordsFoundResultsSteps : DataExportResultsPage
    {
        [Then(@"No result records found page is displayed")]
        public void ThenNoResultRecordsFoundPageIsDisplayed()
        {
            VerifyNoResultsRecordPage();
        }
        
        [Then(@"click on Add Result will take to Results page")]
        public void ThenClickOnAddResultWillTakeToResultsPage()
        {
            AddResults();
        }
    }
}
