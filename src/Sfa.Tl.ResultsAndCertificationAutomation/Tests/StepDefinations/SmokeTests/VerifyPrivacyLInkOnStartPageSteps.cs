using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.SmokeTests
{
    [Binding]
    public class VerifyPrivacyLInkOnStartPageSteps : TlevelDashboardPage
    {
        [Given(@"I have navigated to Tlevel Start page")]
        public void GivenIHaveNavigatedToTlevelStartPage()
        {
            WebDriver.Navigate().GoToUrl(StartPageUrl);
        }
        
        [When(@"I click on Privacy link")]
        public void WhenIClickOnPrivacyLink()
        {
            ClickElement(PrivacyLink);
        }
        
        [Then(@"I should see Privacy page")]
        public void ThenIShouldSeePrivacyPage()
        {
            VerifyPrivacy();
        }
    }
}
