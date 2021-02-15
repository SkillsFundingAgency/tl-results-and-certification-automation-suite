using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class ResultsTransferBulkUploadSteps : ResultsDashboardPage
    {
        [Given(@"I uploaded following files")]
        public void GivenIUploadedFollowingFiles(Table table)
        {
            SqlQueries.DeleteFromRegistrationTables();
            var (Registration, Assessment, Result) = table.CreateInstance<(string Registration, string Assessment, string Result)>();
            RegistrationsPage.ClickRegLink();
            ClickElement(RegistrationsPage.UploadRegistationLink);
            UploadFile(RegistrationsPage.ChooseFile, Registration);
            ClickElement(RegistrationsPage.SubmitFileBtn);
            ClickElement(TlevelDashboardPage.DashboardHeadLink);
            ClickElement(AssessmentEntriesPage.AssessmentEntriesLink);
            ClickElement(AssessmentEntriesPage.UploadAssessmentEntryLink);
            UploadFile(RegistrationsPage.ChooseFile, Assessment);
            ClickElement(RegistrationsPage.SubmitFileBtn);
            ClickElement(TlevelDashboardPage.DashboardHeadLink);
            ClickResultsLink();
            WebDriver.FindElement(UploadResultLink).Click();
            UploadFile(RegistrationsPage.ChooseFile, Result);
            ClickElement(RegistrationsPage.SubmitFileBtn);
            ClickElement(TlevelDashboardPage.DashboardHeadLink);
        }

        [Given(@"I am on Registration upload page")]
        public void GivenIAmOnRegistrationUploadPage()
        {
            RegistrationsPage.ClickRegLink();
            ClickElement(RegistrationsPage.UploadRegistationLink);
        }
        [Given(@"I am on results dashboard page")]
        public void GivenIAmOnResultsDashboardPage()
        {
            ClickElement(TlevelDashboardPage.DashboardHeadLink);
            ClickResultsLink();
        }

        [When(@"I search the learner result")]
        public void WhenISearchTheLearnerResult(Table table)
        {
            var row = table.Rows;
            var uln = row[0]["Uln"];
            searchResult(uln);
        }

        [Then(@"I should see newly transferred Provider in learner detail page with original Grade")]
        public void ThenIShouldSeeNewlyTransferredProviderInLearnerDetailPageWithOriginalGrade(Table table)
        {
            var (provider, grade) = table.CreateInstance<(string Provider, string Grade)>();
            VerifyLearnerResultPage();
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(provider));
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(grade));
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
