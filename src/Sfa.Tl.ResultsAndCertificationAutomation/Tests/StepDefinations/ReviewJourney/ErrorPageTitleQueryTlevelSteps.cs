using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewJourney
{
    [Binding]
    public class ErrorPageTitleQueryTlevelSteps : ManageTLevel
    {
        [When(@"I am on Query T Level details page")]
        public void WhenIAmOnQueryTLevelDetailsPage()
        {
            SelectTlevel(Agriculture);
            ClickContinueBtn();
            SomethingWrong();
            ClickContinueBtn();
        }
        
        [When(@"I click on Submit button")]
        public void WhenIClickOnSubmitButton()
        {
            ClickElement(QuerySubmit);
        }
        
        [Then(@"I should see ""(.*)"" in page title")]
        public void ThenIShouldSeeInPageTitle(string p0)
        {
            Assert.AreEqual(Constants.ErrorQueryTlevel, WebDriver.Title);
            Assert.AreEqual(QueryTlevel, WebDriver.Url);
        }
    }
}
