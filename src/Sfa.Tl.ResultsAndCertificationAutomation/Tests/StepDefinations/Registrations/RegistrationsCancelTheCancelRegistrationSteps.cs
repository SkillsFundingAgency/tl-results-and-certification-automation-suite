using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationsCancelTheCancelRegistrationSteps : RegistrationsSearchPage
    {
        [When(@"I select No in the options and click submit button")]
        public void WhenISelectNoInTheOptionsAndClickSubmitButton()
        {
            ClickElement(CancelRegNo);
            RegistrationsManualPage.ClickSubmit();
        }
    }
}
