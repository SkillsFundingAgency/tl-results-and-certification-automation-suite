using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class SignOutDashboardPageSteps : StartPage
    {
        [When(@"I click on Sign Out link")]
        public void WhenIClickOnSignOutLink()
        {
            PageHelper.WaitForElement(TlevelDashboardPage.SignOutLink, 30);
            WebDriver.FindElement(TlevelDashboardPage.SignOutLink).Click();
        }
        
        [Then(@"I should be redirectted to Tlevel Start page")]
        public void ThenIShouldBeRedirecttedToTlevelStartPage()
        {
            PageHelper.WaitForUrl(StartPageUrl);
            PageHelper.VerifyPageUrl(WebDriver.Url, StartPageUrl);
        }
    }
}
