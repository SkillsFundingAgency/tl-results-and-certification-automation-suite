using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationsBulkUploadWithUpdateSteps : RegistrationsPage
    {
        [When(@"click on back to registration link")]
        public void WhenClickOnBackToRegistrationLink()
        {
            VerifyRegistrationSuccessPage();
            ClickElement(BacktoRegistrationLink);
            ClickElement(UploadRegistationLink);
        }
        
        [When(@"upload file with updated data and submit")]
        public void WhenUploadFileWithUpdatedDataAndSubmit()
        {
            VerifyRegistrationUploadPage();
            UploadFile(ChooseFile, UploadValidUpdatedFile);
            ClickElement(SubmitFileBtn);
        }
    }
}
