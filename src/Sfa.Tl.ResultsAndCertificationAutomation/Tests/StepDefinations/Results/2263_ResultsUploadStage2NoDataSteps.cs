using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class ResultsUploadStage2NoDataSteps : ResultsDashboardPage
    {
        [Then(@"I should see no data error in the results downloaded file")]
        public void ThenIShouldSeeNoDataErrorInTheResultsDownloadedFile()
        {
            CsvFileReader.CsvDataFileCompare(ResultsUploadStage2NoDataErrors);
        }
    }
}
