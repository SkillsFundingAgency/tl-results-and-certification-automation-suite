using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Features.Registrations
{
    [Binding]
    public class RegistrationUlnWithAnotherAOSteps : RegistrationsManualPage
    {
        [When(@"I select Provider and Core and click continue")]
        public void ISelectProviderAndCoreAndClickContinue()
        {
            SelectProviderFromList(InputPearsonPovider);
            ClickContiune();
            SelectCoreFromList(InputPearsonCore);
            ClickContiune();
        }
        [When(@"I logged in with RegistrationEditor user")]
        public void WhenILoggedInWithRegistrationEditorUser()
        {
            DfESignInPage.SigninAsRegistrationEditor();
            RegistrationsPage.ClickRegLink();
            AddNewRegistrations();
        }
        
        [Then(@"I should see ULN already registered with another AO error")]
        public void ThenIShouldSeeULNAlreadyRegisteredWithAnotherAOError()
        {
            VerifyULNRegWithAnotherAo();
        }
    }
}
