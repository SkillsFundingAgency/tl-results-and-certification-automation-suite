using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewJourney
{
    [Binding]
    public class BackLinkQueryTlevelDetailsPageSteps : ManageTLevel
    {
        [Given(@"I select reviewd Tlevel")]
        public void GivenISelectReviewdTlevel()
        {
            DbUpdate();
            ClickTlevelLink();
            SelectTlevel(Agriculture);
            ClickContinueBtn();
            EverythingCorrect();
            ClickContinueBtn();
            ReviewAnotherTlevelLink();
        }
        
        [Given(@"I select View and select something not write")]
        public void GivenISelectViewAndSelectSomethingNotWrite()
        {
            ViewReviewedTlevelLink();
            ClickViewConfirmedTlevel();
            ClickSomethingNotRightLink();
        }
        
        [Then(@"I should navigated back to Tlevel details page")]
        public void ThenIShouldNavigatedBackToTlevelDetailsPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(TlevelDetails));
            Assert.AreEqual(ConfirmedTLevelPageTitle, WebDriver.Title);
            Assert.AreEqual(TlevelDetailsPageHeader, WebDriver.FindElement(PageTitle).Text);
        }
    }
}
