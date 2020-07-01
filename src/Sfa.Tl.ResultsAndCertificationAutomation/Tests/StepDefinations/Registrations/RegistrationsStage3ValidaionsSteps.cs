using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationsStage3ValidaionsSteps : RegistrationsPage
    {
        [When(@"I upload Stage three invald datafile and click on submit")]
        public void WhenIUploadStageInvaldDatafileAndClickOnSubmit()
        {
            VerifyRegistrationUploadPage();
            UploadFile(ChooseFile, UploadStage3File);
            ClickElement(SubmitFileBtn);
        }
        
        [Then(@"I should see validation errors in the file")]
        public void ThenIShouldSeeValidationErrorsInTheFile()
        {
            CsvFileReader.CsvDataFileCompare(Stage3Errors);
        }
    }
}
