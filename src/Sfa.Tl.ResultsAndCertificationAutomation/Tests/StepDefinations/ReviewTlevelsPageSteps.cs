using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class ReviewTlevelsPageSteps : ManageTLevel
    {
        [When(@"I click on TLevels link")]
        public void WhenIClickOnTLevelsLink()
        {
            DbUpdate();
            ClickTlevelLink();
        }
        
        [Then(@"I should see Select TLevel Review Page")]
        public void ThenIShouldSeeSelectTLevelReviewPage()
        {
            Assert.AreEqual(WebDriver.Url, ReviewTlevel);
        }
    }
}
