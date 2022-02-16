using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results;

[Binding]
public class _5047_SpecialismStage2ValidationsStepDefinitions
{
    [Then(@"I should see all stage(.*) validation errors in the results downloaded file")]
    public void ThenIShouldSeeAllStageValidationErrorsInTheResultsDownloadedFile(int p0)
    {
        CsvFileReader.CsvDataFileCompare(ResultsDashboardPage.AssessmentResultStage2ValidationErrors);
    }
    [Then(@"I should see all no data validation error in the results downloaded file")]
    public void ThenIShouldSeeAllNoDataValidationErrorInTheResultsDownloadedFile()
    {
        CsvFileReader.CsvDataFileCompare(ResultsDashboardPage.AssessmentResultStage2NoDataValidationError);
    }

}