using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2838_LearnerTLevelRecordPageLRSDataSteps : CrateRegistrationInDb
    {
        private readonly ScenarioContext _scenarioContext;
        public _2838_LearnerTLevelRecordPageLRSDataSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I have a registraion from LRS with EM and IP")]
        public void GivenIHaveARegistraionFromLRSWithEMAndIP()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            CreateDbRegistationForLrsWithEmAndIp(uln);
        }
        
        [Then(@"I should see Learner T Level Record page")]
        public void ThenIShouldSeeLearnerTLevelRecordPage()
        {
            LearnerRecordPage_ToBeDeleted.VerifyLearnerRecordPage();
            LearnerRecordPage_ToBeDeleted.VerifyEMAndIPStatus();
            var uln = _scenarioContext["uln"] as string;
            LearnerRecordPage_ToBeDeleted.VerifyLearnerRecordData(uln);
            LearnerRecordPage_ToBeDeleted.VerifyLinksOnLearnerRecordPage();
        }
        [When(@"I click on ""(.*)"" breadcrumb")]
        public void WhenIClickOnBreadcrumb(string name)
        {
            LearnerRecordPage_ToBeDeleted.ClickBreadCrumb(name);
        }

        [Then(@"I should see search for learner page")]
        public void ThenIShouldSeeSearchForLearnerPage()
        {
            UpdateLearnerSearchPage.VerifySearchLearnerPage();
        }
        [Then(@"I should see Provider home page")]
        public void ThenIShouldSeeProviderHomePage()
        {
            TlevelDashboardPage.VerifyDashboardpage();
        }
    }
}
