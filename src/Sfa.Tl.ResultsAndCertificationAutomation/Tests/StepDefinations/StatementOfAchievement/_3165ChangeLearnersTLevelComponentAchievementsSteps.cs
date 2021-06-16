using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.StatementOfAchievement
{
    [Binding]
    public class TLRC_3165StatementOfAchievement_ChangeLearnerST_LevelComponentAchievementsSteps
    {

        private readonly ScenarioContext _scenarioContext;
        public TLRC_3165StatementOfAchievement_ChangeLearnerST_LevelComponentAchievementsSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [Given(@"I click on the Change link next to the Learner’s T Level component achievements")]
        public void GivenIClickOnTheChangeLinkNextForLearnerSTLevelComponentAchievements()
        {
            SOACheckAndSubmitPage.ClickTLevelComponentAchievement_ChangeLink();
        }
        
        [Then(@"I am shown the Change learner’s T Level component achievements page")]
        public void ThenIAmShownTheChangeLearnerSTLevelComponentAchievementsPage()
        {
            SOAChangeLearnersTLevelComponentAchievementsPage.VerifySOAChangeLearnerComponentsPage();
        }
        
        [Then(@"I click the Back link on the Statement of Achievement - Change Learner's T-Level Component Achievements page")]
        public void ThenIClickTheBackLinkOnTheStatementOfAchievement_ChangeLearnerST_LevelComponentAchievementsPage()
        {
            SOAChangeLearnersTLevelComponentAchievementsPage.ClickBackLink(); ;
        }

        [Given(@"I click the Manage Learner TLevel Record button on the Statement of Achievement - Change Learner's T-Level Component Achievements page")]
        [Then(@"I click the Manage Learner TLevel Record button on the Statement of Achievement - Change Learner's T-Level Component Achievements page")]
        public void ThenIClickTheManageLearnerTLevelRecordButtonOnTheStatementOfAchievement_ChangeLearnerST_LevelComponentAchievementsPage()
        {
            SOAChangeLearnersTLevelComponentAchievementsPage.ClickManageLearnerTLevelRecordBtn();
        }

        [Then(@"the Learner Records Page is displayed with Eng and Maths status '(.*)' and IP completion status as '(.*)'")]
        public void ThenTheLearnerRecordsPageIsDisplayedWithEngAndMathsStatusAndIPCompletionStatusAs(string EMStatus, string IPStatus)
        {
            var uln = _scenarioContext["uln"] as string;
            LearnerRecordPage.VerifyLearnerRecordData(uln);
            LearnerRecordPage.VerifyEMAndIPStatus(EMStatus, IPStatus);
        }


    }
}
