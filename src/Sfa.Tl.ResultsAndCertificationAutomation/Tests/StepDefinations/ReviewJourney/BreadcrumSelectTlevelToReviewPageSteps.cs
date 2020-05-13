using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewJourney
{
    [Binding]
    public class BreadcrumSelectTlevelToReviewPageSteps : ManageTLevel
    {
        [When(@"I am on the Select Tlevel to Review page")]
        public void WhenIAmOnTheSelectTlevelToReviewPage()
        {
            DbUpdate();
            ClickTlevelLink();
            Assert.IsTrue(WebDriver.Title.Equals(SelectTLevelPageTitle));
            Assert.AreEqual(ReviewTlevel, WebDriver.Url);
        }
    }
}
