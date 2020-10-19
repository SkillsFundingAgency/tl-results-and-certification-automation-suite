using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1782_ReregisterChangeCoreBackToProviderSteps : ReregisterCheckAndSubmitPage
    {
        [Given(@"I click on reregister Provider change link")]
        public void GivenIClickOnReregisterProviderChangeLink()
        {
            ClickElement(ChangeProvider);
        }
        
        [Given(@"I click on continue in reregister change provider page")]
        public void GivenIClickOnContinueInReregisterChangeProviderPage()
        {
            ClickContinueBtn();
        }
    }
}
