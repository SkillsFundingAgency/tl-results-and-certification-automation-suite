using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using NUnit.Framework;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class VerifyCookiesStartPageSteps : StartPage
    {
        [Given(@"Cookies link in start page")]
        public void GivenCookiesLinkInStartPage()
        {
            WebDriver.Navigate().GoToUrl(StartPageUrl);
            Assert.True(WebDriver.FindElement(CookieLink).Displayed);
        }
        
        [When(@"I click on Cookies link")]
        public void WhenIClickOnCookiesLink()
        {
            WebDriver.FindElement(CookieLink).Click();
        }
        
        [Then(@"Cookies page should open")]
        public void ThenCookiesPageShouldOpen()
        {
            PageHelper.VerifyPageUrl(WebDriver.Url, CookieUrl);
            Assert.AreEqual("Cookie policy", WebDriver.FindElement(CookieTitle).Text);
        }
    }
}
