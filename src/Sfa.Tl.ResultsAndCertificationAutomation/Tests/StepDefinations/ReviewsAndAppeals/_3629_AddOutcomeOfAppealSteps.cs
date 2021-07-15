using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3629PostResultsServices_AddOutcomeOfAppealSteps
    {

        private readonly ScenarioContext _scenarioContext;
        public _3629PostResultsServices_AddOutcomeOfAppealSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;

        }

        [Given(@"my registration is set to BEING APPEALED")]
        public void GivenMyRegistrationIsSetToBEINGAPPEALED()
        {
            RAULearnersComponentGradesStatusPage.ClickUpdateLink();
            RAUAppealGradePage.ClickYesRadioBtn();
            RAUAppealGradePage.ClickSubmitBtn();
        }

        [Then(@"the Add outcome of appeal page is displayed")]
        public void ThenTheAddOutcomeOfAppealPageIsDisplayed()
        {
            string uln = _scenarioContext["uln"] as string;
            RAUAddOutcomeOfAppealPage.VerifRadioButtonText();
            RAUAddOutcomeOfAppealPage.VerifyAddOutcomeOfAppealPage();
            RAUAddOutcomeOfAppealPage.VerifyRAULearnerDetails(uln);
        }

        [When(@"I press the Back link on the Add outcome of appeal page")]
        public void WhenIPressTheBackLinkOnTheAddOutcomeOfAppealPage()
        {
            RAUAddOutcomeOfAppealPage.ClickBackLink();
        }

        [When(@"I press the Continue button without selecting a radio button Add outcome of appeal page")]
        public void WhenIPressTheContinueButtonWithoutSelectingARadioButtonAddOutcomeOfAppealPage()
        {
            RAUAddOutcomeOfAppealPage.ClickContinueBtn();
        }

        [Then(@"the following error message '(.*)' will be displayed")]
        public void ThenTheFollowingErrorMessageWillBeDisplayed(string ErrorMessage)
        {
            RAUAddOutcomeOfAppealPage.VerifyErrorMessage(ErrorMessage);
        }
    }
}
