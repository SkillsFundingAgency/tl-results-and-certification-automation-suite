using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class _5488_TransferResultsBulkuploadStepDefinitions : ResultsDashboardPage
    {
        [Given(@"I have below registration with core and specialism assessments results")]
        public void GivenIHaveBelowRegistrationWithCoreAndSpecialismAssessmentsResults(Table table)
        {
            var row = table.Rows;
            var uln = row[0]["Uln"];
            RegistrationCityAndGuilds.RegWithCoreAndSpecialismAssessmentResults(uln);
        }

        [Then(@"I should see newly transferred Provider in learner detail page with all original Grades")]
        public void ThenIShouldSeeNewlyTransferredProviderInLearnerDetailPageWithAllOriginalGrades(Table table)
        {
            var (provider, core_grade,assessment1_grade, assessment2_grade) = table.CreateInstance<(string Provider, string Core_Grade,string Assessment1_Grade,string Assessment2_Grade)>();
            VerifyLearnerResultPage();
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(provider));
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(core_grade));
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(assessment1_grade));
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(assessment2_grade));
        }
    }
}
