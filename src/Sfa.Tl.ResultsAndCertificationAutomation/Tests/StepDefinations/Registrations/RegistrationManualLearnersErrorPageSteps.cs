using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualLearnersErrorPageSteps : RegistrationsManualPage
    {
        [When(@"I click on Coninue button in Learners Page")]
        public void WhenIClickOnConinueButtonInLearnersPage()
        {
            ClickContiune();
        }
        
        [Then(@"should see error in Learners page")]
        public void ThenShouldSeeErrorInLearnersPage()
        {
            Assert.AreEqual(Constants.LearnerPageErrorTitle, WebDriver.Title);
        }
    }
}
