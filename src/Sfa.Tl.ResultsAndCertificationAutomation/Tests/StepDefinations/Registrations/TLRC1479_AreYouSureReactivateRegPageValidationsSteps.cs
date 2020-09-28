using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1479_AreYouSureReactivateRegPageValidationsSteps : RegistrationReactivate
    {
        [When(@"I click Submit button without selecting options")]
        public void WhenIClickSubmitButtonWithoutSelectingOptions()
        {
            ClickElement(SubmitBtn);
        }

        [Then(@"I should see validation error in Are you sure reactivate page")]
        public void ThenIShouldSeeValidationErrorInAreYouSureReactivatePage()
        {
            VerifyAreYouSureReactivateErrorPage();
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
