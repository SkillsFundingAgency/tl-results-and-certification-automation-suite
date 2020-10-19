using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1620_RegistrationDeletePageValidationsSteps : RegistrationDeletePage
    {
        [When(@"I click submit without selecting any options")]
        public void WhenIClickSubmitWithoutSelectingAnyOptions()
        {
            ClickElement(SubmitBtn);
        }
        
        [Then(@"I should see error on delete registration page")]
        public void ThenIShouldSeeErrorOnDeleteRegistrationPage()
        {
            VerifyDeleteRegCheckErrorPage();
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
