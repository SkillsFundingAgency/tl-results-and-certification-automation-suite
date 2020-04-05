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
            ClickProviderLink();
        }
        
        [Then(@"I shou land into Providers Page")]
        public void ThenIShouLandIntoProvidersPage()
        {
            FindProvider();
            Assert.IsTrue(WebDriver.FindElement(SelectProviderPageHeader).Text.Contains(SearchProviderTxt));
        }
    }
}
