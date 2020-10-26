using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC981_ChangeProviderSelectNewProviderSteps: RegistrationsSearchPage
    {
        private static readonly string ChangeProvider = "Automation Test3 (99999903)";
        [When(@"I change another provider has same core from the list")]
        public void WhenIChangeAnotherProviderHasSameCoreFromTheList()
        {
            RegistrationsManualPage.SelectProviderFromList(ChangeProvider);
        }
        
        [When(@"I click on Change button")]
        public void WhenIClickOnChangeButton()
        {
            ClickButton(ChangeBtn);
        }
        
        [Then(@"I should see Change successfull message")]
        public void ThenIShouldSeeChangeSuccessfullMessage()
        {
            RegistrationChangeSuccessPage.VerifyRegistrationChangeSuccessPage();
            //VerifyChangeSuccessPage();
        }
        
        [Then(@"I should see new provider details in registration details page")]
        public void ThenIShouldSeeNewProviderDetailsInRegistrationDetailsPage()
        {
            ClickButton(BackToRegistrationDetailsBtn);
            VerifySearchResultPage();
            VerifyProvider(ChangeProvider);
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
