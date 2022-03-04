using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;


namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class Tlrc4695AssessmentEntriesBulkuploadResitSpecialismStage4ValidationsSteps : AssessmentEntriesPage
    {
        [Given(@"I have a registration with couplet specialism assessment series added for previous assessment year with no grade with (.*)")]
        public void GivenIHaveARegistrationWithCoupletSpecialismAssessmentSeriesAddedForPreviousAssessmentYearWithNoGradeWith(string uln)
        {
            var summer2021SpecialismAssessSeriesId = SqlQueries.InsertSummer2021SpecialismAssessSeries();
            RegistrationCityAndGuilds.RegWithResitCoupletSpecialismAssessment(uln, summer2021SpecialismAssessSeriesId);
        }

        [Then(@"I should see all of the stage (.*) validation errors related to Assessments in file ""([^""]*)""")]
        public void ThenIShouldSeeAllOfTheStageValidationErrorsRelatedToAssessmentsInFile(int p0, string fileName)
        {
            var file = string.Concat("Data\\", fileName);
           CsvFileReader.CsvDataFileCompare(file);          
        }
    }
}
