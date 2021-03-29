using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Features.Providers
{
    [Binding]
    public class _2721_LearnerCheckAndSubmitPageSteps : CrateRegistrationInDb

    {

        private readonly ScenarioContext _scenarioContext;
        public _2721_LearnerCheckAndSubmitPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I have a created a registration with LRS qualifications \(Maths achieved and English not Achieved\)")]
        public void GivenIHaveACreatedARegistrationWithLRSQualificationsMathsAchievedAndEnglishNotAchieved()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;

            CreateDbRegistationForLrsMathsAEnglishNA(uln);
        }


        
        [Given(@"I navigate to the Has the learner completed the IP page")]
        public void GivenINavigateToTheHasTheLearnerCompletedTheIPPage()
        {
            TlevelDashboardPage.ClickManageLearnerRecordsLink();
            LearnerManageLearnerRecordsPage.ClickAddANewLearnerRecordLink();

            var uln = _scenarioContext["uln"] as string;
            WebDriver.FindElement(By.Id("enteruln")).Clear();
            Pages.CommonUlnDbSteps.EnterULN(uln);
        }
        
        [Given(@"I select ""(.*)"" radio button and press Continue")]
        public void GivenISelectRadioButtonAndPressContinue(string RadioButton)
        {
            LearnerHasTheLearnerCompletedIPPage.ClickRadioButton(RadioButton);
        }
        
        [Given(@"I have a created a registration with LRS qualifications \(Maths not achieved and English achieved\)")]
        public void GivenIHaveACreatedARegistrationWithLRSQualificationsMathsNotAchievedAndEnglishAchieved()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;

            CreateDbRegistationForLrsMathsNAEnglishA(uln);
        }
        
        [Given(@"I have a created a registration with LRS qualifications \(Maths and English achieved\)")]
        public void GivenIHaveACreatedARegistrationWithLRSQualificationsMathsAndEnglishAchieved()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;

            CreateDbRegistationForLrsWithEMAcheived(uln);
        }
        
        [Then(@"I am shown the Check and submit page for the Add a new learner journey")]
        public void ThenIAmShownTheCheckAndSubmitPageForTheAddANewLearnerJourney()
        {
            var uln = _scenarioContext["uln"] as string;
            LearnerCheckAndSubmitPage.VerifyProviderCheckAndSubmitPage();
            LearnerCheckAndSubmitPage.VerifyProviderCheckAndSubmitContent(uln);
            LearnerCheckAndSubmitPage.VerifyProviderCheckAndSubmitLinks();

        }
        
        [Then(@"the English and maths minimum standard status shows ""(.*)""")]
        public void ThenTheEnglishAndMathsMinimumStandardStatusShows(string Status)
        {
            LearnerCheckAndSubmitPage.VerifyEnglishAndMathsStatus(Status);
        }
        
        [Then(@"the Industry placement status shows ""(.*)""")]
        public void ThenTheIndustryPlacementStatusShows(string Status)
        {
            LearnerCheckAndSubmitPage.VerifyIPStatus(Status);
        }

        [Given(@"I click the back link on the Learner Check and Submit page")]
        public void GivenIClickTheBackLinkOnTheLearnerCheckAndSubmitPage()
        {
            LearnerCheckAndSubmitPage.ClickBackLink();
        }

    }
}
