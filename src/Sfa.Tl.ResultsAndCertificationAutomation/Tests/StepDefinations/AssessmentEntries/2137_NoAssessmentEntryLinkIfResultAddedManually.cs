using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class NoAssessmentEntryLinkIfResultAddedManually : ResultsDashboardPage
    {
        private readonly ScenarioContext _scenarioContext;
        public NoAssessmentEntryLinkIfResultAddedManually(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [When(@"I search the assessment entry")]
        public void WhenISearchTheAssessmentEntry()
        {
            var uln = _scenarioContext["uln"] as string;
            AssessmentEntriesPage.SearchAssessmentEntry(uln);
        }
    }
}
