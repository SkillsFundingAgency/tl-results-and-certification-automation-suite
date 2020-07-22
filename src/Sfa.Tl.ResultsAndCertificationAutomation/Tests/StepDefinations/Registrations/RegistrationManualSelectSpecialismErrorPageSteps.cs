using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualSelectSpecialismErrorPageSteps : RegistrationsManualPage
    {
        [When(@"I click Continue without selecting Specialism")]
        public void WhenIClickContinueWithoutSelectingSpecialism()
        {
            ClickContiune();
        }
        
        [Then(@"I should see Error in the page")]
        public void ThenIShouldSeeErrorInThePage()
        {
            Assert.AreEqual(Constants.SelectSpecialismErrorTitle, WebDriver.Title);
        }
    }
}
