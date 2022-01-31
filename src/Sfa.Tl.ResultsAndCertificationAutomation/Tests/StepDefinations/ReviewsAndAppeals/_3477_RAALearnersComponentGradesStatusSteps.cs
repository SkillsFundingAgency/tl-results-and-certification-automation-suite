using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3477_RAALearnersComponentGradesStatusSteps : ReviewAndAppealsStartPage
    {
        private readonly ScenarioContext _scenarioContext;
        public _3477_RAALearnersComponentGradesStatusSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I navigate to the Review and Appeals Learner Component Grade status page using the URL")]
        public void GivenINavigateToTheReviewAndAppealsLearnerComponentGradeStatusPageUsingTheURL()
        {
            string uln = _scenarioContext["uln"] as string;
            PressContinueBtn();
            ReviewsAndAppealsSearchLearner.EnterUln(uln);
            ReviewsAndAppealsSearchLearner.ClickSearchBtn();
            //string RAAURL = SqlQueries.CreateRegistrationAppealURL(uln);
            //WebDriver.Navigate().GoToUrl(RAAURL);
        }

        [Then(@"the Review and Appeals Learner Component Grade status page is displayed as per the acceptance criteria")]
        public void ThenTheReviewAndAppealsLearnerComponentGradeStatusPageIsDisplayedAsPerTheAcceptanceCriteria()
        {
            string uln = _scenarioContext["uln"] as string;
            RAULearnersComponentGradesStatusPage.VerifyRAULearnersComponentGradesStatusPage();
            RAULearnersComponentGradesStatusPage.VerifyRAULearnerDetails(uln);
            RAULearnersComponentGradesStatusPage.VerifyCoreDetailsOnInitialEntry();
        }

        [Then(@"when I press the Search again button on the Core Component Grade Status page")]
        public void ThenWhenIPressTheSearchAgainButtonOnTheCoreComponentGradeStatusPage()
        {
            RAULearnersComponentGradesStatusPage.ClickSearchAgainBtn();
        }

        [Then(@"the Review and Appeals Search page is displayed")]
        public void ThenTheReviewAndAppealsSearchPageIsDisplayed()
        {
            ReviewsAndAppealsSearchLearner.VerifySearchLearnerPage();
        }

        [When(@"I press the Search for a learner breadcrumb on the Review and Appeals Learner Component Grade status page")]
        public void WhenIPressTheSearchForALearnerBreadcrumbOnTheReviewAndAppealsLearnerComponentGradeStatusPage()
        {
            RAULearnersComponentGradesStatusPage.ClickSearchForALearnerBreadcrumb();
        }

        [When(@"I press the Reviews and Appeals breadcrumb on the Review and Appeals Learner Component Grade status page")]
        public void WhenIPressTheReviewsAndAppealsBreadcrumbOnTheReviewAndAppealsLearnerComponentGradeStatusPage()
        {
            string uln = _scenarioContext["uln"] as string;
            string RAAURL = SqlQueries.CreateRegistrationAppealUrl(uln);
            WebDriver.Navigate().GoToUrl(RAAURL);
            RAULearnersComponentGradesStatusPage.ClickReviewsAndAppealsBreadcrumb();
        }

        [Then(@"the Reviews and Appeals start page is displayed")]
        public void ThenTheReviewsAndAppealsStartPageIsDisplayed()
        {
            ReviewAndAppealsStartPage.VerifyReviewAndAppealsStartPage();
        }

        [When(@"I press the Home breadcrumb on the Review and Appeals Learner Component Grade status page")]
        public void WhenIPressTheHomeBreadcrumbOnTheReviewAndAppealsLearnerComponentGradeStatusPage()
        {
            string uln = _scenarioContext["uln"] as string;
            string RAAURL = SqlQueries.CreateRegistrationAppealUrl(uln);
            WebDriver.Navigate().GoToUrl(RAAURL);
            RAULearnersComponentGradesStatusPage.ClickHomeBreadcrumb();
        }



    }
}
