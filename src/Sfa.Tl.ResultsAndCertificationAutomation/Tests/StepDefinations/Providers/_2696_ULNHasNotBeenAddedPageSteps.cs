using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2696_ULNHasNotBeenAddedPageSteps : UpdateLearnerSearchPage
    {
        private readonly ScenarioContext _scenarioContext;
        public _2696_ULNHasNotBeenAddedPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [When(@"I enter uln and click search")]
        public void WhenIEnterUlnAndClickSearch()
        {
            string uln = _scenarioContext["uln"] as string;
            Enteruln(uln);
        }
        
        [Then(@"I should see Uln has not been added page")]
        public void ThenIShouldSeeUlnHasNotBeenAddedPage()
        {
            string uln = _scenarioContext["uln"] as string;
            VerifyUlnNotAddedPage(uln);
        }
        
        [Then(@"click on Back link should navigate to search for learner page")]
        public void ThenClickOnBackLinkShouldNavigateToSearchForLearnerPage()
        {
            ClickElement(backLink);
            VerifySearchLearnerPage();
            string uln = _scenarioContext["uln"] as string;
            IsUlnExists(uln);
        }
    }
}
