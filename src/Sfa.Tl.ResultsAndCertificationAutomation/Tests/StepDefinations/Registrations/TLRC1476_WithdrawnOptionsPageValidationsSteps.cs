using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1476_WithdrawnOptionsPageValidationsSteps : RegistrationReactivate
    {
        [When(@"I click continue without selecting withdrawn options")]
        public void WhenIClickContinueWithoutSelectingWithdrawnOptions()
        {
            ClickElement(ContinueBtn);
        }
        
        [Then(@"I should see errors in withdrawn options page")]
        public void ThenIShouldSeeErrorsInWithdrawnOptionsPage()
        {
            VerifyWithdrawnOptionsErrorPage();
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
