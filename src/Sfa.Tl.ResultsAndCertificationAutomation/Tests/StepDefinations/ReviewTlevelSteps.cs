using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class ReviewTlevelSteps : ManageTLevel
    {
        [When(@"I click on TLevel link")]
        public void WhenIClickOnTLevelLink()
        {
            DbUpdate();
            ClickTlevelLink();
        }
        
        [Then(@"I should see Select Tlevel Review Page")]
        public void ThenIShouldSeeSelectTlevelReviewPage()
        {
            Assert.AreEqual(ReviewTlevel, WebDriver.Url);
            Assert.IsTrue(WebDriver.Title.Equals(SelectTLevelPageTitle));
            Assert.IsTrue(WebDriver.FindElement(PageTitle).Text.Contains("Select a T Level to review"));
        }
    }
}
