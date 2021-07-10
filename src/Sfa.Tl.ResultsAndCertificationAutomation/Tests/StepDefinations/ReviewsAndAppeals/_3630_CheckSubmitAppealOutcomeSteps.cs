using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3630PostResultsServices_CheckSubmitAppealOutcomeSteps
    {
        private readonly ScenarioContext _scenarioContext;
        public _3630PostResultsServices_CheckSubmitAppealOutcomeSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;

        }

        [When(@"I select '(.*)' radio button on the Add outcome of appeal page")]
        public void WhenISelectRadioButtonOnTheAddOutcomeOfAppealPage(string p0)
        {
            RAULearnersComponentGradesStatusPage.ClickUpdateLink();
            RAUAppealGradePage.ClickYesRadioBtn();
            RAUAppealGradePage.ClickSubmitBtn();
            RAULearnersComponentGradesStatusPage.ClickUpdateLink();
            RAUAddOutcomeOfAppealPage.ClickGradeIsSameRadioBtn();
            RAUAddOutcomeOfAppealPage.ClickContinueBtn();
        }
        
        [Then(@"the Check & submit appeal outcome page is displayed")]
        public void ThenTheCheckSubmitAppealOutcomePageIsDisplayed()
        {
            string uln = _scenarioContext["uln"] as string;
            RAUCheckAndSubmitPage.VerifyCheckAndSubmitPage();
            RAUCheckAndSubmitPage.VerifyRAULearnerDetails(uln);
            RAUCheckAndSubmitPage.VerifyCoreDetails();
        }
        
        [Then(@"the New grade is the same as the old grade")]
        public void ThenTheNewGradeIsTheSameAsTheOldGrade()
        {
            string uln = _scenarioContext["uln"] as string;
            RAUCheckAndSubmitPage.VerifyGradeDetailsWhenGradeIsSame(uln);
        }

        [Then(@"the help text for the page will be displayed")]
        public void ThenTheHelpTextForThePageWillBeDisplayed()
        {
            RAUCheckAndSubmitPage.VerifyHelpText();
        }

        [When(@"I click the Back link on the Check & submit appeal outcome page")]
        public void WhenIClickTheBackLinkOnTheCheckSubmitAppealOutcomePage()
        {
            RAUCheckAndSubmitPage.ClickBackLink();
        }


    }
}
