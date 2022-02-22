using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class _4712_SpecialismResitsStepDefinitions : ElementHelper
    {
        //[Given(@"I have a registration with Specialism assessment series added for previous assessment year with grade")]
        //public void GivenIHaveARegistrationWithSpecialismAssessmentSeriesAddedForPreviousAssessmentYearWithGrade(Table table)
        //{
        //    var row = table.Rows;
        //    var uln = row[0]["Uln"];
        //    var summer2021SpecialismAssessSeriesId = SqlQueries.InsertSummer2021SpecialismAssessSeries();
        //    RegistrationCityAndGuilds.RegWithResitSpecialismAssessmentResult(uln, summer2021SpecialismAssessSeriesId);
        //}

        [When(@"I upload assessment ""([^""]*)"" file")]
        public void WhenIUploadAssessmentFile(string file)
        {
            UploadFile(RegistrationsPage.ChooseFile, file);
            ClickElement(RegistrationsPage.SubmitFileBtn);
        }

        [Then(@"assessment upload success message will be shown")]
        public void ThenAssessmentUploadSuccessMessageWillBeShown()
        {
            AssessmentEntriesPage.VerifyAssessmentUploadSuccessPage();
        }
    }
}
