using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System.Threading;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Xunit;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class VerifyBannerSteps : StartPage
    {
        private static string DfEUserName = WebDriverFactory.Config["DfEUserName"];
        private static string DfEPassword = WebDriverFactory.Config["DfEPassword"];
        
        [Given(@"A Tlevel start page")]
        public void GivenATlevelStartPage()
        {
            WebDriver.Navigate().GoToUrl(StartPageUrl);
        }
        
        [Given(@"I have clicked in Start Now button")]
        public void GivenIHaveClickedInStartNowButton()
        {
            WebDriver.FindElement(StartNowButton).Click();
            Thread.Sleep(2000);
        }
        
        [When(@"i sign in with valid DfE Username and password")]
        public void WhenISignInWithValidDfEUsernameAndPassword()
        {
            DfESignInPage.DfESignIn(DfEUserName, DfEPassword);
        }
        
        [Then(@"I should page Banner information on top of the page")]
        public void ThenIShouldPageBannerInformationOnTopOfThePage()
        {
            Assert.True(WebDriver.FindElement(TlevelDashboardPage.BannerInfo).Text.Contains(TlevelDashboardPage.BannerText));
        }
    }
}
