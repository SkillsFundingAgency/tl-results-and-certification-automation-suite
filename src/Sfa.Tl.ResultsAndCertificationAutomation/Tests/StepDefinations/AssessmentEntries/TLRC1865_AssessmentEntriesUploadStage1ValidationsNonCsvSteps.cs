using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class TLRC1865_AssessmentEntriesUploadStage1ValidationsNonCsvSteps : AssessmentEntriesPage
    {
        [Given(@"I have a active Assessment Series in ""(.*)""")]
        public void GivenIHaveAActiveAssessmentSeriesIn(string fileName)
        {
            CsvFileReader.CsvAssessmentSeriesUpdate(fileName);
        }

        [When(@"I upload ""(.*)"" file")]
        public void WhenIUpload(string file)
        {
            UploadFile(RegistrationsPage.ChooseFile, file);
        }
    }
}
