using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2952_ManagingDataTransferManualSteps : CrateRegistrationInDb
    {
        private readonly ScenarioContext _scenarioContext;
        public _2952_ManagingDataTransferManualSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I have a registration with IP against Dudley provider")]
        public void GivenIHaveARegistrationWithIPAgainstDudleyProvider()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            CreateLrsRegWithEMAndIPForDudley(uln);
        }
        
        [Given(@"I search the registration and on change provider page")]
        public void GivenISearchTheRegistrationAndOnChangeProviderPage()
        {
            RegistrationsManualPage.ClickSearchForRegistrationLink();
            string uln = _scenarioContext["uln"] as string;
            RegistrationsManualPage.EnterSearchUln(uln);
            RegistrationsManualPage.ClickSearchButton();
            RegistrationsManualPage.ClickChangePoviderLink();
        }
        
        [Given(@"I changed the provider to ""(.*)""")]
        public void GivenIChangedTheProviderTo(string p0)
        {
            RegistrationsManualPage.SelectProviderFromList(Constants.DbProviderNameForLrs);
            RegistrationChangeProviderPage.ClickChangeButton();
        }
        
        [When(@"I search the learner record")]
        public void WhenISearchTheLearnerRecord()
        {
            string uln = _scenarioContext["uln"] as string;
            UpdateLearnerSearchPage.Enteruln(uln);
        }
        
        [Then(@"I should see previous IP record is active for new provider")]
        public void ThenIShouldSeePreviousIPRecordIsActiveForNewProvider()
        {
            LearnerRecordPage.VerifyLearnerRecordPage();
            var uln = _scenarioContext["uln"] as string;
            LearnerRecordPage.VerifyLearnerRecordData(uln);
            LearnerRecordPage.VerifyEMOrIPStatus("Placement completed");
        }
        [Then(@"I have deleted LRS data from the database")]
        public void ThenIHaveDeletedLRSDataFromTheDatabase()
        {
            var uln = _scenarioContext["uln"] as string;
            DeleteLrsDataFromTables(uln);
        }

    }
}
