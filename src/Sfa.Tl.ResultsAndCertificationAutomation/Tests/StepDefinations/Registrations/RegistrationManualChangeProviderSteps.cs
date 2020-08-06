using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualChangeProviderSteps : RegistrationsManualPage
    {
        [When(@"I click on Provider change link")]
        public void WhenIClickOnProviderChangeLink()
        {
            ClickChangePoviderLink();
        }
        
        [When(@"I changed the Provider and click continue")]
        public void WhenIChangedTheProviderAndClickContinue()
        {
            VerifyProviderPage();
            SelectProviderFromList("Automation Test2 (99999902)");
            ClickContiune();
        }
        
        [When(@"I change Core and Specialisms and click continue")]
        public void WhenIChangeCoreAndSpecialismsAndClickContinue()
        {
            VerifyCorePage();
            ClickContiune();
            VerifySpecialismDecidePage();
            ClickElement(DecideNo);
            ClickContiune();
            VerifyAcademicYearPage();
            ClickContiune();
        }
        
        [Then(@"I should changed Provider details in Check and Submit page")]
        public void ThenIShouldChangedProviderDetailsInCheckAndSubmitPage()
        {
            VerifyRegistrationSummaryPage();
        }
    }
}
