using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationsStage4ValidationsSteps : RegistrationsPage
    {
        [When(@"I upload Stage four invalid datafile and click on submit")]
        public void WhenIUploadInvalidDatafileAndClickOnSubmit()
        {
            VerifyRegistrationUploadPage();
            UploadFile(ChooseFile, UploadStage4File);
            ClickElement(SubmitFileBtn);
        }
        
        [Then(@"I should see all stage four validation errors in the file")]
        public void ThenIShouldSeeAllValidationErrorsInTheFile()
        {
            CsvFileReader.CsvDataFileCompare(Stage4Errors);
        }
    }
}
