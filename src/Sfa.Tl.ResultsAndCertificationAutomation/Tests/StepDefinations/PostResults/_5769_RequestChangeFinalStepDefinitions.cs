using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostResults
{
    [Binding]
    public class _5769_RequestChangeFinalStepDefinitions : RequestChangeFinalGrade
    {
        private readonly ScenarioContext _scenarioContext;
        public _5769_RequestChangeFinalStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I have registration with results in final state")]
        public void GivenIHaveRegistrationWithResultsInFinalState()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            RegistrationCityAndGuilds.CreateRegWithResultInFinalState(uln);
        }

        [Then(@"requst change a final grade page is shown")]
        public void ThenRequstChangeAFinalGradePageIsShown()
        {
            VerifyChangeRequestFinalGradePage();
        }
        [When(@"I click on Send button without entering data")]
        public void WhenIClickOnSendButtonWithoutEnteringData()
        {
            ClickSendBtn();
        }

        [Then(@"error message shown on request change a final grade page")]
        public void ThenErrorMessageShownOnRequestChangeAFinalGradePage(Table table)
        {
            VerifyChangeRequestFinalGradeErrorPage();
            CommonPage.VerifyValidationMessage(table);
        }

        [Then(@"error summary shown on request change a final grade page")]
        public void ThenErrorSummaryShownOnRequestChangeAFinalGradePage(Table table)
        {
            CommonPage.VerifyValidationSummaryMessages(table);
        }

    }
}
