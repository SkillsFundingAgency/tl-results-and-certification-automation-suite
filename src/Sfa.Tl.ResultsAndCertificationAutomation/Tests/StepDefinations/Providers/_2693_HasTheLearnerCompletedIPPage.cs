using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class SpecFlowFeature1Steps : CrateRegistrationInDb
    {

        private readonly ScenarioContext _scenarioContext;
        public SpecFlowFeature1Steps(ScenarioContext scenarioContext)
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
        }
    }
}
