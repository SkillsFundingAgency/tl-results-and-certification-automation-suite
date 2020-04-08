using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class ReviewToQueryTlevelsSteps : ManageTLevel
    {
        [When(@"I click on View reviewed Tlevel link")]
        public void WhenIClickOnViewReviewedTlevelLink()
        {
            SelectTlevel(Agriculture);
            ClickContinueBtn();
            EverythingCorrect();
            ClickContinueBtn();
            ReviewAnotherTlevelLink();
            ViewReviewedTlevelLink();
            ClickViewConfirmedTlevel();
        }
        
        [When(@"i click on View and Something not write link")]
        public void WhenIClickOnViewAndSomethingNotWriteLink()
        {
            ClickSomethingNotRightLink();
        }
        
        [When(@"i enter text and submit")]
        public void WhenIEnterTextAndSubmit()
        {
            QueryTlevelText();
        }
        
        [Then(@"the Tlevel should moved from Confirmed to Review status")]
        public void ThenTheTlevelShouldMovedFromConfirmedToReviewStatus()
        {
            Assert.IsTrue(WebDriver.FindElement(PageTitle).Text.Contains(TlevelQueryMsg));
        }
    }
}
