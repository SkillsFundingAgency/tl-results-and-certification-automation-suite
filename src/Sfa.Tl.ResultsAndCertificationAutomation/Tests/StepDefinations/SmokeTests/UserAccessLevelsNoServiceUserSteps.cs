using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.SmokeTests
{
    [Binding]
    public class UserAccessLevelsNoServiceUserSteps : UserAccessLevels
    {
        [Then(@"I should not get acces to TLevel Services")]
        public void ThenIShouldNotGetAccesToTLevelServices()
        {
            AccessLevelNoService();
        }
    }
}
