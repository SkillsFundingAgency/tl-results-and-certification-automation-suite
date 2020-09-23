using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1481_ChangeSpecialismErrorValidationsSteps : RegistrationsSearchPage
    {
        [When(@"I click on change button without selecting the specialism")]
        public void WhenIClickOnChangeButtonWithoutSelectingTheSpecialism()
        {
            ClickButton(ChangeBtn);
        }
        
        [Then(@"I should see Select specialism error message")]
        public void ThenIShouldSeeSelectSpecialismErrorMessage()
        {
            VerifyChangeSpecialismErrorPage();
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
