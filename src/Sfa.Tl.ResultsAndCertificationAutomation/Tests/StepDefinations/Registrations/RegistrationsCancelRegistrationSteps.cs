using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationsCancelRegistrationSteps : RegistrationsSearchPage
    {
        [Given(@"I enter (.*) and click on Search")]
        public void GivenIEnterAndClickOnSearch(string p0)
        {
            EnterText(SearchBox, p0);
            ClickElement(SearchBtn);
        }
        
        [Given(@"I click on Cancel Register button")]
        public void GivenIClickOnCancelRegisterButton()
        {
            ClickCancelRegistration();
            VerifyConfirmRegCancelPage();
            YesToCancelReg();
        }
        
        [Then(@"I should see cancel registration success page")]
        public void ThenIShouldSeeCancelRegistrationSuccessPage()
        {
            VerifyRegCancelSuccessPage();
        }
    }
}
