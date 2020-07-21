using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.SmokeTests
{
    [Binding]
    public class UserAccessLevelsProviderSteps : UserAccessLevels
    {
        [Then(@"I should get access to Provider and Account pages only")]
        public void ThenIShouldGetAccessToProviderAndAccountPagesOnly()
        {
            AccessLevelProvidersEditor();
        }
    }
}
