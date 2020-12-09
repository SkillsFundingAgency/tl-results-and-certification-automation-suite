using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class CreateActiveOptionsPageForActiveRecord_Story1475Steps
    {

        private readonly ScenarioContext scenarionContext;

        public CreateActiveOptionsPageForActiveRecord_Story1475Steps(ScenarioContext scenarionContext)
        {
            this.scenarionContext = scenarionContext;
        }

        [When(@"I click the ChangeStatus link")]
        public void WhenIClickTheChangeStatusLink()
        {
            RegistrationsSearchPage.ClickChangeStatusLink();
        }
        
        [Then(@"I am shown the Active options page for Active Record")]
        public void ThenIAmShownTheActiveOptionsPageForActiveRecord()
        {
            RegistrationsActiveOptionPage.VerifyAmendActiveRegistrationPage();
            RegistrationsActiveOptionPage.VerifyRadioButtonsNotSelected();
        }

        [When(@"I click the Back link on the Active options page for Active Record page")]
        public void WhenIClickTheBackLinkOnTheActiveOptionsPageForActiveRecordPage()
        {
            RegistrationsActiveOptionPage.ClickBackLink();
        }

        [Then(@"I click Continue without selecting a radio button")]
        public void ThenIClickContinueWithoutSelectingARadioButton()
        {
            RegistrationsActiveOptionPage.ClickContinueButton();
        }


        [Then(@"I am shown an error message on the Active options page stating ""(.*)""")]
        public void ThenIAmShownAnErrorMessageOnTheActiveOptionsPageStating(string ExpectedErrorMessage)
        {
            RegistrationsActiveOptionPage.AssertErrorMessage(ExpectedErrorMessage);
        }

        [When(@"I capture the Active options page URL")]
        public void WhenICaptureTheActiveOptionsPageURL()
        {
            scenarionContext["ActiveOptionsPageURL"] = RegistrationChangeDOBPage.CapturePageURL();
        }

        [When(@"I navigate to the captured URL")]
        public void WhenINavigateToTheCapturedURL()
        {
            string URL = scenarionContext["ActiveOptionsPageURL"].ToString();
            Console.WriteLine(URL);
            RegistrationChangeNamePage.NavigateToBookmarkedPage(scenarionContext["ActiveOptionsPageURL"].ToString());
        }


        [When(@"I withdraw the registration from the the Active options page for Active Record")]
        public void WhenIWithdrawTheRegistrationFromTheTheActiveOptionsPageForActiveRecord()
        {
            RegistrationsActiveOptionPage.ClickWithdrawRadioButton();
            RegistrationsActiveOptionPage.ClickContinueButton();
            RegistrationsWithdrawRegistrations.WithdrawApplication();
        }

        [When(@"I attempt to access the Active options page for Active Record using the captured URL")]
        public void WhenIAttemptToAccessTheActiveOptionsPageForActiveRecordUsingTheCapturedURL()
        {
            RegistrationsActiveOptionPage.NavigateToUrl(scenarionContext["ActiveOptionsPageURL"].ToString());
        }

        [When(@"I attempt to access the Active options page for Active Record using an invalid URL")]
        public void WhenIAttemptToAccessTheActiveOptionsPageForActiveRecordUsingAnInvalidURL()
        {
            RegistrationsActiveOptionPage.NavigateToUrl("https://test.manage-tlevel-results.tlevels.gov.uk/amend-active-registration/ABCDEF");
        }
    }
}
