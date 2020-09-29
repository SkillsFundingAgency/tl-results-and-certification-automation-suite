using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1487_ReactivateConfirmationPageSteps : RegistrationReactivate
    {
        [When(@"I select Yes I want to reactivate option and click submit")]
        public void WhenISelectYesIWantToReactivateOptionAndClickSubmit()
        {
            ClickElement(ReactivateConfirmYes);
            ClickElement(SubmitBtn);
        }
        
        [Then(@"I should see reactivation success page")]
        public void ThenIShouldSeeReactivationSuccessPage()
        {
            VerifyReactivateSuccessPage();
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
