using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System.Threading;
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
            Thread.Sleep(2000);
        }
        
        [Then(@"Cookies page should open")]
        public void ThenCookiesPageShouldOpen()
        {
            Assert.AreEqual(CookieUrl,WebDriver.Url);
            Assert.AreEqual("Cookies", WebDriver.FindElement(CookieTitle).Text);
        }
    }
}
