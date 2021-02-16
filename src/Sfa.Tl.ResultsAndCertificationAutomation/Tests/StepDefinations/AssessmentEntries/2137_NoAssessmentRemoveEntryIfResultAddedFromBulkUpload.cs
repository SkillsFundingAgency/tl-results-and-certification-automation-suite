using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class NoAssessmentRemoveEntryIfResultAddedFromBulkUpload : ResultsDashboardPage
    {
        [When(@"I search search Assessment entry for the Uln")]
        public void WhenISeachSearchAssessmentEntryForTheUln(Table table)
        {
            var row = table.Rows;
            var uln = row[0]["Uln"];
            AssessmentEntriesPage.SearchAssessmentEntry(uln);
        }
        
        [Then(@"I should not see Remove Entry link in the assessment details page")]
        public void ThenIShouldNotSeeRemoveEntryLinkInTheAssessmentDetailsPage()
        {
            Assert.IsFalse(IsPresent(AssessmentEntriesPage.AddOrRemoveAssessmentEntry));
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
