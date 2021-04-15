using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2951_ManagingDataTransferBulkUploadSteps : CrateRegistrationInDb
    {
        [Given(@"I have a registration in Db with IP against Dudley provider")]
        public void GivenIHaveARegistrationInDbWithIPAgainstDudleyProvider(Table table)
        {
            var row = table.Rows;
            var uln = row[0]["Uln"];
            CreateLrsRegWithEMAndIPForDudley(uln);
        }

        [Given(@"I am back to registration upload page")]
        public void GivenIAmBackToRegistrationUploadPage()
        {
            RegistrationsPage.VerifyRegistrationSuccessPage();
            ClickElement(RegistrationsPage.BacktoRegistrationLink);
            ClickElement(RegistrationsPage.UploadRegistationLink);
        }

        [When(@"I search the learner record with Uln")]
        public void WhenISearchTheLearnerRecordWithUln(Table table)
        {
            var row = table.Rows;
            var uln = row[0]["Uln"];
            UpdateLearnerSearchPage.Enteruln(uln);
        }

        [Then(@"I should see IP record for Uln is active for new provider")]
        public void ThenIShouldSeeIPRecordForUlnIsActiveForNewProvider(Table table)
        {
            var row = table.Rows;
            var uln = row[0]["Uln"];
            LearnerRecordPage.VerifyLearnerRecordPage();
            LearnerRecordPage.VerifyLearnerRecordData(uln);
            LearnerRecordPage.VerifyEMOrIPStatus("Placement completed");
        }

        [Then(@"I have deleted LRS data from the database for the Uln")]
        public void ThenIHaveDeletedLRSDataFromTheDatabaseForTheUln(Table table)
        {
            var row = table.Rows;
            var uln = row[0]["Uln"];
            DeleteLrsDataFromTables(uln);
        }

    }
}
