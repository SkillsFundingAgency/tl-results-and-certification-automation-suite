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
            Assert.AreEqual(StartPage.CookiePageTitle, WebDriver.Title);
            Assert.AreEqual(StartPage.CookieUrl, WebDriver.Url);
            Assert.AreEqual("Cookies on Manage T Level results", WebDriver.FindElement(StartPage.TlevelCookies).Text);
        }
    }
}
