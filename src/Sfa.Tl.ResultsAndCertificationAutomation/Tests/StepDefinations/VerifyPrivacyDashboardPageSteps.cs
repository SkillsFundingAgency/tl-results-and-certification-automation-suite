using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class VerifyPrivacyDashboardPageSteps : StartPage
    {
        [When(@"i click on Privacy link in Dahsboard page")]
        public void WhenClickOnPrivacyLinkInDahsboardPage()
        {
            WebDriver.FindElement(PrivacyLink).Click();
        }
    }
}
