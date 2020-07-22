using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualDecideSpecialismErrorPageSteps : RegistrationsManualPage
    {
        [When(@"click Continue without selecting any option")]
        public void WhenClickContinueWithoutSelectingAnyOption()
        {
            ClickContiune();
        }
        
        [Then(@"I should see error in the Decide Specialism page")]
        public void ThenIShouldSeeErrorInTheDecideSpecialismPage()
        {
            Assert.AreEqual(Constants.SpecialismDecideErrorTitle, WebDriver.Title);
        }
    }
}
