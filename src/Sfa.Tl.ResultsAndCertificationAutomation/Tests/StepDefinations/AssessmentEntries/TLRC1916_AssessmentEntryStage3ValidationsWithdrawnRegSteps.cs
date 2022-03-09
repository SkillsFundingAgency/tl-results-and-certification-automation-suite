using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class TLRC1916_AssessmentEntryStage3ValidationsWithdrawnRegSteps : AssessmentEntriesPage
    {
        [Then(@"I should see validation error for withdrawn registration")]
        public void ThenIShouldSeeValidationErrorForWithdrawnRegistration()
        {
            CsvFileReader.CsvDataFileCompare(AssessmentUploadStage3WithdrawnRegError);
            SqlQueries.DeleteFromRegistrationTables();
        }

        [Then(@"I should see all errors in the file for attempting to add a first assessment series")]
        public void ThenIShouldSeeAllErrorsInTheFileForAttemptingToAddAFirstAssessmentSeries()
        {
            CsvFileReader.CsvDataFileCompare(AssessmentUploadAddFirstAssessEntry);
            SqlQueries.DeleteFromRegistrationTables();
        }

        [Then(@"I should see all errors in the file for attempting to add invalid mulitple specialism entries")]
        public void ThenIShouldSeeAllErrorsInTheFileForAttemptingToAddInvalidMulitpleSpecialismEntries()
        {
            CsvFileReader.CsvDataFileCompare(AssessmentUploadMultipleSpecialismErrors);
            SqlQueries.DeleteFromRegistrationTables();
        }

    }
}
