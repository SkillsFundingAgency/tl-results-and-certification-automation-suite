using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class ReviewSingleTlevelSteps : ManageTLevel
    {
        [When(@"I select a single Tlevel and click continue")]
        public void WhenISelectASingleTlevelAndClickContinue()
        {
            DbUpdate();
            ClickTlevelLink();
            Assert.AreEqual(SelectTLevelPageTitle, WebDriver.Title);
            Assert.AreEqual(ReviewTlevel, WebDriver.Url);
            SelectTlevel(Agriculture);
            ClickContinueBtn();
        }
        
        [When(@"select Everything correct and click continue")]
        public void WhenSelectEverythingCorrectAndClickContinue()
        {
            Assert.AreEqual(AreDetailsCorrectPageTitle, WebDriver.Title);
            EverythingCorrect();
            ClickContinueBtn();
        }
        
        [Then(@"I should see TLevel Confirmation message")]
        public void ThenIShouldSeeTLevelConfirmationMessage()
        {
            Assert.AreEqual(TlevelConfirmantionPageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.FindElement(PageTitle).Text.Contains(TlevelConfirmantionMsg));
            Assert.IsTrue(WebDriver.FindElement(PageContent).Text.Contains(Constants.TlevelTitleAgricluture));
        }
    }
}
