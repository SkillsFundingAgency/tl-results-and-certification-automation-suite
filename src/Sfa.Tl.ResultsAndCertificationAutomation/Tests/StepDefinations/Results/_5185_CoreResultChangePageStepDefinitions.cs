using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Results;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class _5185_CoreResultChangePageStepDefinitions : ChangeCoreResultPage
    {
        private readonly ScenarioContext _scenarioContext;
        public _5185_CoreResultChangePageStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I have a registration with core and specialism assessments results")]
        public void GivenIHaveARegistrationWithCoreAndSpecialismAssessmentsResults()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            RegistrationCityAndGuilds.RegWithCoreAndSpecialismAssessmentResults(uln);
        }

        [Then(@"change core result page is open")]
        public void ThenChangeCoreResultPageIsOpen()
        {
            VerifyChangeCoreResultsPage();
            AddCoreResultPage.VerifyChangeGradesUnchecked();
        }

        [Then(@"I click on ""([^""]*)"" button")]
        public void ThenIClickOnButton(string change)
        {
            ClickChangeBtn();
        }

        [Then(@"I should see the following error message on change core result page")]
        public void ThenIShouldSeeTheFollowingErrorMessageOnChangeCoreResultPage(Table table)
        {
            VerifyChangeCoreResultsErrorPage();
            CommonPage.VerifyValidationMessage(table);
        }
    }
}
