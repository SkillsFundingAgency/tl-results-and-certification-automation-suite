using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _6527_ProviderGuidancePageStepDefinitions : ProviderGuidancePage
    {
        [Then(@"provider guidance page is shown")]
        public void ThenProviderGuidancePageIsShown()
        {
            VerifyProviderGuidancePage();
        }
    }
}
