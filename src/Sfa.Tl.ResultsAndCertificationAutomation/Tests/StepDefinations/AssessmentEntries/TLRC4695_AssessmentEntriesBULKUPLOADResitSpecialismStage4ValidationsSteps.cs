using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Results;


namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class TLRC4695_AssessmentEntriesBULKUPLOADResitSpecialismStage4ValidationsSteps : AssessmentEntriesPage
    {
        private readonly ScenarioContext _scenarioContext;
        public TLRC4695_AssessmentEntriesBULKUPLOADResitSpecialismStage4ValidationsSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I have a registration with couplet specialism assessment series added for previous assessment year with no grade with (.*)")]
        public void GivenIHaveARegistrationWithCoupletSpecialismAssessmentSeriesAddedForPreviousAssessmentYearWithNoGradeWith(string uln)
        {
            var summer2021SpecialismAssessSeriesID = SqlQueries.InsertSummer2021SpecialismAssessSeries();
            RegistrationCityAndGuilds.RegWithResitCoupletSpecialismAssessment(uln, summer2021SpecialismAssessSeriesID);
        }


        [Then(@"I should see all of the stage (.*) validation errors related to Assessments in file ""([^""]*)""")]
        public void ThenIShouldSeeAllOfTheStageValidationErrorsRelatedToAssessmentsInFile(int p0, string fileName)
        {
            string file = string.Concat("Data\\", fileName);
           CsvFileReader.CsvDataFileCompare(file);          
        }
    }
}
