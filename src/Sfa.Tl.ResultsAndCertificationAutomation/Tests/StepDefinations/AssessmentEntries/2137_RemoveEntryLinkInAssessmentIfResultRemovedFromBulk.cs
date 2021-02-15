using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class RemoveEntryLinkInAssessmentIfResultRemovedFromBulk : AssessmentEntriesPage
    {
        [Given(@"I updated the result with Not received for the Uln")]
        public void GivenIUpdatedTheResultWithNotReceivedForTheUln(Table table)
        {
            var row = table.Rows;
            var uln = row[0]["Uln"];
            ResultsDashboardPage.ClickResultsLink();
            ResultsDashboardPage.searchResult(uln);
            ClickElement(ResultsDashboardPage.changeResult);
            ClickElement(ResultsDashboardPage.notreceivedGrade);
            ClickButton(ResultsDashboardPage.changeBtn);
            ResultsDashboardPage.VerifyResultChangeSuccessPage();
        }


        [Then(@"I should see Remove Entry link for the learner in assessment details page")]
        public void ThenIShouldSeeRemoveEntryLinkForTheLearnerInAssessmentDetailsPage()
        {
            Assert.IsTrue(IsPresent(AddOrRemoveAssessmentEntry));
            SqlQueries.DeleteFromRegistrationTables();
        }

    }
}
