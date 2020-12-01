using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualSelectSpecialismPageSteps : RegistrationsManualPage
    {
        [When(@"I select Decided Yes option and click Continue button")]
        public void WhenISelectDecidedYesOptionAndClickContinueButton()
        {
            ClickElement(DecideYes);
            ClickContiune();
            
        }
        
        [Then(@"I should see Select Specialism Page")]
        public void ThenIShouldSeeSelectSpecialismPage()
        {
            VerifySpecialismPage();
            VerifySpecialismPageDynamicHeader();
        }
    }
}
