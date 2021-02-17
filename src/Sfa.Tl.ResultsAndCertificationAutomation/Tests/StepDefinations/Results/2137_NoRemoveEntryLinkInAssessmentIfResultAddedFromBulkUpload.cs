using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class NoRemoveEntryLinkInAssessmentIfResultAddedFromBulkUpload : ResultsDashboardPage
    {
        private readonly ScenarioContext _scenarioContext;
        public NoRemoveEntryLinkInAssessmentIfResultAddedFromBulkUpload(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I removed the result by selecting Not received")]
        public void GivenIRemovedTheResultBySelectingNotReceived(Table table)
        {
            var row = table.Rows;
            var uln = row[0]["Uln"];
            ClickResultsLink();
            searchResult(uln);
            ClickElement(changeResult);
            ClickElement(notreceivedGrade);
            ClickButton(changeBtn);
            VerifyResultChangeSuccessPage();
        }
        [Given(@"I removed the result for the uln by selecting not received")]
        public void GivenIRemovedTheResultForTheUlnBySelectingNotReceived()
        {
            var uln = _scenarioContext["uln"] as string;
            ClickResultsLink();
            searchResult(uln);
            ClickElement(changeResult);
            ClickElement(notreceivedGrade);
            ClickButton(changeBtn);
            VerifyResultChangeSuccessPage();
        }


        [When(@"I search Assessment entry for the Uln")]
        public void WhenISearchAssessmentEntryForTheUln(Table table)
        {
            var row = table.Rows;
            var uln = row[0]["Uln"];
            AssessmentEntriesPage.SearchAssessmentEntry(uln);
        }
        
        [When(@"I search learner in Assessment entry")]
        public void WhenISearchLearnerInAssessmentEntry()
        {
            var uln = _scenarioContext["uln"] as string;
            AssessmentEntriesPage.SearchAssessmentEntry(uln);
        }
        
        [Then(@"Remove Entry link should exists in the assessment details page")]
        public void ThenRemoveEntryLinkShouldExistsInTheAssessmentDetailsPage()
        {
            Assert.IsTrue(IsPresent(AssessmentEntriesPage.AddOrRemoveAssessmentEntry));
        }

        [Then(@"Remove Entry link should not exists in the assessment details page")]
        public void ThenRemoveEntryLinkShouldNotExistsInTheAssessmentDetailsPage()
        {
            Assert.IsFalse(IsPresent(AssessmentEntriesPage.AddOrRemoveAssessmentEntry));
        }
    }
}
