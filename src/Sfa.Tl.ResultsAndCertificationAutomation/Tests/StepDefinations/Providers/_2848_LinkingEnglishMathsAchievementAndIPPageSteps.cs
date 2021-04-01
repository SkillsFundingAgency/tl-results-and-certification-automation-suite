using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2848_LinkingEnglishMathsAchievementAndIPPageSteps : CrateRegistrationInDb
    {

        private readonly ScenarioContext _scenarioContext;
        public _2848_LinkingEnglishMathsAchievementAndIPPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I have a created a registration without LRS data")]
        public void GivenIHaveACreatedARegistrationWithoutLRSData()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;

            CreateDbRegistationForNonLRS(uln);
        }
        
        [Given(@"I navigate to the '(.*)' page")]
        public void GivenINavigateToThePage(string p0)
        {
            TlevelDashboardPage.ClickManageLearnerRecordsLink();
            LearnerManageLearnerRecordsPage.ClickAddANewLearnerRecordLink();

            var uln = _scenarioContext["uln"] as string;
            WebDriver.FindElement(By.Id("enteruln")).Clear();
            Pages.CommonUlnDbSteps.EnterULN(uln);
            LearnerAchievedMinStandardForEnglishAndMathsPage.VerifyMinStandardAchievedForEnglishMathsPage();
            
        }

        [Given(@"I select ""(.*)"" radio button on '(.*)' page and press Continue")]
        public void GivenISelectRadioButtonOnPageAndPressContinue(string RadioButton, string p1)
        {
            LearnerAchievedMinStandardForEnglishAndMathsPage.ClickRadioButton(RadioButton);
            //LearnerAchievedMinStandardForEnglishAndMathsPage.ClickContinue();
        }
        
        [When(@"I select ""(.*)"" radio button on '(.*)' page and press Continue")]
        public void WhenISelectRadioButtonOnPageAndPressContinue(string RadioButton, string p1)
        {
            LearnerAchievedMinStandardForEnglishAndMathsPage.ClickRadioButton(RadioButton);
        }
        
        [Then(@"when I press the back link on the '(.*)' page")]
        public void ThenWhenIPressTheBackLinkOnThePage(string p0)
        {
            LearnerHasTheLearnerCompletedIPPage.ClickBackLink();
        }
        
        [Then(@"the '(.*)' page is displayed with ""(.*)"" still selected")]
        public void ThenThePageIsDisplayedWithStillSelected(string RadioButton1, string RadioButton)
        {
            LearnerAchievedMinStandardForEnglishAndMathsPage.VerifyRadioButtonsSelected(RadioButton);
        }
    }
}
