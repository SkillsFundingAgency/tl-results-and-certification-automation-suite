using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3475_UlnNotFoundSteps : RAUlnNotFoundPage
    {
        private readonly ScenarioContext _scenarioContext;
        public _3475_UlnNotFoundSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I am on reviews and appeals search for learner page")]
        public void GivenIAmOnReviewsAndAppealsSearchForLearnerPage()
        {
            ReviewAndAppealsStartPage.ClickAppealsLink();
            ReviewAndAppealsStartPage.PressContinueBtn();
        }
        
        [When(@"I enter non existed Uln and click Search button")]
        public void WhenIEnterNonExistedUlnAndClickSearchButton()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            ReviewsAndAppealsSearchLearner.EnterUln(uln);
            ReviewsAndAppealsSearchLearner.ClickSearchBtn();
        }
        
        [Then(@"ULN not found page is shown")]
        public void ThenULNNotFoundPageIsShown()
        {
            var uln = _scenarioContext["uln"] as string;
            VerifyUlnNotFoundPage(uln);
        }
        
        [Then(@"click on backlink takes me to search uln page with Uln prepopulated")]
        public void ThenClickOnBacklinkTakesMeToSearchUlnPageWithUlnPrepopulated()
        {
            var uln = _scenarioContext["uln"] as string;
            VerifyBackLink(uln);
        }
        
        [Then(@"search again takes me to search uln page with no Uln prepopulated")]
        public void ThenSearchAgainTakesMeToSearchUlnPageWithNoUlnPrepopulated()
        {
            ReviewsAndAppealsSearchLearner.ClickSearchBtn();
            VerifySearchAgainBtn();
        }
        [Then(@"click on back to home takes me back to home page")]
        public void ThenClickOnBackToHomeTakesMeBackToHomePage()
        {
            ClickbackToHomeBtn();
            Assert.IsTrue(WebDriver.Url.Contains("home"));
            Assert.IsTrue(WebDriver.Title.Contains("Home page – Manage T Level results – GOV.UK"));
        }

    }
}
