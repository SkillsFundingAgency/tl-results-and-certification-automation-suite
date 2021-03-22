using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2800_LearnerCancelPageSteps : CancelSubmitPage
    {
        [Then(@"I should see Learner cancel page")]
        public void ThenIShouldSeeLearnerCancelPage()
        {
            VerifyCancelPage();
        }
        [Then(@"Yes, cancel radio button should be pre seleceted")]
        public void ThenYesCancelRadioButtonShouldBePreSeleceted()
        {
            VerifyCanelRadioOption();
        }
        [Then(@"I should see Provider dashboard page when I click Continue button")]
        public void ThenIShouldSeeProviderDashboardPageWhenIClickContinueButton()
        {
            LearnerAchievedMinStandardForEnglishAndMathsPage.ClickContinue();
            LearnerManageLearnerRecordsPage.VerifyManageLearnerRecordsPage();
        }
        [When(@"I select do not cancel option and click continue")]
        public void WhenISelectDoNotCancelOptionAndClickContinue()
        {
            ClickElement(cancelNoRadio);
            LearnerAchievedMinStandardForEnglishAndMathsPage.ClickContinue();
        }


    }
}
