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
            string RAAURL = SqlQueries.CreateRegistrationAppealURL(uln);
            WebDriver.Navigate().GoToUrl(RAAURL);
        }

        [Then(@"the Review and Appeals Learner Component Grade status page is displayed as per the acceptane criteria")]
        public void ThenTheReviewAndAppealsLearnerComponentGradeStatusPageIsDisplayedAsPerTheAcceptaneCriteria()
        {
            RAULearnersComponentGradesStatusPage.VerifyRAULearnersComponentGradesStatusPage();
           
        }



    }
}
