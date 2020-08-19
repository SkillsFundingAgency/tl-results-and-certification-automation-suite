using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.SmokeTests
{
    [Binding]
    public class VerifyCookieDetailsInCookiesStartPageSteps : TlevelDashboardPage
    {
        [When(@"I click on Find out more about cookies link in Cookies page")]
        public void WhenIClickOnFindOutMoreAboutCookiesLinkInCookiesPage()
        {
            ClickElement(CookieDetailsLink);
        }
        
        [Then(@"i should see Cookie details page")]
        public void ThenIShouldSeeCookieDetailsPage()
        {
            Assert.AreEqual(CookeDetailsPageTitle, WebDriver.Title);
            Assert.AreEqual(CookieDetailsPageHeader, WebDriver.FindElement(PageTitle).Text);
            Assert.AreEqual(CookieUrl, WebDriver.Url);
        }
    }
}
