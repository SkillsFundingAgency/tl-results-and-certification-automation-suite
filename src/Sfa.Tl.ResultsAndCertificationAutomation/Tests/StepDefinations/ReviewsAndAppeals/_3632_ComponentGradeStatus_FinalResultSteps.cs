using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3632PostResultsServices_ComponentGradeStatus_FinalResultSteps
    {

        private readonly ScenarioContext _scenarioContext;
        public _3632PostResultsServices_ComponentGradeStatus_FinalResultSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When(@"I select Submit on the Appeals Check and submit page")]
        public void WhenISelectSubmitOnTheAppealsCheckAndSubmitPage()
        {
            RAUCheckAndSubmitPage.ClickSubmitBtn();
        }
        
        [Then(@"I am shown the component grade status page")]
        public void ThenIAmShownTheComponentGradeStatusPage()
        {
            string uln = _scenarioContext["uln"] as string;
            RAULearnersComponentGradesStatusPage.VerifyRAULearnersComponentGradesStatusPage();
            RAULearnersComponentGradesStatusPage.VerifyRAULearnerDetails(uln);
            
        }

        [Then(@"there will be a success banner showing the grade is Final")]
        public void ThenThereWillBeASuccessBannerShowingTheGradeIsFinal()
        {
            RAULearnersComponentGradesStatusPage.VerifySuccessBannerFINALStatusDisplayed();
        }


        [Then(@"the orignal grade and a status of ‘Final’ will now be shown on the ‘grade’ row of the core details table")]
        public void ThenTheOrignalGradeAndAStatusOfFinalWillNowBeShownOnTheGradeRowOfTheCoreDetailsTable()
        {
            string uln = _scenarioContext["uln"] as string;
            RAULearnersComponentGradesStatusPage.VerifyCoreDetailsStatusFinal(uln, Constants.RAAOriginalGrade);
        }

        [Then(@"the new grade '(.*)' and a status of ‘Final’ will now be shown on the ‘grade’ row of the core details table")]
        public void ThenTheNewGradeAndAStatusOfFinalWillNowBeShownOnTheGradeRowOfTheCoreDetailsTable(string Grade)
        {
            string uln = _scenarioContext["uln"] as string;
            RAULearnersComponentGradesStatusPage.VerifyCoreDetailsStatusFinal(uln, Grade);
        }

        [Then(@"the result on the database is set to final")]
        public void ThenTheResultOnTheDatabaseIsSetToFinal()
        {
            string uln = _scenarioContext["uln"] as string;
            RAULearnersComponentGradesStatusPage.VerifyGradeStatusSetToFinal(uln);
        }

        [When(@"I press the Search again button on the Review and Appeals Learner Component Grade status page")]
        public void WhenIPressTheSearchAgainButtonOnTheReviewAndAppealsLearnerComponentGradeStatusPage()
        {
            TlevelDashboardPage.ClickReviewAndAppealsLinks();
            string uln = _scenarioContext["uln"] as string;
            ReviewAndAppealsStartPage.PressContinueBtn();
            ReviewsAndAppealsSearchLearner.EnterUln(uln);
            ReviewsAndAppealsSearchLearner.ClickSearchBtn();
            RAULearnersComponentGradesStatusPage.ClickSearchAgainBtn();
        }





    }
}
