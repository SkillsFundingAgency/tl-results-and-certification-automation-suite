using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class _4712_SpecialismResitsManualStepDefinitions : AssessmentEntriesLearnersDetailsPage
    {
        private readonly ScenarioContext _scenarioContext;
        public _4712_SpecialismResitsManualStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        //[Given(@"I have a registration with Specialism assessment series added for previous assessment year with grades")]
        //public void GivenIHaveARegistrationWithSpecialismAssessmentSeriesAddedForPreviousAssessmentYearWithGrades()
        //{
        //    var uln = UlnHelper.GenerateUln().ToString();
        //    _scenarioContext["uln"] = uln;
        //    var summer2021SpecialismAssessSeriesId = SqlQueries.InsertSummer2021SpecialismAssessSeries();
        //    RegistrationCityAndGuilds.RegWithResitSpecialismAssessmentResult(uln, summer2021SpecialismAssessSeriesId);
        //}

        [When(@"I add assessment for specialism couplets")]
        public void WhenIAddAssessmentForSpecialismCouplets()
        {
            AddAssessmentsforHeatingAndVentilation();
        }


        [Then(@"success message is shown")]
        public void ThenSuccessMessageIsShown()
        {
            AssessmentEntriesAddSpecialismAssessmentEntryPage.VerifySuccessBanner();
        }
    }
}
