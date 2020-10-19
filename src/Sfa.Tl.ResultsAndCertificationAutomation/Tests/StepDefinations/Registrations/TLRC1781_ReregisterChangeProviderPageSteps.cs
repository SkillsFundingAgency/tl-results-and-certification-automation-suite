using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1781_ReregisterChangeProviderPageSteps : ReregisterCheckAndSubmitPage
    {
        [When(@"I click on reregister Provider change link")]
        public void WhenIClickOnReregisterProviderChangeLink()
        {
            ClickElement(ChangeProvider);
        }

        [Then(@"I should see reregister change provider page")]
        public void ThenIShouldSeeReregisterChangeProviderPage()
        {
            RegistrationReactivate.VerifyReactivateWithAnotherProviderPage();
        }
        
        [Then(@"provider dropdown should be prepopulated with previous value")]
        public void ThenProviderDropdownShouldBePrepopulatedWithPreviousValue()
        {
            VerifyChangeProviderValue();
        }
    }
}
