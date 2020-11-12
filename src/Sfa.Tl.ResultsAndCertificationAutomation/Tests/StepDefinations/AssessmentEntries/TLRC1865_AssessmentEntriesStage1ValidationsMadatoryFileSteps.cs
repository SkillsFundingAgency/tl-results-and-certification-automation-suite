using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class TLRC1865_AssessmentEntriesStage1ValidationsMadatoryFileSteps : AssessmentEntriesPage
    {
        [Given(@"I am on Assessment entries upload page")]
        public void GivenIAmOnAssessmentEntriesUploadPage()
        {
            ClickElement(AssessmentEntriesLink);
            ClickElement(UploadAssessmentEntryLink);
            VerifyAssessmentEntriesUploadPage();
        }
        
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
    }
}
