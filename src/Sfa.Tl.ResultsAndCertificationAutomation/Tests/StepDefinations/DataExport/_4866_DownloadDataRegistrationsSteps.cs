using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.DataExport;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.DataExport
{
    [Binding]
    public class _4866_DownloadDataRegistrationsSteps: DataExportRegistrationsPage
    {
        [Given(@"I have moved registraion to withdrawn state")]
        public void GivenIHaveMovedRegistraionToWithdrawnState()
        {
            SqlQueriesBulkUploads.UpdateToWithdrawn("9500000002");
        }

        [Given(@"I changed academic year to ""(.*)""")]
        public void GivenIChangedAcademicYearTo(int year)
        {
            SqlQueriesBulkUploads.UpdateAcademicYear(year);
        }
        
        [Given(@"I am on registration home page")]
        public void GivenIAmOnRegistrationHomePage()
        {
            NavigateToRegistrationPage();
        }

        [When(@"I click the link containing '(.*)'")]
        public void WhenIClickTheLinkContaining(string p0)
        {
            DownloadRegistrationFile();
        }
        
        [Then(@"registration file should be downloaded")]
        public void ThenRegistrationFileShouldBeDownloaded()
        {
            VerifyDownloadRegistrationsPage();
            CsvFileReader.CsvRegistrationDataFileCompare(RegistrationsDownloadFile);
        }
    }
}
