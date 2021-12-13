using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class TLRC_4722MANUALJOURNEYASSESSMENTENTRYCHANGES_AddCoreToOpenAssessmentEntrySteps
    {
        [Then(@"I am shown the Remove specialism assessment entry page for (.*) in ""(.*)""")]
        public void ThenIAmShownTheRemoveSpecialismAssessmentEntryPageForIn(string ULN, string Specialism)
        {
            AssessmentEntriesRemoveSpecialismAssessmentEntryPage.VerifyRemoveSpecialismAssessmentEntryPage(Specialism);
            AssessmentEntriesRemoveSpecialismAssessmentEntryPage.VerifyLearnerDetails(ULN);
            AssessmentEntriesRemoveSpecialismAssessmentEntryPage.VerifyRadioButtonsNotPrepopulated();
        }

        [Then(@"I am shown an error message on the Remove occupational specialism\(s\) assessment entry page")]
        public void ThenIAmShownAnErrorMessageOnTheRemoveOccupationalSpecialismSAssessmentEntryPage()
        {
            AssessmentEntriesRemoveSpecialismAssessmentEntryPage.VerifyNoRadioButtonSelectedError();
        }

        [When(@"I click Submit on the Remove occupational specialism\(s\) assessment entry page without selecting a radio button")]
        public void WhenIClickSubmitOnTheRemoveOccupationalSpecialismSAssessmentEntryPageWithoutSelectingARadioButton()
        {
            AssessmentEntriesRemoveSpecialismAssessmentEntryPage.PressSubmitButton();
        }

        [When(@"I click the Back link on the Remove occupational specialism\(s\) assessment entry page")]
        public void WhenIClickTheBackLinkOnTheRemoveOccupationalSpecialismSAssessmentEntryPage()
        {
            AssessmentEntriesRemoveSpecialismAssessmentEntryPage.PressBackLink();
        }

        [When(@"I select the No radio button and press Submit on the Remove occupational specialism\(s\) assessment entry page")]
        public void WhenISelectTheNoRadioButtonAndPressSubmitOnTheRemoveOccupationalSpecialismSAssessmentEntryPage()
        {
            AssessmentEntriesRemoveSpecialismAssessmentEntryPage.PressNoRadioButton();
        }

        [Then(@"the remove link for the specialism assessment entry is still visible")]
        public void ThenTheRemoveLinkForTheSpecialismAssessmentEntryIsStillVisible()
        {
            AssessmentEntriesLearnersDetailsPage.VerifyAddRemoveSpecialismAssessEntryLinkTextIsDisplayed();
        }

        [Then(@"the specialism assessment entry details are displayed")]
        public void ThenTheSpecialismAssessmentEntryDetailsAreDisplayed()
        {
            AssessmentEntriesLearnersDetailsPage.VerifySpecialismAssessmentEntryDetails();
        }


    }
}
