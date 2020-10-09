using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1493_ReregisterCheckAndSubmitPageSteps : ReregisterCheckAndSubmitPage
    {
        [When(@"I click on continue button in Academic year page")]
        public void WhenIClickOnContinueButtonInAcademicYearPage()
        {
            ClickContinueBtn();
        }
        
        [Then(@"I should see reregister check and submit page")]
        public void ThenIShouldSeeReregisterCheckAndSubmitPage()
        {
            VerifyReregisterCheckAndSubmitPage();
            VerifyReregisterData();
            VerifyReregisterChangeLinks();
        }
    }
}
