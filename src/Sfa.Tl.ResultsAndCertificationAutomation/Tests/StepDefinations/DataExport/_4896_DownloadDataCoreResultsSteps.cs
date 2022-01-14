using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.DataExport;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.DataExport
{
    [Binding]
    public class _4896_DownloadDataCoreResultsSteps : DataExportResultsPage
    {
        [Given(@"I upload results ""(.*)"" file")]
        public void GivenIUploadResultsFile(string file)
        {
            UploadFile(RegistrationsPage.ChooseFile, file);
            ClickElement(RegistrationsPage.SubmitFileBtn);
            ResultsDashboardPage.VerifyUploadResultsSuccessPage();
        }

        [When(@"I click on link containg core results data")]
        public void WhenIClickOnLinkContaingCoreResultsData()
        {
            DownloadCoreResults();
        }
        
        [Then(@"core results file should be downloaded")]
        public void ThenCoreResultsFileShouldBeDownloaded()
        {
            VerifyDownloadResultsPage();
            CsvFileReader.CsvCoreResultsDataFileCompare(CoreResultsDownloadFile);
        }
    }
}
