using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using NUnit.Framework;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class VerifyCookiesDashboardPageSteps : StartPage
    {
        [Given(@"I have login as a Admin user")]
        public void GivenIHaveLoginAsAAdminUser()
        {
            DfESignInPage.SigninAsSiteAdmin();
        }
        
        [When(@"i click on Cooke link in Dahsboard page")]
        public void WhenClickOnCookeLinkInDahsboardPage()
        {
            WebDriver.FindElement(CookieLink).Click();
        }
        
        [Then(@"Cookeis page should open")]
        public void ThenCookeisPageShouldOpen()
        {
            PageHelper.VerifyPageUrl(WebDriver.Url, CookieUrl);
            Assert.AreEqual("Cookies on Manage T Level results", WebDriver.FindElement(TlevelCookies).Text);
        }
    }
}
