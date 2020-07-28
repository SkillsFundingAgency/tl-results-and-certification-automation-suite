using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualLearnersPageSteps : RegistrationsManualPage
    {
        [When(@"I enter (.*) and click Continue button")]
        public void WhenIEnterAndClickContinueButton(string p0)
        {
            EnterUln(p0);
            ClickContiune();
        }
        
        [Then(@"I should see Learners Page")]
        public void ThenIShouldSeeLearnersPage()
        {
            VerifyLearnersPage();
        }
    }
}
