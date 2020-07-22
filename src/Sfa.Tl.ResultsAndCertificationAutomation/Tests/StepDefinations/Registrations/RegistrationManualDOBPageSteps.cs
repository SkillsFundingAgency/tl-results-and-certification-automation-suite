using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualDOBPageSteps : RegistrationsManualPage
    {
        [When(@"I enter (.*) (.*) in learners page and click Contiune")]
        public void WhenIEnterInLearnersPageAndClickContiune(string p0, string p1)
        {
            EnterLearnerName(p0, p1);
            ClickContiune();
        }
        
        [Then(@"I should see Date of Birth Page")]
        public void ThenIShouldSeeDateOfBirthPage()
        {
            VerifyDobPage();
        }
    }
}
