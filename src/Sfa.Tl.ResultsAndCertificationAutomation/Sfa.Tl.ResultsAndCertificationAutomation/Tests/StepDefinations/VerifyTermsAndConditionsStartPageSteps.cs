using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using NUnit;
using System.Threading;
using NUnit.Framework;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class VerifyTermsAndConditionsStartPageSteps : StartPage
    {
        [Given(@"Terms And Conditions link in start page")]
        public void GivenTermsAndConditionsLinkInStartPage()
        {
            WebDriver.Navigate().GoToUrl(StartPageUrl);
            Assert.True(WebDriver.FindElement(TCLink).Displayed);
        }
        
        [When(@"I click on Terms And Conditions link")]
        public void WhenIClickOnTermsAndConditionsLink()
        {
            WebDriver.FindElement(TCLink).Click();
            Thread.Sleep(2000);
        }
        
        [Then(@"Terms And Conditions page should open")]
        public void ThenTermsAndConditionsPageShouldOpen()
        {
            Assert.AreEqual(TermsUrl, WebDriver.Url);
            Assert.AreEqual("Terms and conditions", WebDriver.FindElement(TCTitle).Text);
        }
    }
}
