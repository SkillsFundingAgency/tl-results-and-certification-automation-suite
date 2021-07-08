using System;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3478PostResultsServices_CoreComponentBeingAppealedSteps
    {
        private readonly ScenarioContext _scenarioContext;
        public _3478PostResultsServices_CoreComponentBeingAppealedSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [Given(@"I press the update button next to the grade I would like to appeal")]
        public void GivenIPressTheUpdateButtonNextToTheGradeIWouldLikeToAppeal()
        {
            RAULearnersComponentGradesStatusPage.ClickUpdateLink();
        }

        [Given(@"I press Submit without selecting a radio button on the Core component being appealed page")]
        public void GivenIPressSubmitWithoutSelectingARadioButtonOnTheCoreComponentBeingAppealedPage()
        {
            RAUAppealGradePage.ClickSubmitBtn();
        }

        
        [Then(@"I am shown the Core component being appealed page")]
        public void ThenIAmShownTheCoreComponentBeingAppealedPage()
        {
            string uln = _scenarioContext["uln"] as string;
            RAUAppealGradePage.VerifyRAUAppealGradePage();
            RAUAppealGradePage.VerifyRAULearnerDetails(uln);
            RAUAppealGradePage.VerifyRadioButtonsNotPrepopulated();
        }

        [Then(@"when I press the Back link on the Core component being appealed page")]
        public void ThenWhenIPressTheBackLinkOnTheCoreComponentBeingAppealedPage()
        {
            RAUAppealGradePage.ClickBackLink();
        }


        [Then(@"I am shown an error message on the Core component being appealed page stating '(.*)'")]
        public void ThenIAmShownAnErrorMessageOnTheCoreComponentBeingAppealedPageStating(string ErrorMessage)
        {
            RAUAppealGradePage.VerifyErrorMessage(ErrorMessage);
        }
    }
}
