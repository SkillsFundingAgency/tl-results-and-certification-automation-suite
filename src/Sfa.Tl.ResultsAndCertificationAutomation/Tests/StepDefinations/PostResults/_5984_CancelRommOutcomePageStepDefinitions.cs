using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostResults
{
    [Binding]
    public class _5984_CancelRommOutcomePageStepDefinitions : CancelRommOutcomePage
    {
        [Then(@"cancel Romm outcome page is shown")]
        public void ThenCancelRommOutcomePageIsShown()
        {
            VerifyCancelRommOutcomePage();
        }

        [Then(@"No, cancel radio option will takes me to check romm outcome page")]
        public void ThenNoCancelRadioOptionWillTakesMeToCheckRommOutcomePage()
        {
            CheckNoCancelRadio();
        }
        [When(@"I click the Continue button")]
        public void WhenIClickTheContinueButton()
        {
            ClickContinueBtn();
        }

        [Then(@"error message shown on cancel romm outcome page")]
        public void ThenErrorMessageShownOnCancelRommOutcomePage(Table table)
        {
            VerifyCancelRommOutcomeErrorPage();
            CommonPage.VerifyValidationMessage(table);
        }

        [Then(@"error summary shown on cancel romm outcome page")]
        public void ThenErrorSummaryShownOnCancelRommOutcomePage(Table table)
        {
            CommonPage.VerifyValidationSummaryMessages(table);
        }

        [Then(@"yes, cancel radio will takes me to learner details page")]
        public void ThenYesCancelRadioWillTakesMeToLearnerDetailsPage()
        {
            CheckYesCancelRadio();
        }

    }
}
