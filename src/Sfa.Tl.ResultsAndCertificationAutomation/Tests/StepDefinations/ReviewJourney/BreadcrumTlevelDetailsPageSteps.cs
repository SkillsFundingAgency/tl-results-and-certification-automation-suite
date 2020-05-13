using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewJourney
{
    [Binding]
    public class BreadcrumTlevelDetailsPageSteps : ManageTLevel
    {
        [When(@"I am on Tlevel Details Page")]
        public void WhenIAmOnTlevelDetailsPage()
        {
            DbUpdate();
            ClickTlevelLink();
            SelectTlevel(Agriculture);
            ClickContinueBtn();
            EverythingCorrect();
            ClickContinueBtn();
            ReviewAnotherTlevelLink();
            ViewReviewedTlevelLink();
            ClickViewConfirmedTlevel();
            Assert.IsTrue(WebDriver.Url.Contains(TlevelDetails));
        }
        
        [When(@"I click on Your Tlevels link")]
        public void WhenIClickOnYourTlevelsLink()
        {
            ClickElement(BcYourTlevels);
        }
        
        [Then(@"I should be navigated back to Your reviewed Tlevel page")]
        public void ThenIShouldBeNavigatedBackToYourReviewedTlevelPage()
        {
            Assert.AreEqual(ViewTlevel, WebDriver.Url);
            Assert.IsTrue(WebDriver.Title.Equals(TLevelViewPageTitle));
        }
    }
}
