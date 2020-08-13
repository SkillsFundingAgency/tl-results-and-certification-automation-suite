using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using NUnit.Framework;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualDOBValidationsSteps : Pages.RegistrationsManualPage
    {
        [Given(@"I enter invlid (.*) (.*) (.*) in DOB fields")]
        public void GivenIEnterInvlidInDOBFields(string Day, string Month, string Year)
        {
            EnterDob(Day, Month, Year);
        }
                
        [When(@"I click on Continue button in DOB page")]
        public void WhenIClickOnContinueButtonInDOBPage()
        {
            ClickContiune();
        }

        [Then(@"I should see DOB validation (.*)")]
        public void ThenIShouldSeeDOBValidation(string Errors)
        {
            Assert.AreEqual(Constants.DobPageErrorTitle, WebDriver.Title);
            Assert.AreEqual(Errors, WebDriver.FindElement(DayError).Text);
        }
    }
}
