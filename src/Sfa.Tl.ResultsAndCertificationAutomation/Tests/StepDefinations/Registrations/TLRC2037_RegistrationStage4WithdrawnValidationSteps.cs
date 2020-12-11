using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System.Threading;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC2037_RegistrationStage4WithdrawnValidationSteps : RegistrationsPage
    {
        [Given(@"I am on upload registration page")]
        public void GivenIAmOnUploadRegistrationPage()
        {
            ClickElement(TlevelDashboardPage.DashboardHeadLink);
            ClickRegLink();
            ClickElement(UploadRegistationLink);
        }
        
        [Then(@"I should see validation errror for witdrawn record")]
        public void ThenIShouldSeeValidationErrrorForWitdrawnRecord()
        {
            VerifyRegistrationUnSuccessPage();
            ClickElement(DownloadErrorLink);
            Thread.Sleep(5000);
            CsvFileReader.CsvDataFileCompare(Stage4WithdrawnErrorFile);
        }
    }
}
