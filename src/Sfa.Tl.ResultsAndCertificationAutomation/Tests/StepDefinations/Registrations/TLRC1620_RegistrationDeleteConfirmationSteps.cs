using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1620_RegistrationDeleteConfirmationSteps : RegistrationDeletePage
    {
        [When(@"I select Yes delete registration option and click submit")]
        public void WhenISelectYesDeleteRegistrationOptionAndClickSubmit()
        {
            ClickElement(DeleteYesRadio);
            ClickElement(SubmitBtn);
        }
        
        [Then(@"I should see delete congirmation page")]
        public void ThenIShouldSeeDeleteCongirmationPage()
        {
            VerifyDeleteConfirmationPage();
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
