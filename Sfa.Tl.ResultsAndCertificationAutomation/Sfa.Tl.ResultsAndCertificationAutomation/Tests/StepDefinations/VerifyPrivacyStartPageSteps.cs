using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Xunit;
using System.Threading;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class VerifyPrivacyStartPageSteps : StartPage
    {
        [Given(@"Privacy link in start page")]
        public void GivenPrivacyLinkInStartPage()
        {
            WebDriver.Navigate().GoToUrl(StartPageUrl);
            Assert.True(WebDriver.FindElement(PrivacyLink).Displayed);
        }
        
        [When(@"I click on Privacy link")]
        public void WhenIClickOnPrivacyLink()
        {
            WebDriver.FindElement(PrivacyLink).Click();
            Thread.Sleep(2000);
        }
        
        [Then(@"Privacy page should open")]
        public void ThenPrivacyPageShouldOpen()
        {
            Assert.Equal(PrivacyUrl, WebDriver.Url);
            Assert.Equal("Privacy notice", WebDriver.FindElement(PrivacyTitle).Text);
        }
    }
}
