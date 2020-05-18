using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ProviderJourney
{
    [Binding]
    public class ErrorPageTitleFindProviderSteps : ProviderPage
    {
        [Given(@"I am on Find Provider page")]
        public void GivenIAmOnFindProviderPage()
        {
            ClickProviderLink();
        }
        
        [Then(@"I should see Error: Find a provider page - Manage T Level results - GOV\.UK in page title")]
        public void ThenIShouldSeeErrorFindAProviderPage_ManageTLevelResults_GOV_UKInPageTitle()
        {
            Assert.AreEqual(Constants.ErrorFindProvider, WebDriver.Title);
            Assert.AreEqual(ProviderUrl, WebDriver.Url);
        }
    }
}
