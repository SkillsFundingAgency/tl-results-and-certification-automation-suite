using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.DataExport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.DataExport
{
    [Binding]
    public class _4867_NoRecordsFoundRegistrationsSteps : DataExportRegistrationsPage
    {
        [Given(@"I have deleted all data for ""(.*)""")]
        [Then(@"I have deleted all data for ""(.*)""")]
        public void GivenIHaveDeletedAllDataFor(string aoName)
        {
            switch (aoName)
            {
                case "Pearson":
                    SqlQueriesBulkUploads.DeleteAORecords(10022490);
                    break;
                case "Ncfe":
                    SqlQueriesBulkUploads.DeleteAORecords(10009696);
                    break;
                case "CityAndGuilds":
                    SqlQueriesBulkUploads.DeleteAORecords(10009931);
                    break;
            }
        }

        [Then(@"No records found page is displayed")]
        public void ThenNoRecordsFoundPageIsDisplayed()
        {
            VerifyNoRegistrationRecordsPage();
        }
        
        [Then(@"click on Add Registration will take to Registrations page")]
        public void ThenClickOnAddRegistrationWillTakeToRegistrationsPage()
        {
            AddRegistration();
        }
    }
}
