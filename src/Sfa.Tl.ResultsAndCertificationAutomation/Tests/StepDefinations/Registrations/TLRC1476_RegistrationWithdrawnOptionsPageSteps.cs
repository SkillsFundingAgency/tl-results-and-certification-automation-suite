using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class CreateWithdrawnOptionsPageForWithdrawnRecord_Story1476Steps
    {
        //[When(@"I click on the back link on the Withdrawn Registration Options Page")]
        //public void WhenIClickOnTheBackLinkOnTheWithdrawnRegistrationOptionsPage()
        //{
        //    RegistrationsWithdrawOptionsPage.ClickBackLink();
        //}
        
        [When(@"I click continue without selecting any radio buttons")]
        public void WhenIClickContinueWithoutSelectingAnyRadioButtons()
        {
            RegistrationsWithdrawOptionsPage.ClickContinueButton();
        }

        [Then(@"I am shown an error message on the Registrations Withdrawn Options page stating ""(.*)""")]
        public void ThenIAmShownAnErrorMessageOnTheRegistrationsWithdrawnOptionsPageStating(string ErrorMessage)
        {
            RegistrationsWithdrawOptionsPage.VerifyErrorMessage_RadioButtonsNotSelected(ErrorMessage);
        }

        [When(@"I withdraw my application and navigate to the Withdrawn Registration Details page")]
        public void WhenIWithdrawMyApplicationAndNavigateToTheWithdrawnRegistrationDetailsPage()
        {
            RegistrationsPage.ClickElement(RegistrationsSearchPage.SearchRegistrationLink);
            RegistrationsSearchPage.SearchForULN();
            RegistrationsSearchPage.VerifySearchResultPage();
            RegistrationsSearchPage.ClickChangeStatusLink();
            RegistrationsActiveOptionPage.ClickWithdrawRadioButton();
            RegistrationsActiveOptionPage.ClickContinueButton();
            RegistrationsWithdrawRegistrations.VerifyWithdrawRegistrationPage();
            RegistrationsWithdrawRegistrations.VerifyRadioButtonsNotSelected();
            RegistrationsWithdrawRegistrations.WithdrawApplication();
            RegistrationsWithdrawRegistrationsSuccess.VerifyWithdrawRegSuccessPage_EntryActiveOptionsPage();
            RegistrationsWithdrawRegistrationsSuccess.ClickViewWithdrawnRegistrationButton();
            RegistrationsSearchPage.VerifySearchResultPage();
            RegistrationsSearchPage.ValidateUlnStatus("WITHDRAWN");
            RegistrationsSearchPage.VerifyRegistrationDetailsPageSubHeading();
        }

        [When(@"I click the Change Status link on the Withdrawn options page")]
        public void WhenIClickTheChangeStatusLinkOnTheWithdrawnOptionsPage()
        {
            RegistrationsSearchPage.ClickChangeStatusLink();
        }

        [When(@"I click on the back link on the Withdrawn Registration Options Page")]
        public void WhenIClickOnTheBackLinkOnTheWithdrawnRegistrationOptionsPage()
        {
            RegistrationsWithdrawOptionsPage.ClickBackLink();
        }






    }
}
