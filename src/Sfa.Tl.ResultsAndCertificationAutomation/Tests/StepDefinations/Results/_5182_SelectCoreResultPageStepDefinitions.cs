using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Results;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class _5182_SelectCoreResultPageStepDefinitions: LearnerResultsPage
    {
        private readonly ScenarioContext _scenarioContext;
        public _5182_SelectCoreResultPageStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I have a registration with no Core and Specialism assessments")]
        public void GivenIHaveARegistrationWithNoCoreAndSpecialismAssessments()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            RegistrationCityAndGuilds.CreateRegistration(uln);
        }

        [When(@"I click '([^']*)' link")]
        public void WhenIClickLink(string linkName)
        {
            LearnerResultsPage.AddAssessmentLink(linkName);
        }

        [Then(@"learner assessment entries page is open")]
        public void ThenLearnerAssessmentEntriesPageIsOpen()
        {
            AssessmentEntriesLearnersAssessmentEntriesPage.VerifyLearnersAssessmentEntriesPage();
        }
        
        [Given(@"I have a registration with core and specialism assessments")]
        public void GivenIHaveARegistrationWithCoreAndSpecialismAssessments()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            RegistrationCityAndGuilds.RegWithCoreAndSpecialismAssessment(uln);
        }

        [Then(@"I should see add result page for Core")]
        public void ThenIShouldSeeAddResultPageForCore()
        {
            AddCoreResultPage.VerifyLearnerCoreResultsPage();
        }
        [Then(@"back link should take me to learner result page")]
        public void ThenBackLinkShouldTakeMeToLearnerResultPage()
        {
            AddCoreResultPage.ClickBackLink();
            VerifyLearnerResultsPage();
        }
        [Then(@"I should see the following error message on Core result page")]
        public void ThenIShouldSeeTheFollowingErrorMessageOnCoreResultPage(Table table)
        {
            AddCoreResultPage.VerifyLearnerCoreResultsErrorPage();
            CommonPage.VerifyValidationMessage(table);
        }
    }
}
