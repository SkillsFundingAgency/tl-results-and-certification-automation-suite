using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System.Threading;
using NUnit.Framework;

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
            Assert.AreEqual(PrivacyUrl, WebDriver.Url);
            Assert.AreEqual("Privacy", WebDriver.FindElement(PrivacyTitle).Text);
        }
    }
}
