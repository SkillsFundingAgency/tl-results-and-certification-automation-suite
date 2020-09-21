using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1540_ChangeProviderAndCorePageSteps : RegistrationsSearchPage
    {
        [When(@"I changed Provider with different Core and click Change button")]
        public void WhenIChangedProviderWithDifferentCoreAndClickChangeButton()
        {
            RegistrationsManualPage.SelectProviderFromList(ChangeProvider4);
            ClickButton(ChangeBtn);
        }
        
        [Then(@"I should see Do you want to change Core page")]
        public void ThenIShouldSeeDoYouWantToChangeCorePage()
        {
            VerifyDoYouWantChangeCorePage();
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
