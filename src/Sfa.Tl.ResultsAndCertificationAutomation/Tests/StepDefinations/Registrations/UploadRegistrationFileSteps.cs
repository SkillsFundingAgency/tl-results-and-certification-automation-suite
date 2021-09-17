using Sfa.Tl.ResultsAndCertificationAutomation.Data;
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
            SqlQueries.DeleteFromRegistrationTables();
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

        [Then(@"I will be shown the Registrations uploaded successfully page")]
        public void ThenIWillBeShownTheRegistrationsUploadedSuccessfullyPage()
        {
            VerifyRegistrationSuccessPage();
        }


        [Then(@"I should be navigated back to Registrations Page when i click on Back to registration button")]
        public void ThenIShouldBeNavigatedBackToRegistrationsPageWhenIClickOnBackToRegistrationButton()
        {
            VerifyRegistrationDashboardPage();
        }

        [When(@"I click the Upload another file button on the Registrations uploaded successfully page")]
        public void WhenIClickTheUploadAnotherFileButtonOnTheRegistrationsUploadedSuccessfullyPage()
        {
            ClickUploadAnotherFileBtn();
        }

        [Then(@"I am shown the Upload registration file page")]
        public void ThenIAmShownTheUploadRegistrationFilePage()
        {
            RegistrationsPage.VerifyRegistrationUploadPage();
        }

        [When(@"I click the Back to home button on the Registrations uploaded successfully page")]
        public void WhenIClickTheBackToHomeButtonOnTheRegistrationsUploadedSuccessfullyPage()
        {
            RegistrationsPage.ClickBacktoHomeBtn();
        }

        [Then(@"I am shown the Registrations Search for a registration page")]
        public void ThenIAmShownTheRegistrationsSearchForARegistrationPage()
        {
            RegistrationsManualPage.VerifyRegistrationSearchPage();
        }

        [When(@"I click the manage individual registrations link on the Registrations uploaded successfully page")]
        public void WhenIClickTheManageIndividualRegistrationsLinkOnTheRegistrationsUploadedSuccessfullyPage()
        {
            RegistrationsPage.ClickManageIndividualRegistrationsLink();
        }

        [When(@"I click the add assessment periods link on the Registrations uploaded successfully page")]
        public void WhenIClickTheAddAssessmentPeriodsLinkOnTheRegistrationsUploadedSuccessfullyPage()
        {
            RegistrationsPage.ClickAssessmentPeriodsLink();
        }

        [Then(@"I am shown the Assessments dashboard page")]
        public void ThenIAmShownTheAssessmentsDashboardPage()
        {
            AssessmentEntriesPage.VerifyAssessmentEntriesPage();
        }        
    }
}
