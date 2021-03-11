using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class AssessmentEntryRemoveCoreAssessmentPageSteps : AssessmentEntriesLearnersAssessmentEntriesPage
    {
        private readonly ScenarioContext _scenarioContext;
        public AssessmentEntryRemoveCoreAssessmentPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I click on Remove entry link")]
        [When(@"I click on Remove entry link")]
        public void WhenIClickOnRemoveEntryLink()
        {
            ClickElement(AddRemoveEntryLink);
        }

        [Given(@"I search for the learner assessment")]
        public void GivenISearchForTheLearnerAssessment()
        {
            var uln = _scenarioContext["uln"] as string;
            AssessmentEntriesPage.SearchAssessmentEntry(uln);
        }


        [Then(@"I am shown the '(.*)' page")]
        public void ThenIAmShownThePage(string p0)
        {
            AssessmentEntriesLearnersRemoveCoreAssessmentEntryPage.VerifyRemoveCoreAssessmentEntryPage();
            AssessmentEntriesLearnersRemoveCoreAssessmentEntryPage.VerifyRadioButtonsNotPrepopulated();
        }
        
        [Then(@"clicking on back link should take me back to Assessment deails page")]
        public void ThenClickingOnBackLinkShouldTakeMeBackToAssessmentDeailsPage()
        {
            AssessmentEntriesLearnersRemoveCoreAssessmentEntryPage.PressBackLink();
            VerifyLearnersAssessmentEntriesPage();
        }
        [Then(@"I am shown an error message '(.*)'")]
        public void ThenIAmShownAnErrorMessage(string p0)
        {
            AssessmentEntriesLearnersRemoveCoreAssessmentEntryPage.VerifyNoRadioButtonSelectedError();
        }
        [Then(@"selecting no option takes me back to Assessment deails page")]
        public void ThenSelectingNoOptionTakesMeBackToAssessmentDeailsPage()
        {
            AssessmentEntriesLearnersRemoveCoreAssessmentEntryPage.PressNoRadioButton();
            VerifyLearnersAssessmentEntriesPage();
        }


    }
}
