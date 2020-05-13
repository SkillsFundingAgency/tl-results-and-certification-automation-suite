using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewJourney
{
    [Binding]
    public class BreadcrumYourTlevelQueriedPageSteps : ManageTLevel
    {
        [When(@"I am on your Tlevel Queried page")]
        public void WhenIAmOnYourTlevelQueriedPage()
        {
            DbUpdate();
            ClickTlevelLink();
            SelectTlevel(Agriculture);
            ClickContinueBtn();
            SomethingWrong();
            ClickContinueBtn();
            QueryTlevelText();
            ReviewAnotherTlevelLink();
            ViewReviewedTlevelLink();
            Assert.IsTrue(WebDriver.Url.Contains(ViewTlevel));
        }
    }
}
