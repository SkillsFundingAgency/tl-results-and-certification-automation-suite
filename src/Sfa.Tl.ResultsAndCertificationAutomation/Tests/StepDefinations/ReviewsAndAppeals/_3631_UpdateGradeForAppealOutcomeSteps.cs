using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3631_UpdateGradeForAppealOutcomeSteps
    {

        private readonly ScenarioContext _scenarioContext;
        public _3631_UpdateGradeForAppealOutcomeSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;

        }


        [When(@"I select I need to change the grade radio button on the Add outcome of appeal page")]
        public void WhenISelectINeedToChangeTheGradeRadioButtonOnTheAddOutcomeOfAppealPage()
        {
            RAULearnersComponentGradesStatusPage.ClickUpdateLink();
            RAUAppealGradePage.ClickYesRadioBtn();
            RAUAppealGradePage.ClickSubmitBtn();
            RAULearnersComponentGradesStatusPage.ClickUpdateLink();
            RAUAddOutcomeOfAppealPage.ClickINeedToUpdateTheGradeRadioBtn();
            RAUAddOutcomeOfAppealPage.ClickContinueBtn();
        }
        
        [When(@"I click the Back link on the Update grade for appeal outcome page")]
        public void WhenIClickTheBackLinkOnTheUpdateGradeForAppealOutcomePage()
        {
            RAUSelectCoreComponentGradePage.ClickBackLink();
        }
        
        [Then(@"the Update grade for appeal outcome page is displayed")]
        public void ThenTheUpdateGradeForAppealOutcomePageIsDisplayed()
        {
            string uln = _scenarioContext["uln"] as string;
            RAUSelectCoreComponentGradePage.VerifySelectTheCoreComponentGradePage();
            RAUSelectCoreComponentGradePage.VerifyRAULearnerDetails(uln);
        }
        
        [Then(@"the radio buttons will not be selected on page entry")]
        public void ThenTheRadioButtonsWillNotBeSelectedOnPageEntry()
        {
            RAUSelectCoreComponentGradePage.VerifyRadioButtonsNotPopulated();
        }


        [When(@"I click the Continue button without selecting a radio button on the Update grade for appeal outcome page")]
        public void WhenIClickTheContinueButtonWithoutSelectingARadioButtonOnTheUpdateGradeForAppealOutcomePage()
        {
            RAUSelectCoreComponentGradePage.ClickContinueBtn();
        }

        [Then(@"the following error message will be displayed '(.*)'")]
        public void ThenTheFollowingErrorMessageWillBeDisplayed(string ErrorMessage)
        {
            RAUSelectCoreComponentGradePage.VerifyErrorMessage(ErrorMessage); 
        }


    }
}
