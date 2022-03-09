using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostResults
{
    [Binding]
    public class _5744_PostResultsUlnNotFoundStepDefinitions : SearchForLearnerPage
    {
        private readonly ScenarioContext _scenarioContext;
        public _5744_PostResultsUlnNotFoundStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I am on post results search learner page")]
        public void GivenIAmOnPostResultsSearchLearnerPage()
        {
            TlevelDashboardPage.ClickReviewAndAppealsLinks();
            PressContinueBtn();
        }

        [When(@"I enter the uln which is not existed and click search button")]
        public void WhenIEnterTheUlnWhichIsNotExistedAndClickSearchButton()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            EnterUln(uln);
            ClickSearchBtn();
        }

        [Then(@"post result Uln not found page is shown")]
        public void ThenPostResultUlnNotFoundPageIsShown()
        {
            var uln = _scenarioContext["uln"] as string;
            VerifyUlnNotFoundPage(uln);
        }

        [Then(@"click on back link takes to search uln page witn Uln populated")]
        public void ThenClickOnBackLinkTakesToSearchUlnPageWitnUlnPopulated()
        {
            var uln = _scenarioContext["uln"] as string;
            VerifyBackLink(uln);
        }

        [Then(@"search again takes to search uln page with no uln populated")]
        public void ThenSearchAgainTakesToSearchUlnPageWithNoUlnPopulated()
        {
            ClickSearchBtn();
            VerifySearchAgainBtn();
        }
    }
}
