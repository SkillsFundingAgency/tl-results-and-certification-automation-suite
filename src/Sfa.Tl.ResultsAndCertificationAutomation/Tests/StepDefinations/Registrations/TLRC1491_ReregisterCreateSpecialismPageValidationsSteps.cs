using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1491_ReregisterCreateSpecialismPageValidationsSteps : ReregisterCreateSpecialismPage
    {
        [Then(@"I should see validation errors on Reregister specialism page")]
        public void ThenIShouldSeeValidationErrorsOnReregisterSpecialismPage()
        {
            VerifyReregisterSelectSpecialismErrorPage();
        }
    }
}
