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
            Assert.AreEqual(YourProviderTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(YourProviderUrl));
            Assert.AreEqual(YourProviderHeader, WebDriver.FindElement(PageHeader).Text);
        }
    }
}
