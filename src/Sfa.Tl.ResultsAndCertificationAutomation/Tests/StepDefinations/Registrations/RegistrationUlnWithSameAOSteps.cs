using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Features.Registrations
{
    [Binding]
    public class RegistrationUlnWithSameAOSteps : RegistrationsManualPage
    {
        [When(@"I click on back to registration link")]
        public void WhenIClickOnBackToRegistrationLink()
        {
            ClickElement(RegistrationsPage.BacktoRegistrationBtn);
            AddRegistrations();
        }
        
        [Then(@"I should see ULN already registered page")]
        public void ThenIShouldSeeULNAlreadyRegisteredPage()
        {
            VerifyULNRegWithSameAo();
        }
    }
}
