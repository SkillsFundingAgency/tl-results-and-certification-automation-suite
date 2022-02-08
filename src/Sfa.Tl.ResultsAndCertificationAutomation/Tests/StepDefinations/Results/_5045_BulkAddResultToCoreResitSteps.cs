using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Results;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class _5045_BulkAddResultToCoreResitSteps : LearnerResultsPage
    {

        [Given(@"I have a registration with resit core assessment series for (.*)")]
        public void GivenIHaveARegistrationWithResitCoreAssessmentSeriesFor(string ULN)
        {
            RegistrationCityAndGuilds.RegWithResitCoreAssessment(ULN);
        }


        [Given(@"I navigate to the result details page for (.*)")]
        public void GivenINavigateToTheResultDetailsPageFor(string ULN)
        {
            ResultsDashboardPage.ClickResultsLink();
            ResultsDashboardPage.searchResult(ULN);
            ResultsLearnersResultsPage.VerifyLearnerResultPage();
        }

        [Then(@"The grade for Summer (.*) is unaffected and remains ""([^""]*)""")]
        [Given(@"I verify the original core grade for Summer (.*) is ""([^""]*)""")]
        public void GivenIVerifyTheOriginalCoreGradeForSummerIs(int p0, string Grade)
        {
            ResultsLearnersResultsPage.VerifySummer2021CoreGrade(Grade);
        }

        [Then(@"the core grade for Autumn (.*) is not added to the registration")]
        [Given(@"the core grade for Autumn (.*) is not added to the registration")]
        public void GivenTheCoreGradeForAutumnIsNotAdded(int p0)
        {
            ResultsLearnersResultsPage.VerifyAutumn2021CoreGradeNotEntered();
        }


        [When(@"I upload the Results file with a grade for Autumn (.*)")]
        public void WhenIUploadTheResultsFileWithAGradeForAutumn(string ULN)
        {
            ResultsLearnersResultsPage.ClickResultsBreadcrumb();
            WebDriver.FindElement(By.XPath("//*[contains(text(),'Upload multiple results')]")).Click();
            AssessmentEntriesPage.UploadFile(RegistrationsPage.ChooseFile, "TLRC5045_ResultUploadSuccess.csv");
            CommonPage.ClickButtonByLabel("Upload");
           
        }

        [When(@"I navigate back to the result details page for (.*)")]
        public void WhenINavigateBackToTheResultDetailsPageFor(string ULN)
        {
            ResultDashboardSteps.ClickBacktoHomeBtn();
            ResultsDashboardPage.ClickResultsLink();
            ResultsDashboardPage.searchResult(ULN);
            ResultsLearnersResultsPage.VerifyLearnerResultPage();
        }

        [Then(@"the grade for Autumn (.*) is a ""([^""]*)""")]
        public void ThenTheGradeForAutumnIsA(int p0, string Grade)
        {
            ResultsLearnersResultsPage.VerifyAutumn2021CoreGrade(Grade);
        }

        [When(@"I upload the Results file without a grade for Autumn (.*)")]
        public void WhenIUploadTheResultsFileWithoutAGradeForAutumn(int p0)
        {
            ResultsLearnersResultsPage.ClickResultsBreadcrumb();
            WebDriver.FindElement(By.XPath("//*[contains(text(),'Upload multiple results')]")).Click();
            AssessmentEntriesPage.UploadFile(RegistrationsPage.ChooseFile, "TLRC5045_ResultUploadSuccessRemoveGrade.csv");
            CommonPage.ClickButtonByLabel("Upload");
        }





    }
}
