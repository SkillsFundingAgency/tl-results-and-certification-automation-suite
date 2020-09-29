using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1481_ChangeSpecialismAddSpecialismSteps : RegistrationsSearchPage
    {
        [When(@"I select the specialism and click continue button")]
        public void WhenISelectTheSpecialismAndClickContinueButton()
        {
            ClickElement(RegistrationsManualPage.SelectSpecialismLegal);
            ClickButton(ChangeBtn);
            VerifyChangeSuccessPage();
            ClickButton(BackToRegistrationDetailsBtn);
        }
        
        [Then(@"I should see selected specialism in the registration details page")]
        public void ThenIShouldSeeSelectedSpecialismInTheRegistrationDetailsPage()
        {
            VerifySearchResultPage();
            VerifySpecialism("Legal (50000001)");
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
