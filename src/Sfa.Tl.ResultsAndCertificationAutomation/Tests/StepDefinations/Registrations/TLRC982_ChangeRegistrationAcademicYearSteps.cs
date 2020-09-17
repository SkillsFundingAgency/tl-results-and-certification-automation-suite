using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC982_ChangeRegistrationAcademicYearSteps : RegistrationsSearchPage
    {
        [When(@"I click on Academic Year change link")]
        public void WhenIClickOnAcademicYearChangeLink()
        {
            ClickElement(AcademicYearChangeLink);
        }
        
        [Then(@"I should see change Academic year page")]
        public void ThenIShouldSeeChangeAcademicYearPage()
        {
            VerifyAcademicYearChangePage();
        }
        
        [Then(@"I should navigated back to Registration details page when i click on Back to regisration details button")]
        public void ThenIShouldNavigatedBackToRegistrationDetailsPageWhenIClickOnBackToRegisrationDetailsButton()
        {
            ClickElement(BackToRegistrationDetailsBtn);
            VerifySearchResultPage();
        }
    }
}
