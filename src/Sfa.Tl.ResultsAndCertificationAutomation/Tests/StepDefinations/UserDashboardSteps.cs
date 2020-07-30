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
                case "SiteAdmin":
                    DfESignInPage.SigninAsSiteAdmin();
                    break;
                case "AllUser":
                    DfESignInPage.SigninAsAllUser();
                    break;
                case "ReviewerAndProvider":
                    DfESignInPage.SigninAsRevProvUser();
                    break;
                case "Reviewer":
                    DfESignInPage.SigninAsReviewer();
                    break;
                case "Provider":
                    DfESignInPage.SigninAsProvider();
                    break;
                case "RegistrationEditor":
                    DfESignInPage.SigninAsRegistrationEditor();
                    break;
                case "PearsonSiteAdmin":
                    DfESignInPage.SigninAsPearsonSiteAdmin();
                    break;
                case "NoRoleNoService":
                    DfESignInPage.SigninAsNoRoleNoServiceUser();
                    break;
                case "NoServiceTole":
                    DfESignInPage.SigninAsNoServiceUser();
                    break;
            }
        }
        
        [Then(@"i should see Account, TLevels and Centre links")]
        public void ThenIShouldSeeAccountTLevelsAndCentreLinks()
        {
            UserDashboardPage.AdminDashboardPage();
        }
        
        [Then(@"I should see Account, Centre links")]
        public void ThenIShouldSeeAccountCentreLinks()
        {
            UserDashboardPage.ProviderDashboardPage();
        }

        [Then(@"i should see Account, TLevels links")]
        public void ThenIShouldSeeAccountTLevelslinks()
        {
            UserDashboardPage.ReviewerDashboardPage();
        }
    }
}
