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
            Assert.IsTrue(WebDriver.Title.Equals(SelectTLevelPageTitle));
            Assert.AreEqual(ReviewTlevel, WebDriver.Url);
            SelectTlevel(Agriculture);
            ClickContinueBtn();
        }
        
        [When(@"select Everything correct and click continue")]
        public void WhenSelectEverythingCorrectAndClickContinue()
        {
            Assert.IsTrue(WebDriver.Title.Equals(VerifyTLevelPageTitle));
            EverythingCorrect();
            ClickContinueBtn();
        }
        
        [Then(@"I should see TLevel Confirmation message")]
        public void ThenIShouldSeeTLevelConfirmationMessage()
        {
            Assert.IsTrue(WebDriver.Title.Equals(TlevelConfirmantionPageTitle));
            Assert.IsTrue(WebDriver.FindElement(PageTitle).Text.Contains(TlevelConfirmantionMsg));
            Assert.IsTrue(WebDriver.FindElement(PageContent).Text.Contains(Constants.TlevelTitleAgricluture));
        }
    }
}
