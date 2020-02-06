using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class ErrorPages500Steps : StartPage
    {
        [Given(@"I have Internal Server Error Url in the browser")]
        public void GivenIHaveInternalServerErrorUrlInTheBrowser()
        {
            WebDriver.Navigate().GoToUrl(Error500);
        }
        
        [When(@"I loocked at page content")]
        public void WhenILoockedAtPageContent()
        {
            PageHelper.WaitForPageElementBy(5, PageHeader);
        }
        
        [Then(@"I should see an error")]
        public void ThenIShouldSeeAnError()
        {
            Assert.AreEqual(Error500, WebDriver.Url);
            Assert.AreEqual(Constants.Error500, WebDriver.FindElement(PageHeader).Text);
        }
    }
}
