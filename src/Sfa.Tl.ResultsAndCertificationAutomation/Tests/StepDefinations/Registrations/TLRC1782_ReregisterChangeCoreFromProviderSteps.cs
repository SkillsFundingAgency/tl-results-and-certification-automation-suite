using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1782_ReregisterChangeCoreFromProviderSteps : ReregisterCheckAndSubmitPage
    {
        [When(@"I click on continue in without changing reregister change provider")]
        public void WhenIClickOnContinueInWithoutChangingReregisterChangeProvider()
        {
            ClickContinueBtn();
        }
    }
}
