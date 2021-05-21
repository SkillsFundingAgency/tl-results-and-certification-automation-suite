using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class _2605_DeletingInactiveResultsSteps : CrateRegistrationInDb
    {
        string webUrl;

        private readonly ScenarioContext _scenarioContext;
        public _2605_DeletingInactiveResultsSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I have a registration with an assessment entry")]
        public void GivenIHaveARegistrationWithAnAssessmentEntry()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            CreateDbRegWithAssessment(uln);
        }

        [Given(@"I capture the URL for the the Are you sure you want to remove this core assessment entry page")]
        public void GivenICaptureTheURLForTheTheAreYouSureYouWantToRemoveThisCoreAssessmentEntryPage()
        {
            var uln = _scenarioContext["uln"] as string;
            TlevelDashboardPage.ClickAssessmentEntriesLink();
            ClickElement(AssessmentEntriesPage.SearchForLearnerLink);
            AssessmentEntriesSearchForLearnerPage.EnterULN(uln);
            AssessmentEntriesLearnersAssessmentEntriesPage.ClickAddEntryLink();
            webUrl = WebDriver.Url;
        }

        [Given(@"I add a result to the registration")]
        public void GivenIAddAResultToTheRegistration()
        {
            var uln = _scenarioContext["uln"] as string;
            AssessmentEntriesLearnersAddNextCoreAssessmentEntryPage.PressBackLink();
            AssessmentEntriesLearnersAssessmentEntriesPage.PressHomeBreadcrumb();
            TlevelDashboardPage.ClickResultsLink();
            ResultsDashboardPage.ClickSearchForALearnerLink();
            ResultsSearchForALearnerPage.EnterULN(uln);
            ResultsLearnersResultsPage.ClickAddResultLink();
            ResultsSelectCorePage.SelectAStarResult();
        }


        [When(@"I attempt to access the URL for the Are you sure you want to remove this core assessment entry page")]
        public void WhenIAttemptToAccessTheURLForTheAreYouSureYouWantToRemoveThisCoreAssessmentEntryPage()
        {
            WebDriver.Navigate().GoToUrl(webUrl);
        }
    }
}
