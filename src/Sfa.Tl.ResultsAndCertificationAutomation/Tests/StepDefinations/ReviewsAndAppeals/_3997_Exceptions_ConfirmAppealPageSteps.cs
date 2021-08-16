using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3997PostResultsServices_Exceptions_ConfirmAppealPageSteps
    {

        private readonly ScenarioContext _scenarioContext;
        public _3997PostResultsServices_Exceptions_ConfirmAppealPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;

        }

        [When(@"I click Continue on the Exeptions Start Page")]
        public void WhenIClickContinueOnTheExeptionsStartPage()
        {
            RAUExceptionsStartPage.ClickContinueBtn();
        }
        
     
        [Then(@"I am shown the Exceptions Confirm Appeal page")]
        public void ThenIAmShownTheExceptionsConfirmAppealPage()
        {
            string uln = _scenarioContext["uln"] as string;
            RAUExceptionsConfirmAppeal.VerifyExceptionConfirmAppealPage();
            RAUExceptionsConfirmAppeal.VerifRadioButtonText();
            RAUExceptionsConfirmAppeal.VerifyLearnerDetails(uln);
        }
        
        [When(@"I click Submit without selecting a radio button on the Exceptions Confirm Appeal page")]
        public void WhenIClickSubmitWithoutSelectingARadioButtonOnTheExceptionsConfirmAppealPage()
        {
            RAUExceptionsConfirmAppeal.ClickSubmitBtn();
        }

        [Then(@"the following error message is displayed on the Exceptions Confirm Appeal page ""(.*)""")]
        public void ThenTheFollowingErrorMessageIsDisplayedOnTheExceptionsConfirmAppealPage(string ErrorMessage)
        {
            RAUExceptionsConfirmAppeal.VerifyErrorMessage(ErrorMessage);
        }

        [Then(@"the radio buttons will not be populated on the Exceptions Confirm Appeal page")]
        public void ThenTheRadioButtonsWillNotBePopulatedOnTheExceptionsConfirmAppealPage()
        {
            RAUExceptionsConfirmAppeal.VerifyRadioButtonsNotPrepopulated();
        }

        [When(@"I click the back link on the Exceptions Confirm Appeal page")]
        public void WhenIClickTheBackLinkOnTheExceptionsConfirmAppealPage()
        {
            RAUExceptionsConfirmAppeal.ClickBackLink();
        }
    }
}
