using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostResults;

[Binding]
public class _5894_AppealWithdrawnCoreStepDefinitions : PostResultsLearnerDetailsPage
{
    [Then(@"appeal withdrawn for core message is shown")]
    public void ThenAppealWithdrawnForCoreMessageIsShown()
    {
        VerifyAppealWithdrawnForCore();
    }
}