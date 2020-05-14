using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class QueriedFromReviewTlevelSteps : ManageTLevel
    {
        [When(@"I click on View reviewed TLevel link")]
        public void WhenIClickOnViewReviewedTLevelLink()
        {
            SelectTlevel(Agriculture);
            ClickContinueBtn();
            EverythingCorrect();
            ClickContinueBtn();
            ReviewAnotherTlevelLink();
            ViewReviewedTlevelLink();
            ClickViewConfirmedTlevel();
        }
        [When(@"I select Something Wrong and click continue")]
        public void WhenISelectSomethingWrongAndClickContinue()
        {
            ClickSomethingNotRightLink();
            QueryTlevelText();
        }
        
        [Then(@"the Tlevel should move from Reviewed to Queried status")]
        public void ThenTheTlevelShouldMoveFromReviewedToQueriedStatus()
        {
            Assert.AreEqual(QueryConfirmPageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.FindElement(PageTitle).Text.Contains(TlevelQueryMsg));
            Assert.IsTrue(WebDriver.FindElement(PageContent).Text.Contains(Constants.TlevelTitleAgricluture));
            ReviewAnotherTlevelLink();
            ViewReviewedTlevelLink();
            Assert.AreEqual(VerifyTLevelPageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.FindElement(PageContent).Text.Contains(Constants.TlevelTitleAgricluture));
        }
    }
}
