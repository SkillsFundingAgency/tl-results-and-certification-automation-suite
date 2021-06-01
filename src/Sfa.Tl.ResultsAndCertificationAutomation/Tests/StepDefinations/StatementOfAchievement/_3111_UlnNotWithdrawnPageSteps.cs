using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.StatementOfAchievement
{
    [Binding]
    public class _3111_UlnNotWithdrawnPageSteps : CrateRegistrationInDb
    {
        private readonly ScenarioContext _scenarioContext;
        public _3111_UlnNotWithdrawnPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I have a active registration in Bansley provider")]
        public void GivenIHaveAActiveRegistrationInBansleyProvider()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            CreateRegistrationForBarnsley(uln);
        }
        
        [When(@"I enter active Uln and click on Search button")]
        public void WhenIEnterActiveUlnAndClickOnSearchButton()
        {
            var uln = _scenarioContext["uln"] as string;
            RequestSOA_SearchForALearnerPage.EnterULN(uln);
        }
        
        [Then(@"I should see Learner not withdrawn page")]
        public void ThenIShouldSeeLearnerNotWithdrawnPage()
        {
            UlnNotRegisteredPage.VerifyUlnNotWithdrawnPage();
            var uln = _scenarioContext["uln"] as string;
            UlnNotRegisteredPage.VerifyUlnNotWithdrawnContent(uln);
        }
        [Then(@"click on back to home should take me to dashboard page")]
        public void ThenClickOnBackToHomeShouldTakeMeToDashboardPage()
        {
            RequestSOA_SearchForALearnerPage.ClickSearch();
            UlnNotRegisteredPage.VerifyBackToHomeNavigation();
        }

    }
}
