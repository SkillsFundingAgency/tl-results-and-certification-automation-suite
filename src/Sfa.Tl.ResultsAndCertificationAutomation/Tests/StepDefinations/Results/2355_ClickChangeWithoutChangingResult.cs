using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class ClickChangeWithoutChangingResult : CrateRegistrationInDb
    {
        private readonly ScenarioContext _scenarioContext;
        public ClickChangeWithoutChangingResult(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Then(@"I should go back to learner result page")]
        public void ThenIShouldGoBackToLearnerResultPage()
        {
            ResultsDashboardPage.VerifyLearnerResultPage();
            var uln = _scenarioContext["uln"] as string;
            DeleteRegistrationFromTables(uln);
        }
    }
}
