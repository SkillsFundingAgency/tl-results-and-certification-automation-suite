using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualSelectProviderPageSteps : RegistrationsManualPage
    {
        [When(@"I enter Date of Birth in DOB page and click continue")]
        public void WhenIEnterDateOfBirthInDOBPageAndClickContinue()
        {
            EnterDob("1", "12", "2010");
            ClickContiune();
        }
        
        [Then(@"I should see select Provider page")]
        public void ThenIShouldSeeSelectProviderPage()
        {
            VerifyProviderPage();
        }
    }
}
