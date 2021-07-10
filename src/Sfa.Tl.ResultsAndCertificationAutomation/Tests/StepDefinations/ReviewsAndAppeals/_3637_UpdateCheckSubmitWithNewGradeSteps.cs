using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3637_UpdateCheckSubmitWithNewGradeSteps
    {

        private readonly ScenarioContext _scenarioContext;
        public _3637_UpdateCheckSubmitWithNewGradeSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;

        }

        [When(@"I click the grade B radio button on the Update grade for appeal outcome page")]
        public void WhenIClickTheGradeBRadioButtonOnTheUpdateGradeForAppealOutcomePage()
        {
            RAUSelectCoreComponentGradePage.ClickBGradeRadioButton();
            RAUSelectCoreComponentGradePage.ClickContinueBtn();
        }

        [When(@"I click the grade A radio button on the Update grade for appeal outcome page")]
        public void WhenIClickTheGradeARadioButtonOnTheUpdateGradeForAppealOutcomePage()
        {
            RAUSelectCoreComponentGradePage.ClickAGradeRadioButton();
            RAUSelectCoreComponentGradePage.ClickContinueBtn();
        }



        [Then(@"the Check & submit appeal outcome page is displayed showing the old and newly selected grades")]
        public void ThenTheCheckSubmitAppealOutcomePageIsDisplayedShowingTheOldAndNewlySelectedGrades()
        {
            string uln = _scenarioContext["uln"] as string;
            RAUCheckAndSubmitPage.VerifyCheckAndSubmitPage();
            RAUCheckAndSubmitPage.VerifyCoreDetails();
            RAUCheckAndSubmitPage.VerifyGradeDetailsWhenNewGradeSelected(uln);
            RAUCheckAndSubmitPage.VerifyHelpText();
        }
        
        [Then(@"the Check & submit appeal outcome page is displayed showing the old and new grade are the same")]
        public void ThenTheCheckSubmitAppealOutcomePageIsDisplayedShowingTheOldAndNewGradeAreTheSame()
        {
            string uln = _scenarioContext["uln"] as string;
            RAUCheckAndSubmitPage.VerifyCheckAndSubmitPage();
            RAUCheckAndSubmitPage.VerifyCoreDetails();
            RAUCheckAndSubmitPage.VerifyGradeDetailsWhenGradeIsSame(uln);
            RAUCheckAndSubmitPage.VerifyHelpText();

        }
    }
}
