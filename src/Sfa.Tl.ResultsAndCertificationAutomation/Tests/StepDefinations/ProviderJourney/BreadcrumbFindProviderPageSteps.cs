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
            Assert.AreEqual(FindProviderPageTitle, WebDriver.Title);
            Assert.AreEqual(FindProviderPageHead, WebDriver.FindElement(PageHeader).Text);
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
            Assert.AreEqual(Constants.DashBoardTitle, WebDriver.Title);
            Assert.AreEqual(Constants.DashBoardHeader, WebDriver.FindElement(PageHeader).Text);
        }
    }
}
