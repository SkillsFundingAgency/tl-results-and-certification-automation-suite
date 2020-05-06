using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewJourney
{
    [Binding]
    public class BackLinkAreTheseDetailsCorrectPageSteps : ManageTLevel
    {
        [Given(@"I selected TLevel and click contiue button")]
        public void GivenISelectedTLevelAndClickContiueButton()
        {
            DbUpdate();
            ClickTlevelLink();
            SelectTlevel(Agriculture);
            ClickContinueBtn();
        }
        
        [Then(@"I should be navigated back to Select T Level to review Page")]
        public void ThenIShouldBeNavigatedBackToSelectTLevelToReviewPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(ReviewTlevel));
            Assert.IsTrue(WebDriver.Title.Equals(SelectTLevelPageTitle));
            Assert.IsTrue(WebDriver.FindElement(PageTitle).Text.Contains(SelectTLevelReviewPageTitle));
        }
    }
}
