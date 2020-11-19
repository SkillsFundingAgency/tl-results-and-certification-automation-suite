using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;


namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class _2035_CreateProblemWithAssessmentEntriesUploadPageSteps : AssessmentEntriesProblemWithUploadPage
    {
        [Given(@"I navigate to the Problem with assessment entry page")]
        public void GivenINavigateToTheProblemWithAssessmentEntryPage()
        {
            NavigateToAssessmentEntriesUploadProblemPage();
        }

        [Then(@"I am navigated to the Assessment Entries Problem with Upload page")]
        public void ThenIAmNavigatedToTheAssessmentEntriesProblemWithUploadPage()
        {
            VerifyAssesmenEntryUploadProblemPage();
        }

        [Given(@"I click the Start again button")]
        public void GivenIClickTheStartAgainButton()
        {
            PressStartAgainButton();
        }

        [Given(@"I click the Back to assessment entries button")]
        public void GivenIClickTheBackToAssessmentEntriesButton()
        {
            PressBackToAssessmentEntriesButtonButton();
        }

        [Then(@"I am navigated to the Upload assessment entries file page")]
        public void ThenIAmNavigatedToTheUploadAssessmentEntriesFilePage()
        {
            AssessmentEntriesPage.VerifyAssessmentEntriesUploadPage();
        }

       


    }
}
