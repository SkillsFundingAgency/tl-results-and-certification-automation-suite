using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ProviderJourney
{
    [Binding]
    public class BackLinkSelectProviderPageSteps : ProviderPage
    {
        [Given(@"click on Provider link in dashboard page")]
        public void GivenClickOnProviderLinkInDashboardPage()
        {
            ClickProviderLink();
            DeleteTlevelFromDB();
        }
        
        [Given(@"I serch the Provider")]
        public void GivenISerchTheProvider()
        {
            FindProvider();
            Assert.IsTrue(WebDriver.Title.Equals(SelectProvidersTlevelPageTitle));
            Assert.IsTrue(WebDriver.Url.Contains(SelectProviderUrl));
        }
        
        [When(@"I click on Back link")]
        public void WhenIClickOnBackLink()
        {
            ClickElement(BackLink);
        }
        
        [Then(@"I should be navigated back to Find a Provider page")]
        public void ThenIShouldBeNavigatedBackToFindAProviderPage()
        {
            Assert.IsTrue(WebDriver.Title.Equals(FindProviderPageTitle));
            Assert.IsTrue(WebDriver.Url.Contains(ProviderUrl));
            Assert.IsTrue(WebDriver.FindElement(PageHeader).Text.Contains(FindProviderPageHead));
        }
    }
}
