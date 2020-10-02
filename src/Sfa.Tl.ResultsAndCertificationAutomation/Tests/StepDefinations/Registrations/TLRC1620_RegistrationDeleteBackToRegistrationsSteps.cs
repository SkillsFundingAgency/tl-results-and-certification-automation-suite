using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1620_RegistrationDeleteBackToRegistrationsSteps: RegistrationDeletePage
    {
        [When(@"I click on Back To Registrations button")]
        public void WhenIClickOnBackToRegistrationsButton()
        {
            ClickElement(BackToRegBtn);
        }

        [Then(@"I should see registrations page")]
        public void ThenIShouldSeeRegistrationsPage()
        {
            RegistrationsPage.VerifyRegistrationDashboardPage();
        }
    }
}
