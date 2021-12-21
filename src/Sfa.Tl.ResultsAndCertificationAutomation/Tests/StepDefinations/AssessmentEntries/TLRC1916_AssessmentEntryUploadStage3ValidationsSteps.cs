using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class TLRC1916_AssessmentEntryUploadStage3ValidationsSteps : AssessmentEntriesPage
    {
        [Given(@"I am on Registrations upload page")]
        public void GivenIAmOnRegistrationsUploadPage()
        {
            SqlQueries.DeleteFromRegistrationTables();
            RegistrationsPage.ClickRegLink();
            ClickElement(RegistrationsPage.UploadRegistationLink);
        }
        [Given(@"I have a Academic Year in ""(.*)""")]
        public void GivenIHaveAAcademicYearIn(string filename)
        {
            CsvFileReader.CsvAcademicYearUpdate(filename);
        }

        [Given(@"I upload ""(.*)"" file")]
        public void GivenIUploadFile(string file)
        {
            UploadFile(RegistrationsPage.ChooseFile, file);
            ClickElement(RegistrationsPage.SubmitFileBtn);
            RegistrationsPage.VerifyRegistrationSuccessPage();
        }

        [Then(@"I am navigated to the Home page")]
        [Given(@"I navigated Home page")]
        [When(@"I navigated Home page")]
        public void GivenINavigatedHomePage()
        {
            ClickElement(TlevelDashboardPage.DashboardHeadLink);
        }

      
        [Then(@"I should see all stage(.*) errors in the file")]
        public void ThenIShouldSeeAllStageErrorsInTheFile(int p0)
        {
            CsvFileReader.CsvDataFileCompare(AssessmentUploadStage3Errors);
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
