using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System.Threading;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class TLRC1915_AssessmentEntryUploadStage2ValidationsSteps : AssessmentEntriesPage
    {
        [When(@"I download the error file and verify")]
        public void WhenIDownloadTheErrorFileAndVerify()
        {
            VerifyAssessmentUploadUnsuccessPage();
            ClickElement(RegistrationsPage.DownloadErrorLink);
            Thread.Sleep(5000);
        }
        
        [Then(@"I should see all stage(.*) validation errors related to Assessments")]
        public void ThenIShouldSeeAllStageValidationErrorsRelatedToAssessments(int p0)
        {
            CsvFileReader.CsvDataFileCompare(AssessmentUploadStage2Errors);
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
