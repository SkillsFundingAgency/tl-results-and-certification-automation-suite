using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3858_PostResultsServices_RequestAGradeChangeSteps
    {
        private readonly ScenarioContext _scenarioContext;
        public _3858_PostResultsServices_RequestAGradeChangeSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When(@"I search for my UlN through the Reviews option on the dashboard")]
        public void WhenISearchForMyUlNThroughTheReviewsOptionOnTheDashboard()
        {
            string uln = _scenarioContext["uln"] as string;
            TlevelDashboardPage.ClickReviewAndAppealsLinks();
            ReviewAndAppealsStartPage.PressContinueBtn();
            ReviewsAndAppealsSearchLearner.EnterUln(uln);
            ReviewsAndAppealsSearchLearner.ClickSearchBtn();
        }
        
        [When(@"I click on the Contact us link on the '(.*)' page")]
        public void WhenIClickOnTheContactUsLinkOnThePage(string p0)
        {
            RAULearnersComponentGradesStatusPage.ClickContactUsLink();
        }
        
        [Then(@"I am shown the '(.*)' page")]
        public void ThenIAmShownThePage(string p0)
        {
            string uln = _scenarioContext["uln"] as string;
            RAURequestAChangeToThisLearnersGradePage.VerifyRAURequestAChangeToThisLearnersGradePage();
            RAURequestAChangeToThisLearnersGradePage.VerifyLearnerDetails(uln);
        }

        [Then(@"when I press the Back Link on the '(.*)' page")]
        public void ThenWhenIPressTheBackLinkOnThePage(string p0)
        {
            RAURequestAChangeToThisLearnersGradePage.ClickBackLink();
        }

        [When(@"I search for my UlN through the Results option on the dashboard")]
        public void WhenISearchForMyUlNThroughTheResultsOptionOnTheDashboard()
        {
            string uln = _scenarioContext["uln"] as string;
            TlevelDashboardPage.ClickResultsLink();
            ResultsDashboardPage.ClickSearchForALearnerLink();
            ResultsSearchForALearnerPage.EnterULN(uln);
        }

        [Then(@"when I press the Send button without entering any text")]
        public void ThenWhenIPressTheSendButtonWithoutEnteringAnyText()
        {
            RAURequestAChangeToThisLearnersGradePage.ClickSendBtn();
        }

        [Then(@"the following error message is shown on the Request a change to this learner’s grade page '(.*)'")]
        public void ThenTheFollowingErrorMessageIsShownOnTheRequestAChangeToThisLearnerSGradePage(string ErrorMessage)
        {
            RAURequestAChangeToThisLearnersGradePage.VerifyErrorMessage(ErrorMessage);
        }

        [Then(@"the Results Learners Result page is displayed")]
        public void ThenTheResultsLearnersResultPageIsDisplayed()
        {
            ResultsLearnersResultsPage.VerifyLearnerResultPage();
        }

        [Then(@"the orignal grade and a status of ‘Final’ will now be shown on the ‘grade’ row of the core details table on the Learner’s results page")]
        public void ThenTheOrignalGradeAndAStatusOfFinalWillNowBeShownOnTheGradeRowOfTheCoreDetailsTableOnTheLearnerSResultsPage()
        {
            ResultsLearnersResultsPage.VerifyAssessmenSeriesTextFINALState();
        }

        [When(@"I click on the Contact us link on the Results Learners Results page")]
        public void WhenIClickOnTheContactUsLinkOnTheResultsLearnersResultsPage()
        {
            ResultsLearnersResultsPage.ClickContactUsLink();
        }


    }
}
