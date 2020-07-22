using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.SmokeTests
{
    [Binding]
    public class UserAccessLevelsReviewerSteps : UserAccessLevels
    {
        [Then(@"I should get acces to TLevels and Accounts pages only")]
        public void ThenIShouldGetAccesToTLevelsAndAccountsPagesOnly()
        {
            AccessLevelTLevelReviewer();
        }
    }
}
