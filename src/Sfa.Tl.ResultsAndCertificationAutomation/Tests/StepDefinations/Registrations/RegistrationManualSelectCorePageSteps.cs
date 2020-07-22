using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualSelectCorePageSteps : RegistrationsManualPage
    {
        [When(@"I select Provider and click Contiune button")]
        public void WhenISelectProviderAndClickContiuneButton()
        {
            SelectProviderFromList(InputPovider);
            ClickContiune();
        }
        
        [Then(@"I should see Select Core Page")]
        public void ThenIShouldSeeSelectCorePage()
        {
            VerifyCorePage();
        }
    }
}
