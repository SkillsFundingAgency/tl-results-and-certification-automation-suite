using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualDecideSpecialismPageSteps : RegistrationsManualPage
    {
        [When(@"I select Core and click Continue button")]
        public void WhenISelectCoreAndClickContinueButton()
        {
            SelectCoreFromList(InputCore);
            ClickContiune();
        }
        
        [Then(@"I should see Devide Specialism Page")]
        public void ThenIShouldSeeDevideSpecialismPage()
        {
            VerifySpecialismDecidePage();
        }
    }
}
