using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ProviderJourney
{
    [Binding]
    public class BackLinkAddTlevelPageSteps : ProviderPage
    {
        [Given(@"I am on the Add Tlevel Page")]
        public void GivenIAmOnTheAddTlevelPage()
        {
            DeleteTlevelFromDB();
            ClickProviderLink();
            FindProvider();
            SelectTlevel(Agriculture);
            Submit();
            ManageTlevels();
            ClickElement(AddAnotherTlevelBtn);
        }
        
        [Then(@"I should be navigated back to Providers Tlevel Page")]
        public void ThenIShouldBeNavigatedBackToProvidersTlevelPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(ProviderTlevelUrl));
            Assert.IsTrue(WebDriver.FindElement(PageHeader).Text.Contains(ProviderTLevelPageHeader));
            Assert.IsTrue(WebDriver.Title.Equals(ProviderTLevelPageTitle));
        }
    }
}
