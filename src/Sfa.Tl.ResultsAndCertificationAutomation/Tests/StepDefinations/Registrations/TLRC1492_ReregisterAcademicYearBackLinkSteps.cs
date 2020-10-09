using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1492_ReregisterAcademicYearBackLinkSteps : ReregisterCreateSpecialismPage
    {
        [Then(@"I should be navigated back to reregister select specalism page")]
        public void ThenIShouldBeNavigatedBackToReregisterSelectSpecalismPage()
        {
            VerifyReregisterSelectSpecialismPage();
        }
    }
}
