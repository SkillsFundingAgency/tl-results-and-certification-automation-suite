using System.Threading;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class _5048_SpecialismResultsState3ValidationsStepDefinitions : ResultsDashboardPage
    {
        [Given(@"I have moved following registration in to withdrawn state")]
        public void GivenIHaveMovedFollowingRegistrationInToWithdrawnState(Table table)
        {
            var row = table.Rows;
            var uln = row[0]["Uln"];
            SqlQueries.UpdateRegWithdrawn(uln);
        }

        [Then(@"I should see results upload unsuccess page")]
        public void ThenIShouldSeeResultsUploadUnsuccessPage()
        {
            VerifyUploadResultsUnsuccessPage();
        }

        [Then(@"all assessment results stage(.*) erros listed in the downloaed report")]
        public void ThenAllAssessmentResultsStageErrosListedInTheDownloaedReport(int p0)
        {
            ClickElement(RegistrationsPage.DownloadErrorLink);
            Thread.Sleep(5000);
            CsvFileReader.CsvDataFileCompare(AssessmentResultStage3ValidationError);
        }
    }
}
