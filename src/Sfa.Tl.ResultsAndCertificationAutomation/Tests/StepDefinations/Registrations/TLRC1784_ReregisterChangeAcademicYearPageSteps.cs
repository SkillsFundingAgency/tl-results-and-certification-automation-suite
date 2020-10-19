using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1784_ReregisterChangeAcademicYearPageSteps : ReregisterCheckAndSubmitPage
    {
        [When(@"I click reregister academicyear change link")]
        public void WhenIClickReregisterAcademicyearChangeLink()
        {
            ClickElement(ChangeAcademicYear);
        }
    }
}
