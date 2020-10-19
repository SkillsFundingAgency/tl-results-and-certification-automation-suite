using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1784_ReregisterChangeAcademicYearSteps : ReregisterCheckAndSubmitPage
    {
        [When(@"I click on change link in Academic Year page")]
        public void WhenIClickOnChangeLinkInAcademicYearPage()
        {
            ClickButton(ContinueBtn);
        }
    }
}
