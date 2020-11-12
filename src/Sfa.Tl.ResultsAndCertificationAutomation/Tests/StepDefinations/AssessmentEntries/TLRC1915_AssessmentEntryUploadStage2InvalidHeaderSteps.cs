using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class TLRC1915_AssessmentEntryUploadStage2InvalidHeaderSteps : AssessmentEntriesPage
    {
        [Then(@"I should see error related to invalid header")]
        public void ThenIShouldSeeErrorRelatedToInvalidHeader()
        {
            CsvFileReader.CsvDataFileCompare(AssessmentUploadStage2InvalidHeaderErrors);
        }
    }
}
