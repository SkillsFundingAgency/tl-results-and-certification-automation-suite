using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualLearnersPageSteps : RegistrationsManualPage
    {
        [When(@"I entered valid Uln and Click on Continue button")]
        public void WhenIEnteredValidUlnAndClickOnContinueButton()
        {
            EnterUln();
            ClickContiune();
        }
        
        [Then(@"I should see Learners page")]
        public void ThenIShouldSeeLearnersPage()
        {
            VerifyLearnersPage();
        }
    }
}
