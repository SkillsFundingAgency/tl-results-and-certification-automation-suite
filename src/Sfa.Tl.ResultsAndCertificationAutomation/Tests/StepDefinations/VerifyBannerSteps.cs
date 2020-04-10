using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using NUnit.Framework;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class VerifyBannerSteps : StartPage
    {
        [When(@"I looked at page banner")]
        public void WhenILookedAtPageBanner()
        {
            Assert.AreEqual(string.Concat(StartPageUrl,"dashboard"), WebDriver.Url);
        }
        
        [Then(@"I should page Banner information on top of the page")]
        public void ThenIShouldPageBannerInformationOnTopOfThePage()
        {
            PageHelper.WaitForElement(by: TlevelDashboardPage.BannerInfo, 30);
            Assert.True(WebDriver.FindElement(TlevelDashboardPage.BannerInfo).Text.Contains(TlevelDashboardPage.BannerText));
        }
    }
}
