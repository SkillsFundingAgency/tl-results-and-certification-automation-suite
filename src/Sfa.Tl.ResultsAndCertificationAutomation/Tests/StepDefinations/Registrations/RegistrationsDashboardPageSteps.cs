using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationsDashboardPageSteps : RegistrationsPage
    {
        [When(@"I click on Registrations link on Home page")]
        public void WhenIClickOnRegistrationsLinkOnHomePage()
        {
            ClickRegLink();
        }
        
        [Then(@"Registration page should open")]
        public void ThenRegistrationPageShouldOpen()
        {
            VerifyRegistrationDashboardPage();
        }
    }
}
