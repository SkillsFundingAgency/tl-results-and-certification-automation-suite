﻿using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Results;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class _3823_LearnerWithdrawnPageSteps : LearnerWithdrawnPage
    {
        private readonly ScenarioContext _scenarioContext;
        public _3823_LearnerWithdrawnPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Then(@"I should see learner withdrawn page")]
        public void ThenIShouldSeeLearnerWithdrawnPage()
        {
            VerifyLearnerWithdrawnPage();
        }

        [Then(@"Back link should take me to search learner page with Uln")]
        public void ThenBackLinkShouldTakeMeToSearchLearnerPageWithUln()
        {
            var uln = _scenarioContext["uln"] as string;
            VerifyBackLink(uln);
        }

        [Then(@"Search again shoud take me to search learner page without Uln")]
        public void ThenSearchAgainShoudTakeMeToSearchLearnerPageWithoutUln()
        {
            ClickSearchBtn();
            VerifySearchAgain();
        }
        [Then(@"click on back to home should takes me to dashboard page")]
        public void ThenClickOnBackToHomeShouldTakesMeToDashboardPage()
        {
            VerifyBackToHome();
        }

        [Then(@"I should see the Learner has been withdrawn page")]
        public void ThenIShouldSeeTheLearnerHasBeenWithdrawnPage()
        {
            var uln = _scenarioContext["uln"] as string;
            AssessmentEntriesWithdrawnPage.VerifyAssessmentLearnerWithdrawnPage();
            AssessmentEntriesWithdrawnPage.VerifyDynamicHeaders(uln);
        }

        [When(@"I press the Back to home button on the learner withdrawn page")]
        public void WhenIPressTheBackToHomeButtonOnTheLearnerWithdrawnPage()
        
        {
            var uln = _scenarioContext["uln"] as string;
            AssessmentEntriesSearchForLearnerPage.EnterULN(uln);
            AssessmentEntriesWithdrawnPage.PressBackToHomeBtn();
        }

    }
}
