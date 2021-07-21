using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3635PostResultsServices_SubmitAppealRequestSuccessBannerSteps : ElementHelper
    {
        private readonly ScenarioContext _scenarioContext;
        public _3635PostResultsServices_SubmitAppealRequestSuccessBannerSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;

        }

        [Then(@"a success banner is shown on the Component Grade status page")]
        public void ThenASuccessBannerIsShownOnTheComponentGradeStatusPage()
        {
            RAULearnersComponentGradesStatusPage.VerifySuccessBannerBeingAppealedDisplayed();
        }
        
        [Then(@"the database will be updated to create a record which shows the grade as being in an appealed state")]
        public void ThenTheDatabaseWillBeUpdatedToCreateARecordWhichShowsTheGradeAsBeingInAnAppealedState()
        {
            string uln = _scenarioContext["uln"] as string;
            RAULearnersComponentGradesStatusPage.VerifyGradeStatusSetToBeingAppealed(uln);
        }

        [When(@"I refresh the Component Grade status page")]
        public void WhenIRefreshTheComponentGradeStatusPage()
        {
            WebDriver.Navigate().Refresh();
        }

        [Then(@"the success banner is not shown on the Component Grade status page")]
        public void ThenTheSuccessBannerIsNotShownOnTheComponentGradeStatusPage()
        {
            RAULearnersComponentGradesStatusPage.VerifySuccessBannerIsNotDisplayed();
        }


    }
}
