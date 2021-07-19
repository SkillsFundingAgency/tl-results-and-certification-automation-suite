using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3743PostResultsServices_CancelButtonOnCheckSubmitSteps
    {

        private readonly ScenarioContext _scenarioContext;
        public _3743PostResultsServices_CancelButtonOnCheckSubmitSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;

        }

        [When(@"I click the Cancel link")]
        public void WhenIClickTheCancelLink()
        {
            RAUCheckAndSubmitPage.ClickCancelBtn();
        }
        
        [When(@"I press the Back link on the Check & submit appeal outcome page")]
        public void WhenIPressTheBackLinkOnTheCheckSubmitAppealOutcomePage()
        {
            RAUCancelAppealUpdatePage.ClickBackLink();
        }
        
        [Then(@"the Cancel appeal update page is shown")]
        public void ThenTheCancelAppealUpdatePageIsShown()
        {
            RAUCancelAppealUpdatePage.VerifyRAUCancelAppealUpdatePage();
            RAUCancelAppealUpdatePage.VerifyRadioButtonsNotPrepopulated();
        }

        [When(@"I press the Continue button without selecting a radio button on the Add outcome of appeal page")]
        public void WhenIPressTheContinueButtonWithoutSelectingARadioButtonOnTheAddOutcomeOfAppealPage()
        {
            RAUCancelAppealUpdatePage.ClickContinueBtn();
        }

        [Then(@"I am shown an error message on the Cancel appeal update page stating '(.*)'")]
        public void ThenIAmShownAnErrorMessageOnTheCancelAppealUpdatePageStating(string ErrorMessage)
        {
            RAUCancelAppealUpdatePage.VerifyErrorMessage(ErrorMessage);
        }

        [When(@"I press the Yes, I want to cancel radio button on the Add outcome of appeal page")]
        public void WhenIPressTheYesIWantToCancelRadioButtonOnTheAddOutcomeOfAppealPage()
        {
            RAUCancelAppealUpdatePage.ClickYesRadioBtn();
            RAUCancelAppealUpdatePage.ClickContinueBtn();
        }

        [When(@"I press the '(.*)' radio button on the Add outcome of appeal page")]
        public void WhenIPressTheRadioButtonOnTheAddOutcomeOfAppealPage(string p0)
        {
            RAUCancelAppealUpdatePage.ClickNoRadioBtn();
            RAUCancelAppealUpdatePage.ClickContinueBtn();
        }

        [Then(@"the Review and Appeals Learner Component Grade status page is displayed with the original grade")]
        public void ThenTheReviewAndAppealsLearnerComponentGradeStatusPageIsDisplayedWithTheOriginalGrade()
        {
            string uln = _scenarioContext["uln"] as string;
            RAULearnersComponentGradesStatusPage.VerifyRAULearnersComponentGradesStatusPage();
            RAULearnersComponentGradesStatusPage.VerifyRAULearnerDetails(uln);
            RAULearnersComponentGradesStatusPage.VerifyUpdateByAndDateValues(uln);       


        }





    }
}
