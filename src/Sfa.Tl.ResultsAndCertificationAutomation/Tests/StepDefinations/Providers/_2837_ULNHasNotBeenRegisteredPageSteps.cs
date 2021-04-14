using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2837_ULNHasNotBeenRegisteredPageSteps : UpdateLearnerSearchPage
    {
        private readonly ScenarioContext _scenarioContext;
        public _2837_ULNHasNotBeenRegisteredPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        
        [Then(@"I shoud see Uln has not been registrered page")]
        public void ThenIShoudSeeUlnHasNotBeenRegistreredPage()
        {
            string uln = _scenarioContext["uln"] as string;
            UlnNotRegisteredPage(uln);
        }
        
        [Then(@"clicking on Back link should show search learner page")]
        public void ThenClickingOnBackLinkShouldShowSearchLearnerPage()
        {
            ClickElement(backLink);
            VerifySearchLearnerPage();
            string uln = _scenarioContext["uln"] as string;
            IsUlnExists(uln);
        }
        
        [Then(@"clicking on Back to search button should show search learner page")]
        public void ThenClickingOnBackToSearchButtonShouldShowSearchLearnerPage()
        {
            ClickSearchBtn();
            ClickBackToSearchBtn();
            VerifySearchLearnerPage();
            string uln = _scenarioContext["uln"] as string;
            IsUlnExists(uln);
        }
        
        [Then(@"clicking ""(.*)"" should navigate to learner dashboard page")]
        public void ThenClickingShouldNavigateToLearnerDashboardPage(string linkText)
        {
            ClickSearchBtn();
            ClickLinkByLabel(linkText);
            LearnerManageLearnerRecordsPage.VerifyManageLearnerRecordsPage();
        }
    }
}
