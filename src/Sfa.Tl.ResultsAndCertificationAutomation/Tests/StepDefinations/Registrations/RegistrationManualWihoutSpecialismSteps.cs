using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualWihoutSpecialismSteps : RegistrationsManualPage
    {
        [When(@"I select No from has decided specialism and click Continue")]
        public void WhenISelectNoFromHasDecidedSpecialismAndClickContinue()
        {
            ClickElement(DecideNo);
            ClickContiune();
        }
    }
}
