using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2693HasLearnerCompletedIPPage : CrateRegistrationInDb
    {

        private readonly ScenarioContext _scenarioContext;
        public _2693HasLearnerCompletedIPPage(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I have a created a registration with LRS qualifications")]
        public void GivenIHaveACreatedARegistrationWithLRSQualifications()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            CreateDbRegistationForLrs(uln);
        }
        
        [When(@"I enter the ULN")]
        public void WhenIEnterTheULN()
        {
            var uln = _scenarioContext["uln"] as string;
            WebDriver.FindElement(By.Id("enteruln")).Clear();
            WebDriver.FindElement(By.Id("enteruln")).SendKeys(uln);
        }
        
        [Then(@"I expect to see the learner completed Industry Placement page")]
        public void ThenIExpectToSeeTheLearnerCompletedIndustryPlacementPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains("has-learner-completed-industry-placement"));
            var uln = _scenarioContext["uln"] as string;
            LearnerHasTheLearnerCompletedIPPage.VerifyLearnerHasTheLearnerCompletedIPPage(uln);
        }
        [Then(@"the radio buttons are not populated on entry to the Has Learner Completed Industry Placement page")]
        public void ThenTheRadioButtonsAreNotPopulatedOnEntryToTheHasLearnerCompletedIndustryPlacementPage()
        {
            LearnerHasTheLearnerCompletedIPPage.VerifyRadioButtonsNotSelected();
        }

        [Then(@"I am shown an error message on the Has Learner Completed Industry Placement page stating ""(.*)""")]
        public void ThenIAmShownAnErrorMessageOnTheHasLearnerCompletedIndustryPlacementPageStating(string ErrorMessage)
        {
            LearnerHasTheLearnerCompletedIPPage.VerifyErrorMessage(ErrorMessage);
        }

        [Then(@"the Enter ULN Page is displayed when i click on Back link")]
        public void ThenTheEnterULNPageIsDisplayedWhenIClickOnBacklink()
        {
            Pages.CommonUlnDbSteps.ClickBackLink();
            Pages.CommonUlnDbSteps.VerifyAddANewLearnerRecordPage();
        }

        [When(@"I click on the ""(.*)"" link on the Has Learner Completed Industry Placement page")]
        public void WhenIClickOnTheLinkOnTheHasLearnerCompletedIndustryPlacementPage(string p0)
        {
            LearnerHasTheLearnerCompletedIPPage.ClickBackLink();
        }

        [Then(@"the radio buttons are no populated on entry to the Has Learner Completed Industry Placement page")]
        public void ThenTheRadioButtonsAreNoPopulatedOnEntryToTheHasLearnerCompletedIndustryPlacementPage()
        {
            LearnerHasTheLearnerCompletedIPPage.VerifyRadioButtonsNotSelected();
        }
    }
}
