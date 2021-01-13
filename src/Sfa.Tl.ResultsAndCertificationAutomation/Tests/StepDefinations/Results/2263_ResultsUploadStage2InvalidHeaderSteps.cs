using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System.Threading;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class ResultsUploadStage2InvalidHeaderSteps : ResultsDashboardPage
    {
        [When(@"I download the Results error file and verify")]
        public void WhenIDownloadTheResultsErrorFileAndVerify()
        {
            VerifyUploadResultsUnsuccessPage();
            ClickElement(RegistrationsPage.DownloadErrorLink);
            Thread.Sleep(5000);
        }
        
        [Then(@"I should see invalid header error in the results downloaded file")]
        public void ThenIShouldSeeInvalidHeaderErrorInTheResultsDownloadedFile()
        {
            CsvFileReader.CsvDataFileCompare(ResultsUploadStage2InvalidHeaderErrors);
        }
    }
}
