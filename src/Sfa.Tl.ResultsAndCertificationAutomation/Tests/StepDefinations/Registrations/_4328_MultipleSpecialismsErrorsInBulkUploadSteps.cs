using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System.Threading;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class _4328_MultipleSpecialismsErrorsInBulkUploadSteps : RegistrationsPage
    {
        [When(@"I download the registration error file and verify")]
        public void WhenIDownloadTheRegistrationErrorFileAndVerify()
        {
            VerifyRegistrationUnSuccessPage();
            ClickElement(DownloadErrorLink);
            Thread.Sleep(5000);
        }
        
        [Then(@"I should see all errors relted multi specialisms in the file")]
        public void ThenIShouldSeeAllErrorsReltedMultiSpecialismsInTheFile()
        {
            CsvFileReader.CsvDataFileCompare(MultiSpecialismErrors);
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
