using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3727_MultipleAssessmentEntriesSteps : CrateRegistrationInDb
    {
        private readonly ScenarioContext _scenarioContext;
        public _3727_MultipleAssessmentEntriesSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [Given(@"I have a registration with a result and two assessment entries")]
        public void GivenIHaveARegistrationWithAResultAndTwoAssessmentEntries()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            CreateDbRegWithResultAndTwoAssessmentEntries(uln);
        }

        [Then(@"the Select exam period page is displayed")]
        public void ThenTheSelectExamPeriodPageIsDisplayed()
        {
            string uln = _scenarioContext["uln"] as string;
            RAUSelectExamPeriodPage.VerifyRAUSelectExamPeriodPage();
            RAUSelectExamPeriodPage.VerifyRAULearnerDetails(uln);
            RAUSelectExamPeriodPage.VerifyExamPeriodDetails();
            RAUSelectExamPeriodPage.VerifyRadioButtonsNotPrepopulated();
        }

        [When(@"I press the back link on the Select assessment entry page")]
        public void WhenIPressTheBackLinkOnTheSelectAssessmentEntryPage()
        {
            RAUSelectExamPeriodPage.ClickBackLink();
        }

        [Then(@"the Review and appeals Search for a learner page is displayed")]
        public void ThenTheReviewAndAppealsSearchForALearnerPageIsDisplayed()
        {
            ReviewsAndAppealsSearchLearner.VerifySearchLearnerPage();
        }

        [Then(@"the following error message is displayed on the Select exam period page ""(.*)""")]
        public void ThenTheFollowingErrorMessageIsDisplayedOnTheSelectExamPeriodPage(string ErrorMessage)
        {
            RAUSelectExamPeriodPage.VerifyErrorMessage(ErrorMessage);
        }

        [When(@"I press the Submit button on the Select assessment entry page")]
        public void WhenIPressTheSubmitButtonOnTheSelectAssessmentEntryPage()
        {
            RAUSelectExamPeriodPage.ClickSubmitBtn();
        }

        [When(@"I select an assessment series which has a grade against it")]
        public void WhenISelectAnAssessmentSeriesWhichHasAGradeAgainstIt()
        {
            RAUSelectExamPeriodPage.ClickSummer2021RadioBtn();
            RAUSelectExamPeriodPage.ClickSubmitBtn();
        }

        [When(@"I select an assessment series which has not got a grade against it")]
        public void WhenISelectAnAssessmentSeriesWhichHasNotGotAGradeAgainstIt()
        {
            RAUSelectExamPeriodPage.ClickAutumn2021RadioBtn();
            RAUSelectExamPeriodPage.ClickSubmitBtn();
        }

        [Then(@"the no grades to appeal page will reflect the assessment series selected on the radio button")]
        public void ThenTheNoGradesToAppealPageWillReflectTheAssessmentSeriesSelectedOnTheRadioButton()
        {
            NoRegisteredGradesPage.VerifyNoRegisteredGradesPageforAutumn2021();
        }


    }
}
