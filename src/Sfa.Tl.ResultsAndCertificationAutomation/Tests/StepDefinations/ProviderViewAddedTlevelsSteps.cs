using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;
using OpenQA.Selenium;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class ProviderViewAddedTlevelsSteps : ProviderPage
    {
        [Then(@"Added Tlevels should be displayed when i click Manage Tlevels link")]
        public void ThenAddedTlevelsShouldBeDisplayedWhenIClickManageTlevelsLink()
        {
            ManageTlevels();
            Assert.IsTrue(WebDriver.FindElement(By.XPath("//*[@id='main-content']")).Text.Contains(Constants.TlevelAgricluture));
            Assert.IsTrue(WebDriver.FindElement(By.XPath("//*[@id='main-content']")).Text.Contains(Constants.TlevelEducation));
        }
    }
}
