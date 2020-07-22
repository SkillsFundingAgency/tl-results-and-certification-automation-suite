using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualUlnErrorPageSteps : RegistrationsManualPage
    {
        [When(@"I click in continue button")]
        public void WhenIClickInContinueButton()
        {
            ClickContiune();
        }
        
        [Then(@"I should see Error in ULn Page")]
        public void ThenIShouldSeeErrorInULnPage()
        {
            Assert.AreEqual(Constants.UlnPageErrorTitle, WebDriver.Title);
        }
    }
}
