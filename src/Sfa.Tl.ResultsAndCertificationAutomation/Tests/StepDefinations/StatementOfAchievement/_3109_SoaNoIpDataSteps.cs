using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.StatementOfAchievement
{
    [Binding]
    public class _3109_SoaNoIpDataSteps : CrateRegistrationInDb
    {
        private readonly ScenarioContext _scenarioContext;
        public _3109_SoaNoIpDataSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I have a withdrawn registration for Barsley with no IP data")]
        public void GivenIHaveAWithdrawnRegistrationForBarsleyWithNoIPData()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            CreateAndWithdrawRegBarnsley(uln);
        }
        
        [When(@"I enter withdrawn Uln without IP data and click on Search button")]
        public void WhenIEnterWithdrawnUlnWithoutIPDataAndClickOnSearchButton()
        {
            var uln = _scenarioContext["uln"] as string;
            RequestSOA_SearchForALearnerPage.EnterULN(uln);
        }

        [Then(@"I should see SOA not available without Ip page")]
        public void ThenIShouldSeeSOANotAvailableWithoutIpPage()
        {
            SoaNotAvailablePage.VerifySoaNotAvailablePage();
            var uln = _scenarioContext["uln"] as string;
            UlnNotRegisteredPage.VerifyUlnNotWithdrawnContent(uln);
        }
        [When(@"I click on Add learner T Level record button on Soa not available page")]
        public void WhenIClickOnAddLearnerTLevelRecordButtonOnSoaNotAvailablePage()
        {
            SoaNotAvailablePage.ClickAddTlevelRecordBtn();
        }

        [Then(@"I should see Add a new learner T Level record page")]
        public void ThenIShouldSeeAddANewLearnerTLevelRecordPage()
        {
            LearnerAddLearnerPage.VerifyAddANewLearnerRecordPage();
        }
        [Then(@"I should see Soa search for learner page")]
        public void ThenIShouldSeeSoaSearchForLearnerPage()
        {
            RequestSOA_SearchForALearnerPage.VerifySearchLearnerPage();
            var uln = _scenarioContext["uln"] as string;
            RequestSOA_SearchForALearnerPage.VerifySeachUlnField(uln);
        }
        [Then(@"I should see request Soa page when i click ""(.*)"" breadcrub")]
        public void ThenIShouldSeeRequestSoaPageWhenIClickBreadcrub(string name)
        {
            RequestSOA_SearchForALearnerPage.ClickSearch();
            SoaNotAvailablePage.ClickBreadCrumb(name);
            RequestStatementOfAchievementPage.VerifyRequestStatementOfAchievementPage();
        }

    }
}
