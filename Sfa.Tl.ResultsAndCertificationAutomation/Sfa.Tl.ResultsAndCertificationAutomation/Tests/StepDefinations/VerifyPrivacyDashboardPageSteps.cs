using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System.Threading;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class VerifyPrivacyDashboardPageSteps : StartPage
    {
        [When(@"click on Privacy link in Dahsboard page")]
        public void WhenClickOnPrivacyLinkInDahsboardPage()
        {
            WebDriver.FindElement(PrivacyLink).Click();
            Thread.Sleep(2000);
        }
    }
}
