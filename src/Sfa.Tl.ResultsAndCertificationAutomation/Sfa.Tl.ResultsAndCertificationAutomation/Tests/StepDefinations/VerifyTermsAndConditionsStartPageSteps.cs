using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Xunit;
using System.Threading;

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
            Assert.Equal(TermsUrl, WebDriver.Url);
            Assert.Equal("Terms and conditions", WebDriver.FindElement(TCTitle).Text);
        }
    }
}
