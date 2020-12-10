using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationsStage1MadatoryFileValidationsSteps : RegistrationsPage
    {
        [Then(@"I should see following error message in upload registration page")]
        public void ThenIShouldSeeFollowingErrorMessageInUploadRegistrationPage(Table table)
        {
            VerifyRegistrationUploadErrorPage();
            CommonPage.VerifyValidationMessage(table);
        }
        
        [Then(@"I should see the following error summary message in upload registration page")]
        public void ThenIShouldSeeTheFollowingErrorSummaryMessageInUploadRegistrationPage(Table table)
        {
            CommonPage.VerifyValidationSummaryMessages(table);
        }
    }
}
