﻿using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2844_LearnerTLevelRecordPageNoLRSDataSteps : CrateRegistrationInDb
    {
        private readonly ScenarioContext _scenarioContext;
        public _2844_LearnerTLevelRecordPageNoLRSDataSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I have a registraion with EM and IP from non LRS")]
        public void GivenIHaveARegistraionWithEMAndIPFromNonLRS()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            CreateDbRegistationNonLrsWithEmAndIp(uln);
        }
        
        [Then(@"I should see Learner T Level Record page for Non LRS")]
        public void ThenIShouldSeeLearnerTLevelRecordPageForLRS()
        {
            LearnerRecordPage_ToBeDeleted.VerifyLearnerRecordPage();
            LearnerRecordPage_ToBeDeleted.VerifyEMAndIPStatusForNonLRS();
            var uln = _scenarioContext["uln"] as string;
            LearnerRecordPage_ToBeDeleted.VerifyLearnerRecordData(uln);
            LearnerRecordPage_ToBeDeleted.VerifyLinksOnLearnerRecordNonLRSPage();
        }
    }
}
