using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class TLRC1879_AssessmentLearnerEntryPageSteps : CrateRegistrationInDb
    {
        private readonly ScenarioContext _scenarioContext;
        public TLRC1879_AssessmentLearnerEntryPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I have a registration without assessment and result")]
        public void GivenIHaveARegistrationWithoutAssessmentAndResult()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            CreateDbRegistation(uln);
        }

        [When(@"I search for the learner assessment")]
        public void WhenISearchForTheLearnerAssessment()
        {
            var uln = _scenarioContext["uln"] as string;
            AssessmentEntriesPage.SearchAssessmentEntry(uln);
        }
        
        [Then(@"I should see Learner details in the page")]
        public void ThenIShouldSeeLearnerDetailsInThePage()
        {
            var uln = _scenarioContext["uln"] as string;
            AssessmentEntriesLearnersAssessmentEntriesPage.VerifyLearnersAssessmentEntriesPage();
            AssessmentEntriesLearnersAssessmentEntriesPage.VerifyDataCreatedFromDb(uln);
            //AssessmentEntriesLearnersAssessmentEntriesPage.VerifyCoreAndSpecialismText();
        }
        
        [Then(@"Core assessment entry should be ""(.*)""")]
        public void ThenCoreAssessmentEntryShouldBe(string text)
        {
            Assert.AreEqual(text, WebDriver.FindElement(AssessmentEntriesLearnersAssessmentEntriesPage.CoreAssessmentDetails).Text);
        }
        
        [Then(@"""(.*)"" link should be displayed")]
        public void ThenLinkShouldBeDisplayed(string linkText)
        {
            Assert.IsTrue(WebDriver.FindElement(AssessmentEntriesLearnersAssessmentEntriesPage.AddRemoveEntryLink).Text.Contains(linkText));
        }
    }
}
