using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewJourney
{
    [Binding]
    public class ErrorPageTitleAreTheseDetailsCorrectSteps : ManageTLevel
    {
        [When(@"I am on Are these correct page")]
        public void WhenIAmOnAreTheseCorrectPage()
        {
            SelectTlevel(Agriculture);
            ClickContinueBtn();
            ClickContinueBtn();
        }
        
        [Then(@"I shoud see '(.*)' in page title")]
        public void ThenIShoudSeeInPageTitle(string p0)
        {
            Assert.AreEqual(Constants.ErrorAreTheseDetailsCorrect, WebDriver.Title);
            Assert.AreEqual(ConfirmTlevel,WebDriver.Url);
        }
    }
}
