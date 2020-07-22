using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.SmokeTests
{
    [Binding]
    public class UserAccessLevelsNoRoleUserSteps : UserAccessLevels
    {
        [Then(@"I should see Access Denied error for all pages")]
        public void ThenIShouldSeeAccessDeniedErrorForAllPages()
        {
            AccessLevelNoRoles();
        }
    }
}
