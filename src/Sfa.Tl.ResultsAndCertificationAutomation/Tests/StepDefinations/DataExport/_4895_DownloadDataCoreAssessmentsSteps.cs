using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.DataExport;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.DataExport
{
    [Binding]
    public class _4895_DownloadDataAssessmentsSteps : DataExportAssessmentsPage
    {
        [Given(@"I am on Home page")]
        public void GivenIAmOnHomePage()
        {
            ClickBanner();
        }
        
        [Given(@"I upload assessment ""(.*)"" file")]
        public void GivenIUploadAssessmentFile(string file)
        {
            UploadFile(RegistrationsPage.ChooseFile, file);
            ClickElement(RegistrationsPage.SubmitFileBtn);
            AssessmentEntriesPage.VerifyAssessmentUploadSuccessPage();
        }
        
        [Given(@"I am on assessment entries home page")]
        public void GivenIAmOnAssessmentEntriesHomePage()
        {
            AssessmentEntriesPage.ClickBacktoHomeBtn();
            ClickElement(AssessmentEntriesPage.AssessmentEntriesLink);
        }
        
        [When(@"I click on link containg ""(.*)""")]
        public void WhenIClickOnLinkContaing(string p0)
        {
            DownloadCoreAssessmentFile();
        }
        
        [Then(@"core assessment file should be downloaded")]
        public void ThenCoreAssessmentFileShouldBeDownloaded()
        {
            VerifyDownloadAssessmentPage();
            CsvFileReader.CsvCoreAssessmentDataFileCompare(CoreAssessmentDownloadFile);
        }

        [When(@"I click on link containg Specialism assessments data")]
        public void WhenIClickOnLinkContaingSpecialismAssessmentsData()
        {
            DownloadSpecialismAssessmentFile();
        }

        [Then(@"specialism assessment file should be downloaded")]
        public void ThenSpecialismAssessmentFileShouldBeDownloaded()
        {
            VerifyDownloadAssessmentPage();
            CsvFileReader.CsvSpecialismAssessmentDataFileCompare(SpecialismAssessmentDownloadFile);
        }
    }
}
