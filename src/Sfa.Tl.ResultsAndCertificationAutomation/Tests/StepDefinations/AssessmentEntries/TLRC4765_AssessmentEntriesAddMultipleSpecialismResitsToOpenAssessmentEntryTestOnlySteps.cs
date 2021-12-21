using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class TLRC_4765MANUALJOURNEYASSESSMENTENTRYCHANGES_AddMultipleSpecialismResitsToOpenAssessmentEntryTestOnlySteps
    {
        [When(@"I click the Add specialism assessment series link")]
        public void WhenIClickTheAddSpecialismAssessmentSeriesLink()
        {
            AssessmentEntriesLearnersDetailsPage.PressAddSpecialismAssessmentSeriesForCouplet();
        }

        [Then(@"I am navigated to the Add specialism assessment entry page multiple specialism for (.*) (.*)")]
        public void ThenIAmNavigatedToTheAddSpecialismAssessmentEntryPageMultipleSpecialismFor(string ULN, string Specialisms)
        {
            AssessmentEntriesAddSpecialismAssessmentEntryPage.VerifyAddSpecialismAssessmentEntryPage(Specialisms);
            AssessmentEntriesAddSpecialismAssessmentEntryPage.VerifyLearnerDetails(ULN);
            AssessmentEntriesAddSpecialismAssessmentEntryPage.VerifyRadioButtonsNotPrepopulated();
        }

        [Then(@"I am navigated to the Add specialism assessment entry page multiple specialisms for (.*) in ""(.*)""")]
        public void ThenIAmNavigatedToTheAddSpecialismAssessmentEntryPageMultipleSpecialismsForIn(string ULN, string Specialisms)
        {
            AssessmentEntriesAddSpecialismAssessmentEntryPage.VerifyAddSpecialismAssessmentEntryPage(Specialisms);
            AssessmentEntriesAddSpecialismAssessmentEntryPage.VerifyLearnerDetails(ULN);
            AssessmentEntriesAddSpecialismAssessmentEntryPage.VerifyRadioButtonsNotPrepopulated();
        }




        [When(@"I click Submit on the Add specialism assessment entry page without selecting a radio button")]
        public void WhenIClickSubmitOnTheAddSpecialismAssessmentEntryPageWithoutSelectingARadioButton()
        {
            AssessmentEntriesAddSpecialismAssessmentEntryPage.PressSubmitButton();
        }

        [Then(@"I am shown an error message on the Add specialism assessment entry page")]
        public void ThenIAmShownAnErrorMessageOnTheAddSpecialismAssessmentEntryPage()
        {
            AssessmentEntriesAddSpecialismAssessmentEntryPage.VerifyNoRadioButtonSelectedError();
        }

        [When(@"I click the Back link on the Add specialism assessment entry page without selecting a radio button")]
        public void WhenIClickTheBackLinkOnTheAddSpecialismAssessmentEntryPageWithoutSelectingARadioButton()
        {
            AssessmentEntriesAddSpecialismAssessmentEntryPage.PressBackLink();
        }

        [When(@"I select the No radio button and press Submit on the Add specialism assessment entry page")]
        public void WhenISelectTheNoRadioButtonAndPressSubmitOnTheAddSpecialismAssessmentEntryPage()
        {
            AssessmentEntriesAddSpecialismAssessmentEntryPage.PressNoRadioButton();
        }
    }
}
