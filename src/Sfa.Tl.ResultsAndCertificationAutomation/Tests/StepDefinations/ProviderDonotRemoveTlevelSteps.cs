using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class ProviderDonotRemoveTlevelSteps : ProviderPage
    {
        [When(@"I select No, do not remoce radio option and click on submit")]
        public void WhenISelectNoDoNotRemoceRadioOptionAndClickOnSubmit()
        {
            ClickElement(RemoveTlevelNo);
            Submit();
        }
        
        [Then(@"I should navigate back to Provider's details page and Tlevel should be seen on the list")]
        public void ThenIShouldNavigateBackToProviderSDetailsPageAndTlevelShouldBeSeenOnTheList()
        {
            Assert.AreEqual(ProviderTLevelPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.FindElement(By.XPath("//*[@id='main-content']")).Text.Contains(Constants.TlevelAgricluture));
        }
    }
}
