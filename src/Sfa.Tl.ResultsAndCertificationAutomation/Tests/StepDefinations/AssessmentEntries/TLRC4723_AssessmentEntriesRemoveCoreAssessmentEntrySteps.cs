using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class TLRC_4723MANUALJOURNEYASSESSMENTENTRYCHANGES_AddCoreToOpenAssessmentEntrySteps
    {
        [Then(@"I am navigated to the Remove core assessment entry page for (.*)")]
        public void ThenIAmNavigatedToTheRemoveCoreAssessmentEntryPageFor(string ULN)
        {
            AssessmentEntriesRemoveCoreAssessmentEntryPage.VerifyRemoveCoreComponentAssessmentEntryPage();
            AssessmentEntriesRemoveCoreAssessmentEntryPage.VerifyLearnerDetails(ULN);
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
