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
        [Then(@"I should get access denied with wrong role page")]
        public void ThenIShouldGetAccessDeniedWithWrongRolePage()
        {
            VerifyAccessDeniedWithWrongRolePage();
        }

    }
}
