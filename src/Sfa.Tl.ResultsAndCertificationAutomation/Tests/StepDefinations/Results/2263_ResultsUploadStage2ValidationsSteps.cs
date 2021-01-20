using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class ResultsUploadStage2ValidationsSteps : ResultsDashboardPage
    {
        [Then(@"I should see all stage(.*) validations in the results downloaded file")]
        public void ThenIShouldSeeAllStageValidationsInTheResultsDownloadedFile(int p0)
        {
            CsvFileReader.CsvDataFileCompare(ResultsUploadStage2Errors);
        }
    }
}
