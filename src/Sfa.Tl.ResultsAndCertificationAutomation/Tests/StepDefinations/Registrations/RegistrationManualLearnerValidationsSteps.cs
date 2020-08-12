using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualLearnerValidationsSteps : RegistrationsManualPage
    {
        [When(@"I enter invalid (.*) (.*) for Learner")]
        public void WhenIEnterInvalidForLearner(string FirstName, string LastName)
        {
            EnterLearnerName(FirstName, LastName);
        }

        [Then(@"I should see errors")]
        public void ThenIShouldSeeErrors()
        {
            Assert.AreEqual(FirstNameErrorMsg, WebDriver.FindElement(FirstNameError).Text);
            Assert.AreEqual(LastNameErrorMsg, WebDriver.FindElement(LastNameError).Text);
        }
    }
}
