using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Registrations;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class _3742_BlockWithdrawLearnerSteps : CrateRegistrationInDb
    {
        private readonly ScenarioContext _scenarioContext;
        public _3742_BlockWithdrawLearnerSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I have a registration in Appealed state")]
        public void GivenIHaveARegistrationInAppealedState()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            CreateRegWithAppealState(uln);
        }
        
        [Given(@"I am on registration details page")]
        public void GivenIAmOnRegistrationDetailsPage()
        {
            var uln = _scenarioContext["uln"] as string;
            RegistrationsPage.ClickRegLink();
            ClickElement(RegistrationsSearchPage.SearchRegistrationLink);
            EnterText(RegistrationsSearchPage.SearchBox, uln);
            ClickElement(RegistrationsSearchPage.SearchBtn);
        }
        
        [Given(@"click on change status link")]
        public void GivenClickOnChangeStatusLink()
        {
            ClickElement(RegistrationReactivate.ChangeStatusLink);
        }
        
        [When(@"I select withdraw registration and click continue")]
        public void WhenISelectWithdrawRegistrationAndClickContinue()
        {
            ClickElement(RegistrationReactivate.ReactivateRegistration);
            ClickElement(RegistrationReactivate.ContinueBtn);
        }
        
        [Then(@"I should see you cannot withdraw registration page")]
        public void ThenIShouldSeeYouCannotWithdrawRegistrationPage()
        {
            CannotWithdrawRegistrationPage.VerifyCannotWithdrawPage();
        }
        
        [Then(@"Back link should takes to withdraw registration option page")]
        public void ThenBackLinkShouldTakesToWithdrawRegistrationOptionPage()
        {
            CannotWithdrawRegistrationPage.CheckBackLink();
        }
        
        [Then(@"back to registration button takes to registration details page")]
        public void ThenBackToRegistrationButtonTakesToRegistrationDetailsPage()
        {
            ClickElement(RegistrationReactivate.ContinueBtn);
            CannotWithdrawRegistrationPage.CheckBackToRegDetails();
        }
        
        [Then(@"back to home button takes to dashboard page")]
        public void ThenBackToHomeButtonTakesToDashboardPage()
        {
            ClickElement(RegistrationReactivate.ChangeStatusLink);
            ClickElement(RegistrationReactivate.ReactivateRegistration);
            ClickElement(RegistrationReactivate.ContinueBtn);
            CannotWithdrawRegistrationPage.CheckBackToHome();
        }
    }
}
