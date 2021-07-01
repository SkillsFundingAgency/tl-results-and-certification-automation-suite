using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3476_PostResultsServices_ULN2_LearnerWithdrawnByExamBoardSteps : CrateRegistrationInDb
    {

        private readonly ScenarioContext _scenarioContext;
        public _3476_PostResultsServices_ULN2_LearnerWithdrawnByExamBoardSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [When(@"I search for the ULN created for this test")]
        public void WhenISearchForTheULNCreatedForThisTest()
        {
            var uln = _scenarioContext["uln"] as string;
            ReviewsAndAppealsSearchLearner.EnterUln(uln);
            ReviewsAndAppealsSearchLearner.ClickSearchBtn();

        }
        
        [Then(@"I am shown the Reviews and appeals Learner Withdrawn page")]
        public void ThenIAmShownTheReviewsAndAppealsLearnerWithdrawnPage()
        {
            var uln = _scenarioContext["uln"] as string;
            ReviewAndAppealsLearnerWithdrawnByExamBoardPage.VerifyLearnerWithdrawnByExamBoardPage();
            ReviewAndAppealsLearnerWithdrawnByExamBoardPage.VerifyLearnerDetails(uln);
        }

        [Then(@"when I click the Back link on the Reviews and appeals Learner Withdrawn page")]
        public void ThenWhenIClickTheBackLinkOnTheReviewsAndAppealsLearnerWithdrawnPage()
        {
            ReviewAndAppealsLearnerWithdrawnByExamBoardPage.ClickBackLink();
        }

        [Then(@"when I click the Back to home button on the Reviews and appeals Learner Withdrawn page")]
        public void ThenWhenIClickTheBackToHomeButtonOnTheReviewsAndAppealsLearnerWithdrawnPage()
        {
            ReviewAndAppealsLearnerWithdrawnByExamBoardPage.ClickBackToHomeBtn();
        }

        [Given(@"I have created a registration which is withdrawn, where '(.*)' and '(.*)' with a grade attached")]
        public void GivenIHaveCreatedARegistrationWhichIsWithdrawnWhereAndWithAGradeAttached(string LRSCombination, string IPStatus)
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;

            CreateDbRegistationForLrsCombination(uln, LRSCombination, IPStatus);
            CreateDbRegInWithdrawn(uln);
        }



    }
}
