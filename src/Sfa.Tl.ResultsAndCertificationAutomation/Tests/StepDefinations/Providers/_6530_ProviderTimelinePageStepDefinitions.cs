using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers;

[Binding]
public class _6530_ProviderTimelinePageStepDefinitions : ProviderTimelinePage
{
    [Then(@"provider timeline page is shown")]
    public void ThenProviderTimelinePageIsShown()
    {
        VerifyProviderTimelinePage();
    }
}