using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewJourney
{
    [Binding]
    public class BreadcrumYourTlevelConfirmedPageSteps : ManageTLevel
    {
        [When(@"I am on Your Tlevel Page")]
        public void WhenIAmOnYourTlevelPage()
        {
            DbUpdate();
            ClickTlevelLink();
            SelectTlevel(Agriculture);
            ClickContinueBtn();
            EverythingCorrect();
            ClickContinueBtn();
            ReviewAnotherTlevelLink();
            ViewReviewedTlevelLink();
            Assert.IsTrue(WebDriver.Url.Contains(ViewTlevel));
        }
    }
}
