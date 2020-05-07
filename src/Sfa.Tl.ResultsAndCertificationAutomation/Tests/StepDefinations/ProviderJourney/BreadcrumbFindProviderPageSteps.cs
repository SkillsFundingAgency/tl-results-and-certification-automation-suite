using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ProviderJourney
{
    [Binding]
    public class BreadcrumbFindProviderPageSteps : ProviderPage
    {
        [When(@"I am Find a Provider page")]
        public void WhenIAmFindAProviderPage()
        {
            Assert.AreEqual(ProviderUrl, WebDriver.Url);
            Assert.IsTrue(WebDriver.Title.Equals(FindProviderPageTitle));
            Assert.IsTrue(WebDriver.FindElement(PageHeader).Text.Contains(FindProviderPageHead));
        }
        
        [When(@"I click on Home link")]
        public void WhenIClickOnHomeLink()
        {
            ClickElement(BcHome);
        }
        
        [Then(@"I should be navated back to dashboard")]
        public void ThenIShouldBeNavatedBackToDashboard()
        {
            Assert.AreEqual(TlevelDashboardPage.DashboardUrl, WebDriver.Url);
            Assert.IsTrue(WebDriver.Title.Equals(Constants.DashBoardTitle));
            Assert.IsTrue(WebDriver.FindElement(PageHeader).Text.Contains(Constants.DashBoardHeader));
        }
    }
}
