using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2843_IPStatusUpdatedConfirmationPageSteps : UpdateIPSuccessPage
    {
        private readonly ScenarioContext _scenarioContext;
        public _2843_IPStatusUpdatedConfirmationPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [When(@"I change the radio option to ""(.*)""")]
        public void WhenIChangeTheRadioOptionTo(string radioOption)
        {
            UpdateIndustryPlacementpage.SelectRadioButton(radioOption);
        }
        
        [Then(@"I should see update success page")]
        public void ThenIShouldSeeUpdateSuccessPage()
        {
            VerifyUpdateIPSuccessPage();
            string uln = _scenarioContext["uln"] as string;
            VerifyUpdateIPSuccessData(uln);
        }
        
        [Then(@"Learner record page should display ""(.*)"" when I click on Back to learner record button")]
        public void ThenLearnerRecordPageShouldDisplayWhenIClickOnBackToLearnerRecordButton(string text)
        {
            ClickElement(backToLearnerRecordBtn);
            LearnerRecordPage.VerifyEMOrIPStatus(text);
        }
        [Then(@"clicking on Back to manage learner link should take me to dashboard page")]
        public void ThenClickingOnBackToManageLearnerLinkShouldTakeMeToDashboardPage()
        {
            ClickElement(backToManageLearnerLink);
            LearnerManageLearnerRecordsPage.VerifyManageLearnerRecordsPage();
        }

    }
}
