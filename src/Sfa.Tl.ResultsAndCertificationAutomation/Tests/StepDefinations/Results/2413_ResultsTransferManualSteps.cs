using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class ResultsTransferManualSteps : CrateRegistrationInDb
    {
        private readonly ScenarioContext _scenarioContext;
        public ResultsTransferManualSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I search the registration")]
        public void GivenISearchTheRegistration()
        {
            var uln = _scenarioContext["uln"] as string;
            RegistrationsPage.ClickRegLink();
            RegistrationsManualPage.ClickSearchForRegistrationLink();
            EnterText(RegistrationsSearchPage.SearchBox, uln);
            ClickElement(RegistrationsSearchPage.SearchBtn);
        }
        
        [Given(@"I changed the provider")]
        public void GivenIChangedTheProvider(Table table)
        {
            var row = table.Rows;
            var provider = row[0]["Provider"];
            RegistrationsManualPage.ClickChangePoviderLink();
            RegistrationsManualPage.SelectProviderFromList(provider);
            RegistrationsManualPage.ClickChangeBtn();
        }
        [When(@"I search the learner")]
        public void WhenISearchTheLearner()
        {
            var uln = _scenarioContext["uln"] as string;
            ResultsDashboardPage.searchResult(uln);
        }

    }
}
