using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1481_ChangeSpecialismUpdateSteps: RegistrationsSearchPage
    {
        [When(@"I click on coninue button in learner decide specialism page")]
        public void WhenIClickOnConinueButtonInLearnerDecideSpecialismPage()
        {
            ClickButton(ContinueBtn);
        }
        
        [When(@"I select different specialism and click change button")]
        public void WhenISelectDifferentSpecialismAndClickChangeButton()
        {
            ClickElement(RegistrationsManualPage.SelectSpecialismLegal);
            ClickElement(RegistrationsManualPage.SelectSpecialismFinancial);
            ClickButton(ChangeBtn);
        }
        
        [Then(@"I should see newly added specialism on the registration details page")]
        public void ThenIShouldSeeNewlyAddedSpecialismOnTheRegistrationDetailsPage()
        {
            ClickButton(BackToRegistrationDetailsBtn);
            VerifySearchResultPage();
            VerifySpecialism("Financial (50000002)");
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
