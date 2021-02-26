using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class TLRC2139_AssessmentEntriesAddNextCoreAssessmentEntrySteps : AssessmentEntriesPage
    {
        [Given(@"I upload a single registration and navigate to the Search for a learner page")]
        public void GivenIUploadASingleRegistrationAndNavigateToTheSearchForALearnerPage()
        {
            SqlQueries.DeleteFromAssessmentTables();
            SqlQueries.DeleteFromRegistrationTables();
            SqlQueries.DeleteFromRegistrationTables();
            RegistrationsPage.ClickRegLink();
            ClickElement(RegistrationsPage.UploadRegistationLink);
            UploadFile(RegistrationsPage.ChooseFile, "1879RegistrationsDataForAssessments.csv");
            ClickElement(RegistrationsPage.SubmitFileBtn);
            RegistrationsPage.VerifyRegistrationSuccessPage();
            ClickElement(TlevelDashboardPage.DashboardHeadLink);
            ClickElement(AssessmentEntriesLink);
        }

        [When(@"I click the Remove entry link")]
        [When(@"I click the Add Entry link")]
        public void WhenIClickTheAddEntryLink()
        {
            AssessmentEntriesLearnersAssessmentEntriesPage.ClickAddEntryLink();
        }

        [Then(@"I am shown the Do you want to add core assessment entry page")]
        public void ThenIAmShownTheDoYouWantToAddCoreAssessmentEntryPage()
        {
            AssessmentEntriesLearnersAddNextCoreAssessmentEntryPage.VerifyAddCoreAssessmentEntriesPage();
            AssessmentEntriesLearnersAddNextCoreAssessmentEntryPage.VerifyRadioButtonsNotPrepopulated();
        }

        [When(@"I click Submit on Add Core Assessment page without selecting a radio button")]
        public void WhenIClickSubmitOnAddCoreAssessmentPageWithoutSelectingARadioButton()
        {
            AssessmentEntriesLearnersAddNextCoreAssessmentEntryPage.PressSubmitButton();
        }

        [Then(@"I am shown an error message stating '(.*)'")]
        public void ThenIAmShownAnErrorMessageStating(string p0)
        {
            AssessmentEntriesLearnersAddNextCoreAssessmentEntryPage.VerifyNoRadioButtonSelectedError();
        }

        [When(@"I select the No radio button and press Submit")]
        public void WhenISelectTheNoRadioButtonAndPressSubmit()
        {
            AssessmentEntriesLearnersAddNextCoreAssessmentEntryPage.PressNoRadioButton();
        }

        [When(@"I click the back link on the Do you want to add core assessment entry page")]
        public void WhenIClickTheBackLinkOnTheDoYouWantToAddCoreAssessmentEntryPage()
        {
            AssessmentEntriesLearnersAddNextCoreAssessmentEntryPage.PressBackLink();
        }


        [Then(@"I am navigated back to the Learner's Assessment Entries page for (.*)")]
        public void ThenIAmNavigatedBackToTheLearnerSAssessmentEntriesPageFor(string ULN)
        {
            AssessmentEntriesLearnersAssessmentEntriesPage.VerifyLearnersAssessmentEntriesPage();
            AssessmentEntriesLearnersAssessmentEntriesPage.VerifyDynamicHeaders(ULN);
            AssessmentEntriesLearnersAssessmentEntriesPage.VerifyNoCoreAssessmentEntryDisplayed();
        }


        [When(@"I click the Yes radio button")]
        public void WhenIClickTheYesRadioButton()
        {
            AssessmentEntriesLearnersAddNextCoreAssessmentEntryPage.PressYesRadioButton();
        }

        [Then(@"I am shown the Assessment Entry Added Successfully page for (.*)")]
        public void ThenIAmShownTheAssessmentEntryAddedSuccessfullyPageFor(string ULN)
        {
            AssessmentEntriesAssessmentAddedSuccessfullyPage.VerifyAddAssessmentEntrySuccessPage(ULN);
        }

        [When(@"I click the Back to Learner's Assessment Entries button")]
        public void WhenIClickTheBackToLearnerSAssessmentEntriesButton()
        {
            AssessmentEntriesAssessmentAddedSuccessfullyPage.ClickBackToAssessmentEntriesButton();
        }
    }
}
