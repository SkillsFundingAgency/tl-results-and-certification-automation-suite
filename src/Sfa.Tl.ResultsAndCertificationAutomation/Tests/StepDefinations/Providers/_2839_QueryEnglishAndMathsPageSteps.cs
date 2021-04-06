using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2839_QueryEnglishAndMathsPageSteps : QueryEnglishAndMathsStatusPage
    {
        private readonly ScenarioContext _scenarioContext;
        public _2839_QueryEnglishAndMathsPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I am on Learner record page")]
        public void GivenIAmOnLearnerRecordPage()
        {
            var uln = _scenarioContext["uln"] as string;
            LearnerRecordPage.NavigateToLearnerRecordPage(uln);
        }

        [When(@"I click on ""(.*)"" link in Learner record page")]
        public void WhenIClickOnLinkInLearnerRecordPage(string text)
        {
            LearnerRecordPage.Clicklink(text);
        }


        [Then(@"I should see Query English and Maths status page")]
        public void ThenIShouldSeeQueryEnglishAndMathsStatusPage()
        {
            VerifyQueryEnglishAndMathsStatusPage();
        }
        
        [Then(@"clicking on back to learner record button navigates to learner record page")]
        public void ThenClickingOnBackToLearnerRecordButtonNavigatesToLearnerRecordPage()
        {
            ClickBackToLearnerBtn();
            LearnerRecordPage.VerifyLearnerRecordPage();
        }
        
        [Then(@"clicking on back link navigates to learner record page")]
        public void ThenClickingOnBackLinkNavigatesToLearnerRecordPage()
        {
            LearnerRecordPage.Clicklink("Query");
            ClickBackLink();
            LearnerRecordPage.VerifyLearnerRecordPage();
        }
    }
}
