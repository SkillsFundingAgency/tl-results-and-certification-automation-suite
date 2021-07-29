using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3757_BlockResultUpdateBeingAppealedSteps: CrateRegistrationInDb
    {
        [Given(@"I have a registration in Appealed state for this Uln")]
        public void GivenIHaveARegistrationInAppealedStateForThisUln(Table table)
        {
            var row = table.Rows;
            var uln = row[0]["Uln"];
            CreateRegWithAppealState(uln);
        }
        [Given(@"I upload ""(.*)"" result file")]
        public void GivenIUploadResultFile(string file)
        {
            UploadFile(RegistrationsPage.ChooseFile, file);
        }

        [Then(@"I should see update is blocked validation error in the results downloaded file")]
        public void ThenIShouldSeeUpdateIsBlockedValidationErrorInTheResultsDownloadedFile()
        {
            CsvFileReader.CsvDataFileCompare(ResultsDashboardPage.ResultsUploadBlockAppealErrors);
        }

    }
}
