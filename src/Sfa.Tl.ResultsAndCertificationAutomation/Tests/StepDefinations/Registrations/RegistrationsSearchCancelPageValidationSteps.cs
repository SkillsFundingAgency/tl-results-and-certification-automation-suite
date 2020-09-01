using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationsSearchCanelPageValidationSteps : RegistrationsSearchPage
    {
        [Given(@"I am on Search registration page")]
        public void GivenIAmOnSearchRegistrationPage()
        {
            RegistrationsManualPage.CreateRegistrationWithoutSpecialism("9900000060", "FirstName1", "LastName1", "01", "01", "2010");
            RegistrationsManualPage.ClickSubmit();
            RegistrationsManualPage.ClickBackToRegistrations();
            ClickElement(SearchRegistrationLink);
        }

        [Given(@"I entered registered (.*) and click search")]
        public void GivenIEnteredRegisteredAndClickSearch(string Uln)
        {
            EnterText(SearchBox, Uln);
            ClickElement(SearchBtn);
        }

        [Given(@"I click on Cancel Registration button")]
        public void GivenIClickOnCancelRegistrationButton()
        {
            ClickCancelRegistration();
        }

        [When(@"I click on Cancel button wihtout selecting options")]
        public void WhenIClickOnCancelButtonWihtoutSelectingOptions()
        {
            RegistrationsManualPage.ClickSubmit();
        }

        [Then(@"I should see validation (.*) in cancel registration page")]
        public void ThenIShouldSeeValidationInCancelRegistrationPage(string Errors)
        {
            Assert.AreEqual(ConfirmRegCancelErrorTitle, WebDriver.Title);
            Assert.AreEqual(Errors, WebDriver.FindElement(CancelRegError).Text);
        }
    }
}
