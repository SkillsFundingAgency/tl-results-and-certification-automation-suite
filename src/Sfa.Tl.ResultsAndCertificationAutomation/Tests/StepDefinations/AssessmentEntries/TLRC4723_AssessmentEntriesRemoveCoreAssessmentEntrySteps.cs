using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class Tlrc4723ManualjourneyassessmententrychangesAddCoreToOpenAssessmentEntrySteps
    {
        [Then(@"I am navigated to the Remove core assessment entry page for (.*)")]
        public void ThenIAmNavigatedToTheRemoveCoreAssessmentEntryPageFor(string uln)
        {
            AssessmentEntriesRemoveCoreAssessmentEntryPage.VerifyRemoveCoreComponentAssessmentEntryPage();
            AssessmentEntriesRemoveCoreAssessmentEntryPage.VerifyLearnerDetails(uln);
            AssessmentEntriesRemoveCoreAssessmentEntryPage.VerifyRadioButtonsNotPrepopulated();
        }

        [Then(@"I click Submit on the Remove Core assessment entry page without selecting a radio button")]
        public void ThenIClickSubmitOnTheRemoveCoreAssessmentEntryPageWithoutSelectingARadioButton()
        {
            AssessmentEntriesRemoveCoreAssessmentEntryPage.PressSubmitButton();
        }

        [Then(@"I am shown an error message on the Remove core assessment entry page")]
        public void ThenIAmShownAnErrorMessageOnTheRemoveCoreAssessmentEntryPage()
        {
            AssessmentEntriesRemoveCoreAssessmentEntryPage.VerifyNoRadioButtonSelectedError();
        }

        [When(@"I click the Back link on the Remove Core assessment entry page without selecting a radio button")]
        public void WhenIClickTheBackLinkOnTheRemoveCoreAssessmentEntryPageWithoutSelectingARadioButton()
        {
            AssessmentEntriesRemoveCoreAssessmentEntryPage.PressBackLink();
        }

        [When(@"I select the No radio button and press Submit on the Remove Core assessment entry page")]
        public void WhenISelectTheNoRadioButtonAndPressSubmitOnTheRemoveCoreAssessmentEntryPage()
        {
            AssessmentEntriesRemoveCoreAssessmentEntryPage.PressNoRadioButton();
        }
    }
}
