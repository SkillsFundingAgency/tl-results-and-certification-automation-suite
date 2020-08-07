using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualChangeProviderSteps : RegistrationsManualPage
    {
        [When(@"I click on Provider change link")]
        public void WhenIClickOnProviderChangeLink()
        {
            ClickChangePoviderLink();
        }
        
        [When(@"I changed the Provider and click continue")]
        public void WhenIChangedTheProviderAndClickContinue()
        {
            Assert.AreEqual(Constants.SelectProviderTitle, WebDriver.Title);
            Assert.AreEqual(ProviderHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(ProviderPageUrl));
            SelectProviderFromList("Automation Test1 (99999901)");
            ClickContiune();
        }
        
        [When(@"I change Core and Specialisms and click continue")]
        public void WhenIChangeCoreAndSpecialismsAndClickContinue()
        {
            Assert.AreEqual(Constants.SelectCoreTitle, WebDriver.Title);
            Assert.AreEqual(CoreHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(CorePageUrl));
            SelectCoreFromList("Agriculture, Environmental and Animal Care (77777777)");
            ClickContiune();
            Assert.AreEqual(Constants.SpecialismDecideTitle, WebDriver.Title);
            Assert.AreEqual(SpecialismDecideHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(SpecialismDecidePageUrl));
            ClickElement(DecideNo);
            ClickContiune();
        }
        
        [Then(@"I should changed Provider details in Check and Submit page")]
        public void ThenIShouldChangedProviderDetailsInCheckAndSubmitPage()
        {
            VerifyRegistrationSummaryPage();
        }
    }
}
