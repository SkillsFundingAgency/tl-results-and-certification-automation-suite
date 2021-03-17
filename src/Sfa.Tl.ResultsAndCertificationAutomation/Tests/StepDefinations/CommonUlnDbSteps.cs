using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class CommonUlnDbSteps : ElementHelper
    {
        private readonly ScenarioContext _scenarioContext;
        public CommonUlnDbSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I have an Uln not existed in DB")]
        public void GivenIHaveAnUlnNotExistedInDB()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
        }

        [Given(@"I enter non existed Uln")]
        [When(@"I enter non existed Uln")]
        public void WhenIEnterNonExistedUln()
        {
            var uln = _scenarioContext["uln"] as string;
            WebDriver.FindElement(By.Id("enteruln")).Clear();
            WebDriver.FindElement(By.Id("enteruln")).SendKeys(uln);
        }

    }
}
