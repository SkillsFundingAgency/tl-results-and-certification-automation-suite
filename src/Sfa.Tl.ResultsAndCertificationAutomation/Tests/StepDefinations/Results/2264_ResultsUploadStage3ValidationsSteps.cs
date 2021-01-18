using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class ResultsUploadStage3ValidationsSteps : ResultsDashboardPage
    {
        [Then(@"I should see all stage (.*) validation errors in the results downloaded file")]
        public void ThenIShouldSeeAllStageValidationErrorsInTheResultsDownloadedFile(int p0)
        {
            CsvFileReader.CsvDataFileCompare(ResultsUploadStage3Errors);
        }
    }
}
