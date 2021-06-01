using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.StatementOfAchievement
{
    [Binding]
    public class _3107_LearnerNotRegisteredSteps : UlnNotRegisteredPage
    {
        private readonly ScenarioContext _scenarioContext;
        public _3107_LearnerNotRegisteredSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I am on Search for learner page")]
        public void GivenIAmOnSearchForLearnerPage()
        {
            NavigateSearchForLearnerPage();
        }
        [When(@"I enter non existed Uln and click on Search button")]
        public void WhenIEnterNonExistedUlnAndClickOnSearchButton()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            RequestSOA_SearchForALearnerPage.EnterULN(uln);
        }

        [Then(@"I should see Learner not registered page")]
        public void ThenIShouldSeeLearnerNotRegisteredPage()
        {
            var uln = _scenarioContext["uln"] as string;
            VerifyUlnNotRegisteredPage(uln);
        }
        
        [Then(@"Back link should take me back to search learner page")]
        public void ThenBackLinkShouldTakeMeBackToSearchLearnerPage()
        {
            var uln = _scenarioContext["uln"] as string;
            VerifyBackLink(uln);
        }
        
        [Then(@"back to home should take me to dashboard page")]
        public void ThenBackToHomeShouldTakeMeToDashboardPage()
        {
            RequestSOA_SearchForALearnerPage.ClickSearch();
            VerifyBackToHome();
        }
    }
}
