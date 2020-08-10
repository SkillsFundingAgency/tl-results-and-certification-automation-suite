using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualChangeCoreSteps : RegistrationsManualPage
    {
        [When(@"I click on Core change link")]
        public void WhenIClickOnCoreChangeLink()
        {
            ClickChangeCoreLink();
        }
        
        [When(@"I changed the Core and click continue")]
        public void WhenIChangedTheCoreAndClickContinue()
        {
            Assert.AreEqual(Constants.SelectCoreTitle, WebDriver.Title);
            Assert.AreEqual(CoreHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(CorePageUrl));
            SelectCoreFromList("Agriculture, Environmental and Animal Care (77777777)");
            ClickContiune();
        }
        
        [When(@"I select the specialism and click continue")]
        public void WhenISelectTheSpecialismAndClickContinue()
        {
            Assert.AreEqual(Constants.SpecialismDecideTitle, WebDriver.Title);
            Assert.AreEqual(SpecialismDecideHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(SpecialismDecidePageUrl));
            ClickElement(DecideYes);
            ClickContiune();
            Assert.AreEqual(Constants.SelectSpecialismTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(SpecialismSelectPageUrl));
            ClickElement(SelectSpecialismAgg);
            ClickChangeBtn();
        }
        
        [Then(@"I should see changed Core details in Check and Submit page")]
        public void ThenIShouldSeeChangedCoreDetailsInCheckAndSubmitPage()
        {
            VerifyRegistrationSummaryPage();
        }
    }
}
