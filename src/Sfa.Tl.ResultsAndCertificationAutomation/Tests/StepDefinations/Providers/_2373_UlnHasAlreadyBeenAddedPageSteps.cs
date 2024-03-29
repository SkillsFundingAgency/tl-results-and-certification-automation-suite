﻿using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using TechTalk.SpecFlow;
using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2373_UlnHasAlreadyBeenAddedPageSteps : CrateRegistrationInDb
    {
        private readonly ScenarioContext _scenarioContext;
        public _2373_UlnHasAlreadyBeenAddedPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I have a registration in Db with Industry Placement")]
        public void GivenIHaveARegistrationInDbWithIndustryPlacement()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            CreateDbRegWithIpForLrs(uln, 1);
        }
        
        [Given(@"I enter the Uln")]
        public void GivenIEnterTheUln()
        {
            string uln = _scenarioContext["uln"] as string;
            WebDriver.FindElement(LearnerAddLearnerPage.ULNTextField).Clear();
            WebDriver.FindElement(LearnerAddLearnerPage.ULNTextField).SendKeys(uln);
        }
        
        [Then(@"I should see Uln already been added page")]
        public void ThenIShouldSeeUlnAlreadyBeenAddedPage()
        {
            string uln = _scenarioContext["uln"] as string;
            LearnerAddLearnerPage.VerifyUlnAlreadyAddedPage(uln);
        }
        
        [Then(@"I should see ""(.*)"" button")]
        public void ThenIShouldSeeButton(string p0)
        {
            Assert.AreEqual(true, WebDriver.FindElement(LearnerAddLearnerPage.ContinueButton).Enabled);
        }
        [Then(@"I have deleted LRS records from the database")]
        public void ThenIHaveDeletedLRSRecordsFromTheDatabase()
        {
            var uln = _scenarioContext["uln"] as string;
            DeleteLrsRecordsFromTables(uln);
        }
        [When(@"I click on Continue button on Uln already been added page")]
        public void WhenIClickOnContinueButtonOnUlnAlreadyBeenAddedPage()
        {
            string uln = _scenarioContext["uln"] as string;
            LearnerAddLearnerPage.VerifyUlnAlreadyAddedPage(uln);
            LearnerAddLearnerPage.ClickContinue();
        }

        [Then(@"I should see Learner T Level record page")]
        public void ThenIShouldSeeLearnerTLevelRecordPage()
        {
            LearnerRecordPage_ToBeDeleted.VerifyLearnerRecordPage();
            string uln = _scenarioContext["uln"] as string;
            LearnerRecordPage_ToBeDeleted.VerifyLearnerRecordData(uln);
        }
    }
}
