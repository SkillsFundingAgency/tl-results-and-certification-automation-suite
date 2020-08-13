using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualUlnValidationsSteps : RegistrationsManualPage
    {
        [Given(@"I enter (.*) with invalid data")]
        public void GivenIEnterWithInvalidData(string Uln)
        {
            EnterUln(Uln);
        }

        [Then(@"I should see valid (.*) message in header")]
        public void ThenIShouldSeeValidMessageInHeader(string Error)
        {
            Assert.AreEqual(Error, WebDriver.FindElement(UlnError).Text);
            Assert.AreEqual(Constants.UlnPageErrorTitle, WebDriver.Title);
        }
    }
}
