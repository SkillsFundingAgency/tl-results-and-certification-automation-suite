using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class ResultsUploadStage3WithdrawnRegSteps : ResultsDashboardPage
    {
        [Then(@"I should see stage(.*) withdrawn validation error in the results downloaded file")]
        public void ThenIShouldSeeStageWithdrawnValidationErrorInTheResultsDownloadedFile(int p0)
        {
            CsvFileReader.CsvDataFileCompare(ResultsUploadStage3WithdrawnErrors);
        }
    }
}
