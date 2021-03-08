using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class _2136_CannotDeleteRegistrationWithResultSteps : CrateRegistrationInDb
    {
        private readonly ScenarioContext _scenarioContext;
        public _2136_CannotDeleteRegistrationWithResultSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I select Delete this registration permanently")]
        public void GivenISelectDeleteThisRegistrationPermanently()
        {
            ClickElement(RegistrationDeletePage.DeleteRadioBtn);
        }
        
        [Then(@"I should see ""(.*)"" page")]
        public void ThenIShouldSeePage(string p0)
        {
            RegistrationDeletePage.VerifyCannotDeleteRegistrationWithResultPage();
        }
        
        [Then(@"Back link should take me to active registration options page")]
        public void ThenBackLinkShouldTakeMeToActiveRegistrationOptionsPage()
        {
            RegistrationDeletePage.ClickBackLink();
            RegistrationDeletePage.VerifyAmendActiveRegPage();
        }
        
        [Then(@"clicking on ""(.*)"" button should take me to registration details page")]
        public void ThenClickingOnButtonShouldTakeMeToRegistrationDetailsPage(string p0)
        {
            CommonPage.ClickButtonByLabel("Continue");
            ClickButton(RegistrationsSearchPage.BackToRegistrationDetailsBtn);
            RegistrationsSearchPage.VerifySearchResultPage();
            string uln = _scenarioContext["uln"] as string;
            RegistrationsSearchPage.VerifyRegistrationDetailsPageULNSubHeading(uln);
            DeleteRegistrationFromTables(uln);
        }
    }
}
