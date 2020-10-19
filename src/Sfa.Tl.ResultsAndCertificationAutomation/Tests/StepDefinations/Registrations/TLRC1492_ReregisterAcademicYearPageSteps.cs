using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1492_ReregisterAcademicYearPageSteps : ReregisterCreateSpecialismPage
    {
        [Given(@"I select the Specialism in reregister specialism page and click continue")]
        public void GivenISelectTheSpecialismInReregisterSpecialismPageAndClickContinue()
        {
            ClickElement(SelectSpecialism);
            ClickContinueBtn();
        }
        
        [Then(@"I should see Reregister Academic year page")]
        public void ThenIShouldSeeReregisterAcademicYearPage()
        {
            VerifyReregisterAcademicYearPage();
        }
    }
}
