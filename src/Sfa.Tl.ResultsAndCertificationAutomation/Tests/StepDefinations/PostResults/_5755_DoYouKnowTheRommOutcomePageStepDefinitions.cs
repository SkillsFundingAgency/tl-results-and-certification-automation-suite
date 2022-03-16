using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostResults
{
    [Binding]
    public class _5755_DoYouKnowTheRommOutcomePageStepDefinitions : DoYouKnowTheRommOutcomePage
    {
        private readonly ScenarioContext _scenarioContext;
        public _5755_DoYouKnowTheRommOutcomePageStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I have a registration with ROMM recorded")]
        public void GivenIHaveARegistrationWithRommRecorded()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            RegistrationCityAndGuilds.RegWithRommRecord(uln);
        }

        [Then(@"do you know thge romm outcome page is shown")]
        public void ThenDoYouKnowThgeRommOutcomePageIsShown()
        {
            VerifyDoYouKnowTheRommOutcomePage();
        }
        [When(@"I click continue without selecting any outcome option")]
        public void WhenIClickContinueWithoutSelectingAnyOutcomeOption()
        {
            ClickContinue();
        }

        [Then(@"error message shown on do you know romm outcome page")]
        public void ThenErrorMessageShownOnDoYouKnowRommOutcomePage(Table table)
        {
            VerifyDoYouKnowTheRommOutcomeErrorPage();
            CommonPage.VerifyValidationMessage(table);
        }

        [Then(@"error summary shown on do you know romm outcome page")]
        public void ThenErrorSummaryShownOnDoYouKnowRommOutcomePage(Table table)
        {
            CommonPage.VerifyValidationSummaryMessages(table);
        }

    }
}
