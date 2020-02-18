using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
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
        }
        
        [Then(@"Privacy page should open")]
        public void ThenPrivacyPageShouldOpen()
        {
            PageHelper.WaitForUrl(PrivacyUrl);
            PageHelper.VerifyPageUrl(WebDriver.Url, PrivacyUrl);
            Assert.AreEqual("Privacy", WebDriver.FindElement(PrivacyTitle).Text);
        }
    }
}
