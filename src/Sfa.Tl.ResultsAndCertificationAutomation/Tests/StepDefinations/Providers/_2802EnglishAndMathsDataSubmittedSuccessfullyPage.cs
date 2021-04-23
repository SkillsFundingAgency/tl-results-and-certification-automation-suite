using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2802HasLearnerAchievedEnglishMathsSENDSteps
    {

        private readonly ScenarioContext _scenarioContext;
        public _2802HasLearnerAchievedEnglishMathsSENDSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When(@"I click Submit on the Min standard for EM Page")]
        [Given(@"I click Submit on the Min standard for EM Page")]
        public void GivenIClickSubmitOnTheMinStandardForEMPage()
        {

            HasLearnersAchievedEMSendPage.ClickSubmitButton();
        }

       
        [Then(@"I am navigated to the English and maths data submitted successfully page")]
        public void ThenIAmNavigatedToTheEnglishAndMathsDataSubmittedSuccessfullyPage()
        {
            var uln = _scenarioContext["uln"] as string;
            EMDataSubmittedSuccessPage.VerifyEMDataSubmittedSuccessPage(uln);
        }

        [Then(@"I am navigated to the Learner Enter the Unique Learner Number page")]
        public void ThenIAmNavigatedToTheLearnerEnterTheUniqueLearnerNumberPage()
        {
            Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.CommonUlnDbSteps.VerifyAddANewLearnerRecordPage();

        }

        [When(@"I click the Add another learner T Level record button")]
        public void WhenIClickTheAddAnotherLearnerTLevelRecordButton()
        {
            EMDataSubmittedSuccessPage.ClickAddAnotherLearnerButton();
        }

        [When(@"I click the Back to manage learner T Level records button")]
        public void WhenIClickTheBackToManageLearnerTLevelRecordsButton()
        {
            EMDataSubmittedSuccessPage.ClickBackToLEarnerRecordsLink();
        }

        [Then(@"I am navigated to the Manage learner records page")]
        public void ThenIAmNavigatedToTheManageLearnerRecordsPage()
        {
            LearnerManageLearnerRecordsPage.VerifyManageLearnerRecordsPage();
        }



    }
}
