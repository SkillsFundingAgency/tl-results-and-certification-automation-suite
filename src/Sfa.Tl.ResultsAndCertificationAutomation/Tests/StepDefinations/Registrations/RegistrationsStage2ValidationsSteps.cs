using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System.Threading;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationsStage2ValidationsSteps : RegistrationsPage
    {
        [When(@"I upload Stage(.*) invalid datafile and click on submit")]
        public void WhenIUploadStageInvalidDatafileAndClickOnSubmit(int p0)
        {
            VerifyRegistrationUploadPage();
            UploadFile(ChooseFile, UploadStage2File);
            ClickElement(SubmitFileBtn);
        }
        
        [When(@"i click on Download Error flie")]
        public void WhenIClickOnDownloadErrorFlie()
        {
            VerifyRegistrationUnSuccessPage();
            ClickElement(DownloadErrorLink);
            Thread.Sleep(2000);
        }
        
        [Then(@"I should see all validation errors in the file")]
        public void ThenIShouldSeeAllValidationErrorsInTheFile()
        {
            CsvFileReader.CsvDataFileCompare(Stage2Errors);
        }
    }
}
