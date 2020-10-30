using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class TLRC1865_AssessmentEntriesUploadStage1ValidationsNonCsvSteps : AssessmentEntriesPage
    {
        [When(@"I upload ""(.*)"" file")]
        public void WhenIUpload(string file)
        {
            UploadFile(RegistrationsPage.ChooseFile, file);
        }
    }
}
