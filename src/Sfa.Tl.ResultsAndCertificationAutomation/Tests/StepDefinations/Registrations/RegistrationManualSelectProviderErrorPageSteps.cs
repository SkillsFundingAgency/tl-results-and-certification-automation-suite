using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualSelectProviderErrorPageSteps : RegistrationsManualPage
    {
        [When(@"I click Continue")]
        public void WhenIClickContinue()
        {
            ClickContiune();
        }
        
        [Then(@"I should see errors in Select Provider page")]
        public void ThenIShouldSeeErrorsInSelectProviderPage()
        {
            Assert.AreEqual(Constants.SelectProviderErrorTitle, WebDriver.Title);
        }
    }
}
