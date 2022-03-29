using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostResults
{
    [Binding]
    public class _5771_RequestChangeCancelStepDefinitions : CancelRequestChangePage
    {
        [Then(@"request change cancel page shown")]
        public void ThenRequestChangeCancelPageShown()
        {
            VerifyCancelChangeRequestPage();
        }

        [Then(@"selecting no radio option takes me to request to change Final grade page")]
        public void ThenSeloectingNoRadioOptionTakesMeToRequestToChangeFinalGradePage()
        {
            CheckNoCancelRadio();
            RequestChangeFinalGrade.VerifyChangeRequestFinalGradePage();
        }
        [When(@"click on continue button without selecting any options")]
        public void WhenClickOnContinueButtonWithoutSelectingAnyOptions()
        {
            ClickContinueBtn();
        }

        [Then(@"error message shown on request change cancel page")]
        public void ThenErrorMessageShownOnRequestChangeCancelPage(Table table)
        {
            VerifyCancelChangeRequestErrorPage();
            CommonPage.VerifyValidationMessage(table);
        }

        [Then(@"error summary shown on request change cancel page")]
        public void ThenErrorSummaryShownOnRequestChangeCancelPage(Table table)
        {
            CommonPage.VerifyValidationSummaryMessages(table);
        }
        [Then(@"selecting yes radio option takes me to request to learner details page")]
        public void ThenSelectingYesRadioOptionTakesMeToRequestToLearnerDetailsPage()
        {
            CheckYesCancelRadio();
            PostResultsLearnerDetailsPage.VerifyPostResultsLearnerDetailsPage();
        }

    }
}
