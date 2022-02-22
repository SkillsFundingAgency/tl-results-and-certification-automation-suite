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
    public class TLRC_4704_AssessmentEntriesBULKUPLOADSingleOccupationalSpecialismStage4ValidationsSteps : AssessmentEntriesPage
    {
        private readonly ScenarioContext _scenarioContext;
        public TLRC_4704_AssessmentEntriesBULKUPLOADSingleOccupationalSpecialismStage4ValidationsSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I have a registration with Specialism assessment series added for previous assessment year with no grade with (.*)")]
        public void GivenIHaveARegistrationWithSpecialismAssessmentSeriesAddedForPreviousAssessmentYearWithNoGradeWith(string uln)
        {
            var summer2021SpecialismAssessSeriesID = SqlQueries.InsertSummer2021SpecialismAssessSeries();
            RegistrationCityAndGuilds.RegWithResitSpecialismAssessment(uln, summer2021SpecialismAssessSeriesID);
        }

        [Given(@"I have a registration with Specialism assessment series added for previous assessment year with a grade with (.*)")]
        public void GivenIHaveARegistrationWithSpecialismAssessmentSeriesAddedForPreviousAssessmentYearWithAGradeWith(string uln)
        {
            var summer2021SpecialismAssessSeriesID = SqlQueries.InsertSummer2021SpecialismAssessSeries();
            RegistrationCityAndGuilds.RegWithResitSpecialismAssessmentWithResult(uln, summer2021SpecialismAssessSeriesID);
        }

        [Given(@"I have a registration with Specialism assessment series added for current assessment series with a grade with (.*)")]
        public void GivenIHaveARegistrationWithSpecialismAssessmentSeriesAddedForCurrentAssessmentSeriesWithAGradeWith(string uln)
        {
            var summer2021SpecialismAssessSeriesID = SqlQueries.InsertSummer2021SpecialismAssessSeries();
            RegistrationCityAndGuilds.RegWithSpecialismAssessmentResults(uln);
        }



    }
}
