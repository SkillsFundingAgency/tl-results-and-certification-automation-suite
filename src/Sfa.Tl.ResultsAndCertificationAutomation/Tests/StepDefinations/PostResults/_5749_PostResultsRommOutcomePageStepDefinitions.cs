using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostResults
{
    [Binding]
    public class _5749_PostResultsRommOutcomePageStepDefinitions : AddRommOutcomePage
    {
        [Then(@"ROMM outcome page is shown")]
        public void ThenROMMOutcomePageIsShown()
        {
            VerifyAddRommOutcomePage();
        }

        [Then(@"back link takes me to add ROMM page")]
        public void ThenBackLinkTakesMeToAddROMMPage()
        {
            VerifyBackLink();
        }
        [When(@"I click continue button in Romm outcome page")]
        public void WhenIClickContinueButtonInRommOutcomePage()
        {
            ClickContinueBtn();
        }

        [Then(@"error message shown on Romm outcome page")]
        public void ThenErrorMessageShownOnRommOutcomePage(Table table)
        {
            VerifyAddRommOutcomeErrorPage();
            CommonPage.VerifyValidationMessage(table);
        }

        [Then(@"error summary shown on romm outcome page")]
        public void ThenErrorSummaryShownOnRommOutcomePage(Table table)
        {
            CommonPage.VerifyValidationSummaryMessages(table);
        }
        [Given(@"I select ""([^""]*)"" option in romm outcome page")]
        [When(@"I select ""([^""]*)"" option in romm outcome page")]
        public void WhenISelectOptionInRommOutcomePage(string option)
        {
            AddRommOutcomeOptions(option);
        }
    }
}
