using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class ReviewSingleTlevelSteps : ManageTLevel
    {
        [Given(@"I click on Tlevels link")]
        public void GivenIClickOnTlevelsLink()
        {
            DbUpdate();
            ClickTlevelLink();
        }
        
        [When(@"i select a TLevel and click continue")]
        public void WhenISelectATLevelAndClickContinue()
        {
            Assert.AreEqual(WebDriver.Url, ReviewTlevel);
            SelectTlevel(Agriculture);
            ClickContinueBtn();
        }
        
        [When(@"select Everything correct and click continue button")]
        public void WhenSelectEverythingCorrectAndClickContinueButton()
        {
            EverythingCorrect();
            ClickContinueBtn();
        }
        
        [Then(@"I should see Tlevel confirmation message")]
        public void ThenIShouldSeeTlevelConfirmationMessage()
        {
            Assert.IsTrue(WebDriver.FindElement(PageTitle).Text.Contains(TlevelConfirmantionMsg));
        }
    }
}
