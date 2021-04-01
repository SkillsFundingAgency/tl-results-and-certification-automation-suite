using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class _2142_CreateAssessmentEntryRemovedSuccessfullyPageSteps : CrateRegistrationInDb
    {
        private readonly ScenarioContext _scenarioContext;
        public _2142_CreateAssessmentEntryRemovedSuccessfullyPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I select Yes radio button and press submit")]
        public void GivenISelectYesRadioButtonAndPressSubmit()
        {
            AssessmentEntriesLearnersRemoveCoreAssessmentEntryPage.PressYesRadioButton();
        }
        [Given(@"I search the learner assessment")]
        public void GivenISearchTheLearnerAssessment()
        {
            var uln = _scenarioContext["uln"] as string;
            AssessmentEntriesPage.SearchAssessmentEntry(uln);
        }
        [Then(@"I am shown assessment entry removed successfully page")]
        public void ThenIAmShownAssessmentEntryRemovedSuccessfullyPage()
        {
            var uln = _scenarioContext["uln"] as string;
            AssessmentEntriesAssessmentRemovedSuccessfullyPage.VerifyRemoveAssessmentEntrySuccessPage(uln);
        }
        
        [Then(@"the core assessment entry displays as ""(.*)"" and link should be ""(.*)"" when i click on back to learner assessment entries button")]
        public void ThenTheCoreAssessmentEntryDisplaysAsAndLinkShouldBeWhenIClickOnBackToLearnerAssessmentEntriesButton(string p0, string p1)
        {
            AssessmentEntriesAssessmentRemovedSuccessfullyPage.ClickBackToAssessmentEntriesButton();
            AssessmentEntriesLearnersAssessmentEntriesPage.VerifyLearnersAssessmentEntriesPage();
            Assert.AreEqual(p0, WebDriver.FindElement(AssessmentEntriesLearnersAssessmentEntriesPage.CoreAssessmentDetails).Text);
            Assert.IsTrue(WebDriver.FindElement(AssessmentEntriesLearnersAssessmentEntriesPage.AddRemoveEntryLink).Text.Contains(p1));
        }

    }
}
