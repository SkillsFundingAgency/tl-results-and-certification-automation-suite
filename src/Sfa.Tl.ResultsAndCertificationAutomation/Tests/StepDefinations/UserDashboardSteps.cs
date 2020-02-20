using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Hooks;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class UserDashboardSteps : Hooks
    {
        [Given(@"I have logged in as a ""(.*)"" user")]
        public void GivenIHaveLoggedInAsAUser(string p0)
        {
            switch(p0)
            {
                case "AOApprover":
                    DfESignInPage.SigninAsAOApprover();
                    break;
                case "AOProvider":
                    DfESignInPage.SigninAsAOCentre();
                    break;
                case "Standard":
                    DfESignInPage.SigninAsStandardUser();
                    break;
            }
        }
        
        [Then(@"i should see Account, TLevels and Centre links")]
        public void ThenIShouldSeeAccountTLevelsAndCentreLinks()
        {
            UserDashboardPage.AOAppDashboardPage();
        }
        
        [Then(@"I should see Account, Centre links")]
        public void ThenIShouldSeeAccountCentreLinks()
        {
            UserDashboardPage.AOCentreDashboardPage();
        }
        
        [Then(@"I should see Account link")]
        public void ThenIShouldSeeAccountLink()
        {
            UserDashboardPage.NoUserDashboardPage();
        }
    }
}
