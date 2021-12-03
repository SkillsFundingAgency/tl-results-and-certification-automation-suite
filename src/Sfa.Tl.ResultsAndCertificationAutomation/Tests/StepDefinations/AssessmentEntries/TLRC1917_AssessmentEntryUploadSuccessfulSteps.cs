using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class TLRC1917_AssessmentEntryUploadSuccessfulSteps : AssessmentEntriesPage
    {
        [Then(@"I should see Upload success page")]
        public void ThenIShouldSeeUploadSuccessPage()
        {
            VerifyAssessmentUploadSuccessPage();
            SqlQueries.DeleteFromRegistrationTables();
        }

        [When(@"I click the Upload another file button")]
        public void WhenIClickTheUploadAnotherFileButton()
        {
            ClickUploadAnotherFileBtn();
        }

        [When(@"I click the Back to home button")]
        public void WhenIClickTheBackToHomeButton()
        {
            ClickBacktoHomeBtn();
        }

        [When(@"I click the manage individual assessments link")]
        public void WhenIClickTheManageIndividualAssessmentsLink()
        {
            ClickManageIndividualAssessmentsLink();
        }

        [When(@"I click the upload another multiple assessments file link")]
        public void WhenIClickTheUploadAnotherMultipleAssessmentsFileLink()
        {
            ClickUploadAnotherFileLink();
        }

        [When(@"I click the add results link")]
        public void WhenIClickTheAddResultsLink()
        {
            ClickAddResultsLink();
        }

        [When(@"I navigate to the Assesment Search for a learner page")]
        public void WhenINavigateToTheAssesmentSearchForALearnerPage()
        {
            ClickBacktoHomeBtn();
            AssessmentEntriesPage.ClickElement(AssessmentEntriesLink);
            AssessmentEntriesPage.ClickElement(SearchForLearnerLink);
        }

    }
}
