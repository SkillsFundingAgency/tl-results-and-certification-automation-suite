using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class TLRC1915_AssessmentEntryUploadStage2NoDataSteps : AssessmentEntriesPage
    {
        [Then(@"I should see no data error")]
        public void ThenIShouldSeeNoDataError()
        {
            CsvFileReader.CsvDataFileCompare(AssessmentUploadStage2NoDataErrors);
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
