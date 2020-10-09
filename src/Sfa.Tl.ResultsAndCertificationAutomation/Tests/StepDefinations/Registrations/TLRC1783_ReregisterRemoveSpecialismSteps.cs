using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1783_ReregisterRemoveSpecialismSteps : ReregisterCheckAndSubmitPage
    {
        [Then(@"I should not see specialism on check and submit page")]
        public void ThenIShouldNotSeeSpecialismOnCheckAndSubmitPage()
        {
            Assert.IsFalse(WebDriver.FindElement(By.Id("main-content")).Text.Contains(ExpectedSpecialism));
        }
    }
}
