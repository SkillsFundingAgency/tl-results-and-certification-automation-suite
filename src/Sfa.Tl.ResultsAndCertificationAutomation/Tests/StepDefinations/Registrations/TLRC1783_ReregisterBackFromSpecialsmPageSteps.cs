using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1783_ReregisterBackFromSpecialsmPageSteps : ReregisterCheckAndSubmitPage
    {
        [Then(@"I should see reregister check and submit page without specialism")]
        public void ThenIShouldSeeReregisterCheckAndSubmitPageWithoutSpecialism()
        {
            VerifyReregisterCheckAndSubmitPage();
        }
    }
}
