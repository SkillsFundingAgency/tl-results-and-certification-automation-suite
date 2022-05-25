using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2842_UpdateIndustryPlacementPageSteps : UpdateIndustryPlacementpage
    {
        [Then(@"I should see Update Industry placement page")]
        public void ThenIShouldSeeUpdateIndustryPlacementPage()
        {
            VerifyUpdateIPPage();
        }
        
        [Then(@"""(.*)"" radio option is pre selected")]
        public void ThenRadioOptionIsPreSelected(string radioOption)
        {
            VerifyRadioButtonsSelected(radioOption);
        }
        
        [Then(@"clicking on back link navigate back to learner record page")]
        public void ThenClickingOnBackLinkNavigateBackToLearnerRecordPage()
        {
            QueryEnglishAndMathsStatusPage.ClickBackLink();
            LearnerRecordPage_ToBeDeleted.VerifyLearnerRecordPage();
        }

        [Then(@"clicking on update button without changing radio option navigates to learner record page")]
        public void ThenClickingOnUpdateButtonWithoutChangingRadioOptionNavigatesToLearnerRecordPage()
        {
            ClickElement(LearnerRecordPage_ToBeDeleted.ipStatusLink);
            ClickElement(updateBtn);
            LearnerRecordPage_ToBeDeleted.VerifyLearnerRecordPage();
        }
    }
}
