using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostResults
{
    [Binding]
    public class _5748_PostResultsAddRommPageStepDefinitions : AddRommPage
    {
        private readonly ScenarioContext _scenarioContext;
        public _5748_PostResultsAddRommPageStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I am on post results learner details page")]
        public void GivenIAmOnPostResultsLearnerDetailsPage()
        {
            TlevelDashboardPage.ClickReviewAndAppealsLinks();
            SearchForLearnerPage.PressContinueBtn();
            var uln = _scenarioContext["uln"] as string;
            UpdateLearnerSearchPage.Enteruln(uln);
            PostResultsLearnerDetailsPage.VerifyPostResultsLearnerDetailsPage();
        }

        [Given(@"I click ""([^""]*)"" button in post result learner details page")]
        [When(@"I click ""([^""]*)"" button in post result learner details page")]
        public void WhenIClickButtonInPostResultLearnerDetailsPage(string text)
        {
            PostResultsLearnerDetailsPage.AddRommBtn(text);
        }

        [Then(@"Add a ROMM page is shown")]
        public void ThenAddAROMMPageIsShown()
        {
            VerifyAddRommPage();
        }

        [Then(@"back link takes me to post result learner details page")]
        public void ThenBackLinkTakesMeToPostResultLearnerDetailsPage()
        {
            ClickBackLink();
            PostResultsLearnerDetailsPage.VerifyPostResultsLearnerDetailsPage();
        }
        [When(@"I click on Continue button without selecting ROMM option")]
        public void WhenIClickOnContinueButtonWithoutSelectingROMMOption()
        {
            ClickContinueBtn();
        }

        [Then(@"error message shown on add romm page")]
        public void ThenErrorMessageShownOnAddRommPage(Table table)
        {
            VerifyAddRommErrorPage();
            CommonPage.VerifyValidationMessage(table);
        }

        [Then(@"error summary shown on add romm page")]
        public void ThenErrorSummaryShownOnAddRommPage(Table table)
        {
            CommonPage.VerifyValidationSummaryMessages(table);
        }
        [Given(@"I select ""([^""]*)"" radio button on add Romm Page")]
        [When(@"I select ""([^""]*)"" radio button on add Romm Page")]
        public void WhenISelectRadioButtonOnAddRommPage(string option)
        {
            AddRommBtn(option);
        }

    }
}
