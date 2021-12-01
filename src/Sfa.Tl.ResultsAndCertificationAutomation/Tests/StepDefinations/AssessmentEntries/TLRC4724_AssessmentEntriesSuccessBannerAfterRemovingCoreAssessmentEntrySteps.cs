using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class TLRC_4727MANUALJOURNEYASSESSMENTENTRYCHANGES_SuccessBannerAfterAddingCoreAssessmentEntrySteps
    {
        [Given(@"I add an assessment entry for core")]
        public void GivenIAddAnAssessmentEntryForCore()
        {
            AssessmentEntriesLearnersDetailsPage.PressAddACoreAssessmentSeries();
            AssessmentEntriesAddCoreAssessmentEntryPage.PressYesRadioButton();
        }
        
        [Given(@"I click the Yes, remove the entry radio button and press Submit")]
        public void GivenIClickTheYesRemoveTheEntryRadioButtonAndPressSubmit()
        {
            AssessmentEntriesRemoveCoreAssessmentEntryPage.PressYesRadioButton();
        }


        [Given(@"I click the remove link on the Assessment Details page")]
        public void GivenIClickTheRemoveLinkOnTheAssessmentDetailsPage()
        {
            AssessmentEntriesLearnersDetailsPage.ClickRemoveLink();
        }

    }
}
