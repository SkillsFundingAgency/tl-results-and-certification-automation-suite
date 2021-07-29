using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3773_BlockUploadResultForFinalSteps : CrateRegistrationInDb
    {
        [Given(@"I have a registration in Final state for this Uln")]
        public void GivenIHaveARegistrationInFinalStateForThisUln(Table table)
        {
            var row = table.Rows;
            var uln = row[0]["Uln"];
            CreateRegWithFinalState(uln);
        }
        [Then(@"I should see update is blocked for final in the results downloaded file")]
        public void ThenIShouldSeeUpdateIsBlockedForFinalInTheResultsDownloadedFile()
        {
            CsvFileReader.CsvDataFileCompare(ResultsDashboardPage.ResultsUploadBlockFinalErrors);
        }
    }
}
