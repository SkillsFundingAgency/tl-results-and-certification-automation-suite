using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class ChangeCoreResultSteps :  CrateRegistrationInDb
    {
        private readonly ScenarioContext _scenarioContext;
        public ChangeCoreResultSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I have a registration with result")]
        public void GivenIHaveARegistrationWithResult()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            CreateDbRegWithResult(uln);
        }
        
        [Given(@"I am on result details page")]
        public void GivenIAmOnResultDetailsPage()
        {
            ResultsDashboardPage.ClickResultsLink();
            var uln = _scenarioContext["uln"] as string;
            ResultsDashboardPage.SearchResult(uln);
        }
        
        [Given(@"I click on ""(.*)"" link in result page")]
        public void GivenIClickOnLinkInResultPage(string p0)
        {
            WebDriver.FindElement(ResultsDashboardPage.ChangeResult).Click();
        }

        [Given(@"I change the grade")]
        public void GivenIChangeTheGrade()
        {
            ClickElement(ResultsDashboardPage.SelectResultB);
        }
        
        [Then(@"I should see result change successfull page")]
        public void ThenIShouldSeeResultChangeSuccessfullPage()
        {
            ResultsDashboardPage.VerifyResultChangeSuccessPage();
            var uln = _scenarioContext["uln"] as string;
            DeleteRegistrationFromTables(uln);
        }
    }
}
