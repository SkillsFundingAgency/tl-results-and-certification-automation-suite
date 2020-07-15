using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualUlnPageSteps : RegistrationsManualPage
    {
        [When(@"I click on Add a new registration link")]
        public void WhenIClickOnAddANewRegistrationLink()
        {
            RegistrationsPage.ClickRegLink();
            AddNewRegistrations();
        }
        
        [Then(@"I should see ULn Page")]
        public void ThenIShouldSeeULnPage()
        {
            VerifyUlnPage();
        }
    }
}
