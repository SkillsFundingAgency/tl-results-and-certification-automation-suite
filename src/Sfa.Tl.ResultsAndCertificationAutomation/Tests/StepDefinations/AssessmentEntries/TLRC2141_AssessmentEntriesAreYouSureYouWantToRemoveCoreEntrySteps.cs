using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class _2141_CreateAreYouSureYouWantToRemoveThisCoreAssessmentEntryFromSummer2021PageSteps
    {
        [When(@"I click the back link on the Are you sure you want to Core Assessment entry page")]
        public void WhenIClickTheBackLinkOnTheAreYouSureYouWantToCoreAssessmentEntryPage()
        {
            AssessmentEntriesLearnersRemoveCoreAssessmentEntryPage.PressBackLink();
        }
        
        [Then(@"I am shown the Are you sure you want to remove the Core Assessment entry page")]
        public void ThenIAmShownTheAreYouSureYouWantToCoreAssessmentEntryPage()
        {
            AssessmentEntriesLearnersRemoveCoreAssessmentEntryPage.VerifyRemoveCoreAssessmentEntryPage();
            AssessmentEntriesLearnersRemoveCoreAssessmentEntryPage.VerifyRadioButtonsNotPrepopulated();
        }

        [When(@"I click Submit on the Remove Core Assessment page without selecting a radio button")]
        public void WhenIClickSubmitOnTheRemoveCoreAssessmentPageWithoutSelectingARadioButton()
        {
            AssessmentEntriesLearnersRemoveCoreAssessmentEntryPage.PressSubmitButton();
        }

        [Then(@"I am shown an error message for no radio button selected stating '(.*)'")]
        public void ThenIAmShownAnErrorMessageForNoRadioButtonSelectedStating(string p0)
        {
            AssessmentEntriesLearnersRemoveCoreAssessmentEntryPage.VerifyNoRadioButtonSelectedError();
        }

        [When(@"I select the No radio button on the remove assessment entry page and press Submit")]
        public void WhenISelectTheNoRadioButtonOnTheRemoveAssessmentEntryPageAndPressSubmit()
        {
            AssessmentEntriesLearnersRemoveCoreAssessmentEntryPage.PressNoRadioButton();
        }

        [When(@"I select the Yes radio button on the remove assessment entry page and press Submit")]
        public void WhenISelectTheYesRadioButtonOnTheRemoveAssessmentEntryPageAndPressSubmit()
        {
            AssessmentEntriesLearnersRemoveCoreAssessmentEntryPage.PressYesRadioButton();
        }


        [Then(@"I am shown the Assessment Entry Removed Successfully pagefor (.*)")]
        public void ThenIAmShownTheAssessmentEntryRemovedSuccessfullyPagefor(string ULN)
        {
            AssessmentEntriesAssessmentRemovedSuccessfullyPage.VerifyRemoveAssessmentEntrySuccessPage(ULN);
        }

        [When(@"I click the Back to Learner's Assessment Entries button on the Assessment Entry Removed Successfully page")]
        public void WhenIClickTheBackToLearnerSAssessmentEntriesButtonOnTheAssessmentEntryRemovedSuccessfullyPage()
        {
            AssessmentEntriesAssessmentRemovedSuccessfullyPage.ClickBackToAssessmentEntriesButton();
        }


    }
}
