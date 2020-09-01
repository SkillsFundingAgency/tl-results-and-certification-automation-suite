using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class UserGuidePageSteps : TlevelDashboardPage
    {
        [When(@"I click on User Guide link")]
        public void WhenIClickOnUserGuideLink()
        {
            ClickElement(UserGuideLink);
        }
        
        [Then(@"I should see user guide page")]
        public void ThenIShouldSeeUserGuidePage()
        {
            VerifyUserGuide();
        }
    }
}
