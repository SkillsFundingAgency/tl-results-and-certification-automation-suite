using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostResults
{
    [Binding]
    public class _5887_AddAppealCoreStepDefinitions : AddAppealPage
    {
        private readonly ScenarioContext _scenarioContext;

        public _5887_AddAppealCoreStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I have a registration with Romm outcome recorded")]
        public void GivenIHaveARegistrationWithRommOutcomeRecorded()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            RegistrationCityAndGuilds.RegWithRommOutcomeRecorded(uln);
        }

        [Then(@"Add an appeal page is shown")]
        public void ThenAddAnAppealPageIsShown()
        {
            VerifyAddAppealPage();
        }

        [Then(@"core details shown in learner details")]
        public void ThenCoreDetailsShownInLearnerDetails()
        {
            VerifyLearnerCoreDetailsAddAppealPage();
        }
        [Then(@"error message shown on add appeal page")]
        public void ThenErrorMessageShownOnAddAppealPage(Table table)
        {
            VerifyAddAppealErrorPage();
            CommonPage.VerifyValidationMessage(table);
        }

        [Then(@"error summary shown on add appeal page")]
        public void ThenErrorSummaryShownOnAddAppealPage(Table table)
        {
            CommonPage.VerifyValidationSummaryMessages(table);
        }
        [Given(@"I select ""([^""]*)"" radio button on add appeal Page")]
        [When(@"I select ""([^""]*)"" radio button on add appeal Page")]
        public void WhenISelectRadioButtonOnAddAppealPage(string text)
        {
            AddAppealBtn(text);
        }
        [Then(@"specialism details shown in learner details")]
        public void ThenSpecialismDetailsShownInLearnerDetails()
        {
            VerifyLearnerSpecialismDetailsAddAppealPage();
        }

    }
}
