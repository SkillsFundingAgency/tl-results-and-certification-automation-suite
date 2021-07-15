using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3480PostResultsServices_ComponentGradeStatusUpdatedSteps
    {

        private readonly ScenarioContext _scenarioContext;
        public _3480PostResultsServices_ComponentGradeStatusUpdatedSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;

        }

        [Given(@"I select the '(.*)' radio button")]
        public void GivenISelectTheRadioButton(string p0)
        {
            RAUAppealGradePage.ClickYesRadioBtn();
            RAUAppealGradePage.ClickSubmitBtn();
        }
        
        [Then(@"'(.*)' will now appear as the status on the ‘Grade’ row within the core details table")]
        public void ThenWillNowAppearAsTheStatusOnTheGradeRowWithinTheCoreDetailsTable(string p0)
        {
            string uln = _scenarioContext["uln"] as string;
            RAULearnersComponentGradesStatusPage.VerifyCoreDetailsStatusBeingAppealed(uln);
            
        }

        [Then(@"the Review and Appeals Learner Component Grade status page is displayed")]
        public void ThenTheReviewAndAppealsLearnerComponentGradeStatusPageIsDisplayed()
        {
            string uln = _scenarioContext["uln"] as string;          
            RAULearnersComponentGradesStatusPage.VerifyRAULearnersComponentGradesStatusPage();
            RAULearnersComponentGradesStatusPage.VerifyRAULearnerDetails(uln);
        }

    }
}
