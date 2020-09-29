using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1479_AreYouSureReactivateRegNoOptionSteps : RegistrationReactivate
    {
        [When(@"I select No do not reactivate radio button and click submit button")]
        public void WhenISelectNoDoNotReactivateRadioButtonAndClickSubmitButton()
        {
            ClickElement(ReactivateConfirmNo);
            ClickElement(SubmitBtn);
        }
    }
}
