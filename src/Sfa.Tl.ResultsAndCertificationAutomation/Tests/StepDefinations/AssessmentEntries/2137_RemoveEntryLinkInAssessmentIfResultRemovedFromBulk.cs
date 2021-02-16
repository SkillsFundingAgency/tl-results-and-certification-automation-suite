using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class RemoveEntryLinkInAssessmentIfResultRemovedFromBulk : ResultsDashboardPage
    {
        [Given(@"I updated the result with Not received for the Uln")]
        public void GivenIUpdatedTheResultWithNotReceivedForTheUln(Table table)
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


        [Then(@"I should see Remove Entry link for the learner in assessment details page")]
        public void ThenIShouldSeeRemoveEntryLinkForTheLearnerInAssessmentDetailsPage()
        {
            Assert.IsTrue(IsPresent(AssessmentEntriesPage.AddOrRemoveAssessmentEntry));
            SqlQueries.DeleteFromRegistrationTables();
        }

    }
}
