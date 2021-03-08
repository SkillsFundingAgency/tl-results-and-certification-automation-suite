using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class TLRC1917_AssessmentEntryUploadSuccessfulSteps : AssessmentEntriesPage
    {
        [Then(@"I should see Upload success page")]
        public void ThenIShouldSeeUploadSuccessPage()
        {
            VerifyAssessmentUploadSuccessPage();
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
