using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3853_WithdrawlAppealSteps : RAUAddOutcomeOfAppealPage
    {
        private readonly ScenarioContext _scenarioContext;
        public _3853_WithdrawlAppealSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;

        }
        [When(@"I select withdrawn appeal radio button and click continue")]
        public void WhenISelectWithdrawnAppealRadioButtonAndClickContinue()
        {
            ClickWithdrawnAppealRadioBtn();
            ClickContinueBtn();
        }
        
        [Then(@"I should see appeal withdrawn success message")]
        public void ThenIShouldSeeAppealWithdrawnSuccessMessage()
        {
            VerifyAppealWithdrawnSuccessMgs();
        }
        
        [Then(@"Being appealed tag should not seen on component grade status page")]
        public void ThenBeingAppealedTagShouldNotSeenOnComponentGradeStatusPage()
        {
            RAULearnersComponentGradesStatusPage.VerifyNoBeingAppeal();
        }
    }
}
