using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class TLRC4720AssessmentEntries_AddCoreToOpenAssessmentEntrySteps
    {

        [Then(@"I am navigated to the Add core assessment entry page for (.*)")]
        public void ThenIAmNavigatedToTheAddCoreAssessmentEntryPageFor(string ULN)
        {
            AssessmentEntriesAddCoreAssessmentEntryPage.VerifyAddCoreComponentAssessmentEntryPage();
            AssessmentEntriesAddCoreAssessmentEntryPage.VerifyLearnerDetails(ULN);
            AssessmentEntriesAddCoreAssessmentEntryPage.VerifyRadioButtonsNotPrepopulated();
        }

        [When(@"I click Submit on the Add Core assessment entry page without selecting a radio button")]
        public void WhenIClickSubmitOnTheAddCoreAssessmentEntryPageWithoutSelectingARadioButton()
        {
            AssessmentEntriesAddCoreAssessmentEntryPage.PressSubmitButton();
        }

        [Then(@"I am shown an error message on the Add core assessment entry page")]
        public void ThenIAmShownAnErrorMessageOnTheAddCoreAssessmentEntryPage()
        {
            AssessmentEntriesAddCoreAssessmentEntryPage.VerifyNoRadioButtonSelectedError();
        }

        [When(@"I click the Back link on the Add Core assessment entry page without selecting a radio button")]
        public void WhenIClickTheBackLinkOnTheAddCoreAssessmentEntryPageWithoutSelectingARadioButton()
        {
            AssessmentEntriesAddCoreAssessmentEntryPage.PressBackLink();
        }

        [When(@"I select the No radio button and press Submit on the Add Core assessment entry page")]
        public void WhenISelectTheNoRadioButtonAndPressSubmitOnTheAddCoreAssessmentEntryPage()
        {
            AssessmentEntriesAddCoreAssessmentEntryPage.PressNoRadioButton();
        }

        [When(@"I select the Yes radio button and press Submit on the Add Core assessment entry page")]
        public void WhenISelectTheYesRadioButtonAndPressSubmitOnTheAddCoreAssessmentEntryPage()
        {
            AssessmentEntriesAddCoreAssessmentEntryPage.PressYesRadioButton();
        }



    }
}
