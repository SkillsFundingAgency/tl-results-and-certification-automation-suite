using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualSelectCoreErrorPageSteps : RegistrationsManualPage
    {
        [When(@"I click on Continue witout selecting Core")]
        public void WhenIClickOnContinueWitoutSelectingCore()
        {
            ClickContiune();
        }
        
        [Then(@"I should see error in Select Core page")]
        public void ThenIShouldSeeErrorInSelectCorePage()
        {
            Assert.AreEqual(Constants.SelectCoreErrorTitle, WebDriver.Title);
        }
    }
}
