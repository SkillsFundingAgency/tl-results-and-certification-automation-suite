using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class AccountPageForAdminSteps : AccountPage
    {
        [When(@"I click on Account link")]
        public void WhenIClickOnAccountLink()
        {
            ClickAccountLink();
        }
        
        [Then(@"DfE Profile page should open")]
        public void ThenDfEProfilePageShouldOpen()
        {
            VerifyProfilePage();
        }
    }
}
