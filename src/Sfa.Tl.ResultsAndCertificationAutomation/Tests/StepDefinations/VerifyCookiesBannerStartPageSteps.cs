using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class VerifyCookiesBannerStartPageSteps : TlevelDashboardPage
    {
        [Given(@"Tlevel Start page")]
        public void GivenTlevelStartPage()
        {
            WebDriver.Navigate().GoToUrl(StartPageUrl);
        }
        
        [When(@"i click on View Cookie Policy button in the banner")]
        public void WhenIClickOnViewCookiePolicyButtonInTheBanner()
        {
            ViewCookieBanner();
        }
        
        [Then(@"Cookie policy page should open")]
        public void ThenCookiePolicyPageShouldOpen()
        {
            Assert.AreEqual(CookieUrl, WebDriver.Url);
            Assert.AreEqual("Cookie policy", WebDriver.FindElement(PageHeader).Text);
        }
    }
}
