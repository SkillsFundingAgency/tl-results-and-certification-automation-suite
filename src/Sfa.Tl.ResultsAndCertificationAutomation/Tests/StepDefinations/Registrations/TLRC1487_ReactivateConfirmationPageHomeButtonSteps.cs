using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1487_ReactivateConfirmationPageHomeButtonSteps : RegistrationReactivate
    {
        [When(@"I click on Home button in confirmation page")]
        public void WhenIClickOnHomeButtonInConfirmationPage()
        {
            ClickElement(HomeBtn);
        }
    }
}
