using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class VerifyPrivacyDashboardPageSteps : StartPage
    {
        [When(@"click on Privacy link in Dahsboard page")]
        public void WhenClickOnPrivacyLinkInDahsboardPage()
        {
            PageHelper.WaitForUrl(TlevelDashboardPage.DashboardUrl);
            WebDriver.FindElement(PrivacyLink).Click();
        }
    }
}
