using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class ResultsWithdrawnManualSteps : CrateRegistrationInDb
    {
        private readonly ScenarioContext _scenarioContext;
        public ResultsWithdrawnManualSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I have moved registration in to withdrawn state")]
        public void GivenIHaveMovedRegistrationInToWithdrawnState()
        {
            var uln = _scenarioContext["uln"] as string;
            CreateDbRegInWithdrawn(uln);
        }
        
        [Then(@"I should see following message for that registration")]
        public void ThenIShouldSeeFollowingMessageForThatRegistration(Table table)
        {
            var row = table.Rows;
            var message = row[0]["Message"];
            ResultsDashboardPage.VerifyLearnerResultWithdrawnPage();
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(message));
            var uln = _scenarioContext["uln"] as string;
            DeleteRegistrationFromTables(uln);
        }
    }
}
