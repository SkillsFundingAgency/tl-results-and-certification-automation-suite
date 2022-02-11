using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.DataExport;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.DataExport
{
    [Binding]
    public class _5130_DownloadDataSpecialismResultsSteps : DataExportResultsPage
    {
        [When(@"I click on link containg specialism results data")]
        public void WhenIClickOnLinkContaingSpecialismResultsData()
        {
           DownloadSpecialismResults();
        }

        [Then(@"the specialism results file should be downloaded")]
        public void ThenTheSpecialismResultsFileShouldBeDownloaded()
        {
            VerifyDownloadResultsPage();
            CsvFileReader.CsvSpecialismResultsDataFileCompare(SpecialismResultsDownloadFile);
        }

        [Then(@"I will see download links for both Core and Specialism results download links")]
        public void ThenIWillSeeDownloadLinksForBothCoreAndSpecialismResultsDownloadLinks()
        {
            VerifyCoreSpecialismDownloadLinksPresent();
        }

        [Then(@"there will only be a download links for Specialism results")]
        public void ThenThereWillOnlyBeADownloadLinksForSpecialismResults()
        {
            VerifyOnlySpecialismDownloadLinksPresent();
        }

    }
}
