using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class ReviewConfirmedTlevelsSteps : ManageTLevel
    {
        [Then(@"I should see Reviewed Tlevel detsils when i click on View Reviewd Tlevel link")]
        public void ThenIShouldSeeReviewedTlevelDetsilsWhenIClickOnViewReviewdTlevelLink()
        {
            ReviewAnotherTlevelLink();
            ViewReviewedTlevelLink();
            Assert.AreEqual(ViewTlevel, WebDriver.Url);
            Assert.IsTrue(WebDriver.FindElement(By.XPath("//*[@id='main-content']")).Text.Contains(Constants.TlevelAgricluture));
        }
    }
}
