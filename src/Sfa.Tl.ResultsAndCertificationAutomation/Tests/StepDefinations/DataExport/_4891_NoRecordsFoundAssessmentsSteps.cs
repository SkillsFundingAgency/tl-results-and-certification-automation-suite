using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.DataExport;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.DataExport
{
    [Binding]
    public class _4891_NoRecordsFoundAssessmentsSteps : DataExportAssessmentsPage
    {
        [Then(@"No assessment records found page is displayed")]
        public void ThenNoAssessmentRecordsFoundPageIsDisplayed()
        {
            VerifyNoAssessmentsRecordPage();
        }
        
        [Then(@"click on Add assessments will take to assessment page")]
        public void ThenClickOnAddAssessmentsWillTakeToAssessmentPage()
        {
            AddAssessments();
        }
    }
}
