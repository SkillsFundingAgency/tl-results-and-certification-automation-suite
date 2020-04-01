using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class ErrorPagesServiceAccessDeniedSteps : StartPage
    {
        [Then(@"I should be on same page if i click on Service Banner")]
        public void ThenIShouldBeOnSamePageIfIClickOnServiceBanner()
        {
            ElementHelper.ClickElement(TlevelDashboardPage.DashboardHeadLink);
            Assert.AreEqual(WebDriver.Url, Error403);
        }
    }
}
