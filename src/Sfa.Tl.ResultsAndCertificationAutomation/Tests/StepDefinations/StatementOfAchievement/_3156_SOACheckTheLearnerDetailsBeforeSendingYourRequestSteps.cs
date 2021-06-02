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



    }
}
