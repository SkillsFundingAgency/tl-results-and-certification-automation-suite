using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ProviderJourney
{
    [Binding]
    public class ProviderLandingPageSteps : ProviderPage
    {
        [Given(@"Tlevel is already added to the provider")]
        public void GivenTlevelIsAlreadyAddedToTheProvider()
        {
            DeleteTlevelFromDB();
            ClickProviderLink();
            FindProvider();
            SelectTlevel(Legal);
            Submit();
            ClickElement(FindAnotherProvider);
        }

        [When(@"I search the Provider")]
        public void WhenISearchTheProvider()
        {
            FindProvider();
        }
        
        [Then(@"I should be landed on Provider Tlevel Page")]
        public void ThenIShouldBeLandedOnProviderTlevelPage()
        {
            Assert.AreEqual(ProviderTLevelPageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(ProviderTlevelUrl));
            Assert.IsTrue(WebDriver.FindElement(PageHeader).Text.Contains(ProviderTLevelPageHeader));
        }
    }
}
