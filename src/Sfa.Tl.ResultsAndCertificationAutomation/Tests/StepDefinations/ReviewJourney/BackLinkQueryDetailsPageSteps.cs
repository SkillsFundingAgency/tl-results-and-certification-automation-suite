using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewJourney
{
    [Binding]
    public class BackLinkQueryDetailsPageSteps : ManageTLevel
    {
        [Given(@"I select Tlevel to query page")]
        public void GivenISelectTlevelToQueryPage()
        {
            DbUpdate();
            ClickTlevelLink();
            SelectTlevel(Agriculture);
            ClickContinueBtn();
            SomethingWrong();
            ClickContinueBtn();
        }
        
        [Then(@"I should be navigated back to Are these details correct page")]
        public void ThenIShouldBeNavigatedBackToAreTheseDetailsCorrectPage()
        {
            Assert.IsTrue(WebDriver.Title.Equals(VerifyTLevelPageTitle));
            Assert.IsTrue(WebDriver.Url.Contains(VerifyTlevel));
        }
    }
}
