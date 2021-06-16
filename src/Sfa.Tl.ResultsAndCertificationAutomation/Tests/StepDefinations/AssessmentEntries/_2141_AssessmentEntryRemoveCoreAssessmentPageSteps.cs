using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class _2141_AssessmentEntryRemoveCoreAssessmentPageSteps : AssessmentEntriesLearnersRemoveCoreAssessmentEntryPage
    {
        private readonly ScenarioContext _scenarioContext;
        public _2141_AssessmentEntryRemoveCoreAssessmentPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I am on Learner assessment entries page")]
        public void GivenIAmOnLearnerAssessmentEntriesPage()
        {
            var uln = _scenarioContext["uln"] as string;
            AssessmentEntriesPage.SearchAssessmentEntry(uln);
        }
        
        [Then(@"I am shown the Are you sure you want to remove the Core Assessment entry page")]
        public void ThenIAmShownTheAreYouSureYouWantToRemoveTheCoreAssessmentEntryPage()
        {
            VerifyRemoveCoreAssessmentEntryPage();
            VerifyRadioButtonsNotPrepopulated();
        }
        
        [Then(@"click on back link should take me to learner assessment entries page")]
        public void ThenClickOnBackLinkShouldTakeMeToLearnerAssessmentEntriesPage()
        {
            PressBackLink();
            AssessmentEntriesLearnersAssessmentEntriesPage.VerifyLearnersAssessmentEntriesPage();
        }
        [Given(@"I click on remove entry link")]
        public void GivenIClickOnRemoveEntryLink()
        {
            AssessmentEntriesLearnersAssessmentEntriesPage.ClickAddEntryLink();
        }

        [Then(@"I am shown an error message '(.*)'")]
        public void ThenIAmShownAnErrorMessage(string p0)
        {
            VerifyRemoveCoreAssessmentEntryErrorPage();
        }

        [Then(@"selecting no option takes me back to Assessment deails page")]
        public void ThenSelectingNoOptionTakesMeBackToAssessmentDeailsPage()
        {
            PressNoRadioButton();
            AssessmentEntriesLearnersAssessmentEntriesPage.VerifyLearnersAssessmentEntriesPage();
        }
    }
}
