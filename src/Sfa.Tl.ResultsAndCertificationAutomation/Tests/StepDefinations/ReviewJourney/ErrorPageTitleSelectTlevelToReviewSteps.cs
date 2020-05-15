using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewJourney
{
    [Binding]
    public class ErrorPageTitleSelectTlevelToReviewSteps : ManageTLevel
    {
        [When(@"I click on Continue button")]
        public void AndIClickOnContinueButton()
        {
            ClickContinueBtn();
        }

        [Then(@"I should see '(.*)' in page title")]
        public void ThenIShouldSeeInPageTitle(string p0)
        {
            Assert.AreEqual(Constants.ErrorSelectTlevelReview, WebDriver.Title);
            Assert.AreEqual(ReviewTlevel, WebDriver.Url);
        }
    }
}
