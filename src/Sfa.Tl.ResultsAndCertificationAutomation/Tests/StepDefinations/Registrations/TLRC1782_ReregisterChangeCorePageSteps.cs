using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1782_ReregisterChangeCorePageSteps : ReregisterCheckAndSubmitPage
    {
        [When(@"I click on reregister Core change link")]
        public void WhenIClickOnReregisterCoreChangeLink()
        {
            ClickElement(ChangeCore);
        }
        
        [Then(@"I should see reregister change core page")]
        public void ThenIShouldSeeReregisterChangeCorePage()
        {
            VerifyReregisterCorePage();
        }
        
        [Then(@"previously selected core value is prepopulated")]
        public void ThenPreviouslySelectedCoreValueIsPrepopulated()
        {

        }
    }
}
