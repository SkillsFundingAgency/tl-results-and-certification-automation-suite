using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class ChangeSuccessDeleteResult : CrateRegistrationInDb
    {
        private readonly ScenarioContext _scenarioContext;
        public ChangeSuccessDeleteResult(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I change the grade to Not Reveved")]
        public void GivenIChangeTheGradeToNotReveved()
        {
            WebDriver.FindElement(ResultsDashboardPage.NotreceivedGrade).Click();
        }

        [Then(@"I should see result change successfull message page")]
        public void ThenIShouldSeeResultChangeSuccessfullMessagePage()
        {
            ResultsDashboardPage.VerifyResultChangeSuccessPage();
        }

        [Then(@"I should go back to learner result page on clicking back to learner button")]
        public void ThenIShouldGoBackToLearnerResultPageOnClickingBackToLearnerButton()
        {
            WebDriver.FindElement(ResultsDashboardPage.BackToResultsBtn).Click();
            ResultsDashboardPage.VerifyLearnerResultPage();
            var uln = _scenarioContext["uln"] as string;
            DeleteRegistrationFromTables(uln);
        }
    }
}
