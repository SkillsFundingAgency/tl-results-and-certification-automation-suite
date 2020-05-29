using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class ReviewTlevelDetailsSteps : ManageTLevel
    {
        [Then(@"I should see Reviewed Tlevel details when i click on view reviewed tlevel link")]
        public void ThenIShouldSeeReviewedTlevelDetailsWhenIClickOnViewReviewedTlevelLink()
        {
            ReviewAnotherTlevelLink();
            ViewReviewedTlevelLink();
            Assert.AreEqual(VerifyTLevelPageTitle, WebDriver.Title);
            Assert.AreEqual(ViewTlevel, WebDriver.Url);
            Assert.IsTrue(WebDriver.FindElement(PageContent).Text.Contains(Constants.TlevelTitleAgricluture));
        }
    }
}
