using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualChangeUlnSteps : RegistrationsManualPage
    {
        [When(@"I click on Uln change link")]
        public void WhenIClickOnUlnChangeLink()
        {
            ClickChangeUlnLink();
        }
        
        [When(@"I changed the uln number and click on change button")]
        public void WhenIChangedTheUlnNumberAndClickOnChangeButton()
        {
            Assert.AreEqual(Constants.UlnPageTitle, WebDriver.Title);
            Assert.AreEqual(UlnPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(UlnUrl));
            WebDriver.FindElement(UlnInput).Clear();
            WebDriver.FindElement(UlnInput).SendKeys("9900000061");
            ClickChangeBtn();
        }
        
        [Then(@"I should see changed uln in confirm and submit page")]
        public void ThenIShouldSeeChangedUlnInConfirmAndSubmitPage()
        {
            VerifyRegistrationSummaryPage();
        }
    }
}
