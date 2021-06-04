using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Features.StatementOfAchievement
{
    [Binding]
    public class _3615_StatementOfAchievement_ULN5_MinimumRequirementsNotMet_NoCoreGradeIPNotCompletedSteps : CrateRegistrationInDb
    {

        private readonly ScenarioContext _scenarioContext;
        public _3615_StatementOfAchievement_ULN5_MinimumRequirementsNotMet_NoCoreGradeIPNotCompletedSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [Given(@"a registration is created for LRS where '(.*)' and '(.*)'")]
        public void GivenARegistrationIsCreatedForLRSWhereAnd(string LRSCombination, string IPStatus)
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;

            CreateDbRegistationForLrsCombination(uln, LRSCombination, IPStatus);
        }

        [Given(@"a registration is created for NON LRS where '(.*)' and '(.*)'")]
        public void GivenARegistrationIsCreatedForNONLRSWhereAnd(string NonLRSCombination, string IPStatus)
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            CreateDbRegistationForNonLrsCombination(uln, NonLRSCombination, IPStatus);

        }

        [Then(@"I am shown the SOA Check and submit page")]
        public void ThenIAmShownTheSOACheckAndSubmitPage()
        {
            SOACheckAndSubmitPage.VerifySOACheckAndSubmitPage();
        }


        [Then(@"the learners T Level component achievement details display '(.*)' and IP displays '(.*)'")]
        public void ThenTheLearnersTLevelComponentAchievementDetailsDisplayAndIPDisplays(string MathEngStatus, string IndPlacementStatus)
        {
            SOACheckAndSubmitPage.VerifyLearnersTLevelComponentAchievements(MathEngStatus, IndPlacementStatus);
        }


        [Then(@"the learners registration and qualification details are shown")]
        public void ThenTheLearnersRegistrationAndQualificationDetailsAreShown()
        {
            var uln = _scenarioContext["uln"] as string;
            SOACheckAndSubmitPage.VerifyLearnerDetails(uln);
            SOACheckAndSubmitPage.VerifyQualificationDetails();
            SOACheckAndSubmitPage.VerifyPostalAddress();
        }

        [Then(@"the registration is deleted for this test")]
        public void ThenTheRegistrationIsDeletedForThisTest()
        {
            var uln = _scenarioContext["uln"] as string;
            CrateRegistrationInDb createReg = new CrateRegistrationInDb();
            createReg.DeleteLrsRecordsFromTables(uln);
            createReg.DeleteRegistrationFromTables(uln);
        }

        [When(@"I press the '(.*)' breadcrumb on the Request SOA Check and Submit page")]
        [Given(@"I press the '(.*)' breadcrumb on the Request SOA Check and Submit page")]
        public void GivenIPressTheBreadcrumbOnTheRequestSOACheckAndSubmitPage(string Breadcrumb)
        {
            SOACheckAndSubmitPage.ClickBreadCrumb(Breadcrumb);
        }

        [Then(@"I am shown the Request SOA Search for a learner page")]
        public void ThenIAmShownTheRequestSOASearchForALearnerPage()
        {
            RequestSOA_SearchForALearnerPage.VerifySearchLearnerPage();
        }


        [When(@"I navigate back to the Request SOA Check and Submit page from the request Statement of Achievement -  Search for a learner page")]
        public void WhenINavigateBackToTheRequestSOACheckAndSubmitPageFromTheRequestStatementOfAchievement_SearchForALearnerPage()
        {
            var uln = _scenarioContext["uln"] as string;
            RequestSOA_SearchForALearnerPage.EnterULN(uln);
        }

        [When(@"I navigate back to the Request SOA Check and Submit page from the request Statement of Achievement page")]
        public void WhenINavigateBackToTheRequestSOACheckAndSubmitPageFromTheRequestStatementOfAchievementPage()
        {
            ClickLinkByLabel("Continue");
            var uln = _scenarioContext["uln"] as string;
            RequestSOA_SearchForALearnerPage.EnterULN(uln);
        }


        [Then(@"I am shown the Request statement of achievement page")]
        public void ThenIAmShownTheRequestStatementOfAchievementPage()
        {
            RequestStatementOfAchievementPage.VerifyRequestStatementOfAchievementPage();
        }

        [Given(@"I navigate to Request statement of achievment - Check and submit page")]
        public void GivenINavigateToRequestStatementOfAchievment_CheckAndSubmitPage()
        {
            ClickLinkByLabel("Request statement of achievement");
            ClickLinkByLabel("Continue");
            var uln = _scenarioContext["uln"] as string;
            RequestSOA_SearchForALearnerPage.EnterULN(uln);
        }
    }
}

