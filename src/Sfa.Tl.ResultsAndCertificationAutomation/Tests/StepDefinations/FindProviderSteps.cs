using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class FindProviderSteps : ProviderPage
    {
        [When(@"I click on Provider link in the dashboard")]
        public void WhenIClickOnProviderLinkInTheDashboard()
        {
            DeleteTlevelFromDB();
            ClickProviderLink();
            Assert.IsTrue(WebDriver.Title.Equals(FindProviderPageTitle));
            Assert.AreEqual(ProviderUrl, WebDriver.Url);
            Assert.IsTrue(WebDriver.FindElement(PageHeader).Text.Contains(FindProviderPageHead));
        }
        
        [Then(@"I shou land into Providers Page")]
        public void ThenIShouLandIntoProvidersPage()
        {
            FindProvider();
            Assert.IsTrue(WebDriver.Title.Equals(SelectProvidersTlevelPageTitle));
            Assert.IsTrue(WebDriver.Url.Contains(SelectProviderUrl));
            //Assert.IsTrue(WebDriver.FindElement(SelectProviderPageHeader).Text.Contains(SearchProviderTxt));
        }
    }
}
