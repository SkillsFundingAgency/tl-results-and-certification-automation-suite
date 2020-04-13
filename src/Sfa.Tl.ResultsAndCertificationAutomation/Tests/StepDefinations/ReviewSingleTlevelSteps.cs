using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
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
            Assert.AreEqual(ReviewTlevel, WebDriver.Url);
            SelectTlevel(Agriculture);
            ClickContinueBtn();
        }
        
        [When(@"select Everything correct and click continue")]
        public void WhenSelectEverythingCorrectAndClickContinue()
        {
            EverythingCorrect();
            ClickContinueBtn();
        }
        
        [Then(@"I should see TLevel Confirmation message")]
        public void ThenIShouldSeeTLevelConfirmationMessage()
        {
            Assert.IsTrue(WebDriver.FindElement(PageTitle).Text.Contains(TlevelConfirmantionMsg));
        }
    }
}
