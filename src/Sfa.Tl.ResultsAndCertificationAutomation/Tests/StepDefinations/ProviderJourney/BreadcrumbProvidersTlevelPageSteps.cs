using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ProviderJourney
{
    [Binding]
    public class BreadcrumbProvidersTlevelPageSteps : ProviderPage
    {
        [When(@"I am on The Provider's TLevel page")]
        public void WhenIAmOnTheProviderSTLevelPage()
        {
            DeleteTlevelFromDB();
            FindProvider();
            SelectTlevel(Agriculture);
            Submit();
            ManageTlevels();
            Assert.IsTrue(WebDriver.Title.Equals(ProviderTLevelPageTitle));
            Assert.IsTrue(WebDriver.Url.Contains(ProviderTlevelUrl));
        }
        
        [When(@"I click on Your Provider link")]
        public void WhenIClickOnYourProviderLink()
        {
            ClickElement(BcYourProvider);
        }
        
        [Then(@"I should be navigated back to Your providers page")]
        public void ThenIShouldBeNavigatedBackToYourProvidersPage()
        {
            Assert.IsTrue(WebDriver.Title.Equals(YourProviderTitle));
            Assert.IsTrue(WebDriver.Url.Contains(YourProviderUrl));
            Assert.IsTrue(WebDriver.FindElement(PageHeader).Text.Contains(YourProviderHeader));
        }
    }
}
