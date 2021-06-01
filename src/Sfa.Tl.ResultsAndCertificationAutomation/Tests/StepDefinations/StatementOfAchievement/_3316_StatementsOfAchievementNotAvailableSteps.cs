using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.StatementOfAchievement
{
    [Binding]
    public class _3316_StatementOfAchievement_StatementsOfAchievementAreNotYetAvailableSteps : CrateRegistrationInDb
    {

        private readonly ScenarioContext _scenarioContext;
        public _3316_StatementOfAchievement_StatementsOfAchievementAreNotYetAvailableSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [Given(@"I have created a registration which is withdrawn, IP is set to not complete and there is no grade attached")]
        public void GivenIHaveCreatedARegistrationWhichIsWithdrawnIPIsSetToNotCompleteAndThereIsNoGradeAttached()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            CreateRegForBarnsleyNoCoreGrade_Withdrawn_IndPlacementNotComplete(uln);            
        }

        [Then(@"I click Continue on the Request SOA page")]
        [Given(@"I click Continue on the Request SOA page")]
        public void GivenIClickContinueOnTheRequestSOAPage()
        {
            RequestStatementOfAchievementPage.ClickContinueButton();
        }


        [Then(@"I enter the ULN created for the Request SOA journey")]
        [Given(@"I enter the ULN created for the Request SOA journey")]
        public void GivenIEnterTheULNCreatedForTheRequestSOAJourney()
        {
            var uln = _scenarioContext["uln"] as string;
            RequestSOA_SearchForALearnerPage.EnterULN(uln);
           // RequestSOA_SearchForALearnerPage.ClickSearch();
        }

        [Then(@"I am shown the Statement of achievement not available - minimum requirements not met page")]
        public void ThenIAmShownTheStatementOfAchievementNotAvailable_MinimumRequirementsNotMetPage()
        {
            var uln = _scenarioContext["uln"] as string;
            SOAMinRequirementsNotMetPage.VerifySOANotAvailablePage(uln, "Db FirstName Db LastName", "01 January 2001", "Barnsley College (10000536)", "T Level in Agriculture, Environmental and Animal Care");
        }

        [When(@"I click the Back to Home button on the Statement of achievement not available - minimum requirements not met page")]
        public void WhenIClickTheBackToHomeButtonOnTheStatementOfAchievementNotAvailable_MinimumRequirementsNotMetPage()
        {
            SOAMinRequirementsNotMetPage.ClickBackToHomeButton();
        }


        [Then(@"I click the '(.*)' breadcrumb on the SOA not available - minimum requirements not met page")]
        [Given(@"I click the '(.*)' breadcrumb on the SOA not available - minimum requirements not met page")]
        public void GivenIClickTheBreadcrumbOnTheSOANotAvailable_MinimumRequirementsNotMetPage(string BreadCrumbName)
        {
            SOAMinRequirementsNotMetPage.ClickBreadCrumb(BreadCrumbName);
        }

        [Given(@"I click the Update their learner T-Level record link")]
        public void GivenIClickTheUpdateTheirLearnerT_LevelRecordLink()
        {
            SOAMinRequirementsNotMetPage.ClickUpdateTheirLearnerTLevelRecordLink();
        }

        [Then(@"I am shown the Leaner Search for a learner page")]
        public void ThenIAmShownTheLeanerSearchForALearnerPage()
        {
            LearnerSearchForLearnerPage.VerifySearchForALearnerPage();
        }




    }
}
