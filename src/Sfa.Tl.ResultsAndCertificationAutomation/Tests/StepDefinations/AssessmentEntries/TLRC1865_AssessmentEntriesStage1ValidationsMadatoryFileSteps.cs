using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class TLRC1865_AssessmentEntriesStage1ValidationsMadatoryFileSteps : AssessmentEntriesPage
    {
        [Then(@"I am shown the Assessment entries upload page")]
        [Given(@"I am on Assessment entries upload page")]
        public void GivenIAmOnAssessmentEntriesUploadPage()
        {
            ClickElement(AssessmentEntriesLink);
            ClickElement(UploadAssessmentEntryLink);
            VerifyAssessmentEntriesUploadPage();
        }

        [Given(@"I click on ""(.*)"" button")]
        [When(@"I click on ""(.*)"" button")]
        public void WhenIClickOnButton(string label)
        {
            CommonPage.ClickButtonByLabel(label);
        }
        
        [Then(@"I should see following error message")]
        public void ThenIShouldSeeFollowingErrorMessage(Table table)
        {
            VerifyAssessmentEntriesUploadErrorPage();
            CommonPage.VerifyValidationMessage(table);
        }
        
        [Then(@"I should see the following error summary message")]
        public void ThenIShouldSeeTheFollowingErrorSummaryMessage(Table table)
        {
            CommonPage.VerifyValidationSummaryMessages(table);
        }

        [When(@"I navigate to the Search for a learner page")]
        [Given(@"I navigate to the Search for a learner page")]
        public void GivenINavigateToTheSearchForALearnerPage()
        {
            ClickElement(AssessmentEntriesLink);
            ClickElement(SearchForLearnerLink);
        }

        [Given(@"I navigate back to the Search for a learner page")]
        public void GivenINavigateBackToTheSearchForALearnerPage()
        {
            ClickElement(SearchForLearnerLink);
        }
    }
}
