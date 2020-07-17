using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualDOBErrorPageSteps : RegistrationsManualPage
    {
        [When(@"I click continue without entering data")]
        public void WhenIClickContinueWithoutEnteringData()
        {
            ClickContiune();
        }
        
        [Then(@"I should see error in the page")]
        public void ThenIShouldSeeErrorInThePage()
        {
            Assert.AreEqual(Constants.DobPageErrorTitle, WebDriver.Title);
        }
    }
}
