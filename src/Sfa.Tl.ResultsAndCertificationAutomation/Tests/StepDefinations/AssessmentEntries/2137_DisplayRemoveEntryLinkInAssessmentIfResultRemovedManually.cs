using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class DisplayRemoveEntryLinkInAssessmentIfResultRemovedManually : AssessmentEntriesPage
    {
        private readonly ScenarioContext _scenarioContext;
        public DisplayRemoveEntryLinkInAssessmentIfResultRemovedManually(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I changed the result to Not received for that learner")]
        public void GivenIChangedTheResultToNotReceivedForThatLearner()
        {
            var uln = _scenarioContext["uln"] as string;
            ResultsDashboardPage.ClickResultsLink();
            ResultsDashboardPage.searchResult(uln);
            ClickElement(ResultsDashboardPage.changeResult);
            ClickElement(ResultsDashboardPage.notreceivedGrade);
            ClickButton(ResultsDashboardPage.changeBtn);
            ResultsDashboardPage.VerifyResultChangeSuccessPage();
        }
    }
}
