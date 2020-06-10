using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class UploadRegistrationFileSteps : RegistrationsPage
    {
        [When(@"I click on Upload Registration file link")]
        public void WhenIClickOnUploadRegistrationFileLink()
        {
            ClickElement(UploadRegistationLink);
        }
        
        [When(@"I upload a file and click on Submit button")]
        public void WhenIUploadAFileAndClickOnSubmitButton()
        {
            VerifyRegistrationUploadPage();
            UploadFile(ChooseFile, UploadValidFile);
            ClickElement(SubmitFileBtn);
        }
        
        [Then(@"I should see upload successful message")]
        public void ThenIShouldSeeUploadSuccessfulMessage()
        {
            VerifyRegistrationSuccessPage();
            ClickElement(BacktoRegistrationLink);
        }
        
        [Then(@"I should be navigated back to Registrations Page when i click on Back to registration button")]
        public void ThenIShouldBeNavigatedBackToRegistrationsPageWhenIClickOnBackToRegistrationButton()
        {
            VerifyRegistrationDashboardPage();
        }
    }
}
