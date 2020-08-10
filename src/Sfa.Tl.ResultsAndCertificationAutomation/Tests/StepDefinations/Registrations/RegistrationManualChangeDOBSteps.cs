using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualChangeDOBSteps : RegistrationsManualPage
    {
        [When(@"I click on DateOfBirth change link")]
        public void WhenIClickOnDateOfBirthChangeLink()
        {
            ClickChangeDobLink();
        }
        
        [When(@"I changed  Date of Birth and click on Change button")]
        public void WhenIChangedDateOfBirthAndClickOnChangeButton()
        {
            Assert.AreEqual(Constants.DobPageTitle, WebDriver.Title);
            Assert.AreEqual(DobPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(DobPageUrl));
            WebDriver.FindElement(Day).Clear();
            WebDriver.FindElement(Day).SendKeys("10");
            WebDriver.FindElement(Month).Clear();
            WebDriver.FindElement(Month).SendKeys("10");
            WebDriver.FindElement(Year).Clear();
            WebDriver.FindElement(Year).SendKeys("2011");
            ClickChangeBtn();
        }
        
        [Then(@"I should see changed Date of Birth in Check and Submit page")]
        public void ThenIShouldSeeChangedDateOfBirthInCheckAndSubmitPage()
        {
            VerifyRegistrationSummaryPage();
        }
    }
}
