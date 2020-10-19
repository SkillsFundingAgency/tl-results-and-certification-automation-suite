using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1620_RegistrationDeleteCancelSteps : RegistrationDeletePage
    {
        [When(@"I click do not delete option and click submit button")]
        public void WhenIClickDoNotDeleteOptionAndClickSubmitButton()
        {
            ClickElement(DeleteNoRadio);
            ClickElement(SubmitBtn);
        }
    }
}
