using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class TLRC991_WithdrawRegistrationSteps
    {
        [When(@"I click Withdraw Registration on the Change Core page")]
        public void WhenIClickWithdrawRegistrationOnTheChangeCorePage()
        {
            RegistrationsPage.ClickElement(RegistrationsSearchPage.SearchRegistrationLink);
            RegistrationsSearchPage.SearchForULN();
            RegistrationsSearchPage.VerifySearchResultPage();
            RegistrationsSearchPage.ClickChangeCoreLink();
            RegistrationChangeCorePage.ClickWithdrawButton();
        }

        [Then(@"I will be directed to the are you sure you want to withdraw this page")]
        public void ThenIWillBeDirectedToTheAreYouSureYouWantToWithdrawThisPage()
        {
            RegistrationsWithdrawRegistrations.VerifyWithdrawRegistrationPage();
            RegistrationsWithdrawRegistrations.VerifyRadioButtonsNotSelected();
        }

        [When(@"I click Withdraw Registration on the Change Provider and Core page")]
        public void WhenIClickWithdrawRegistrationOnTheChangeProviderAndCorePage()
        {
            RegistrationsPage.ClickElement(RegistrationsSearchPage.SearchRegistrationLink);
            RegistrationsSearchPage.SearchForULN();
            RegistrationsSearchPage.VerifySearchResultPage();
            RegistrationsSearchPage.ClickChangeProviderLink();
            RegistrationChangeProviderPage.SelectProviderFromList(Constants.ManualRegUpdatedProvider1);
            RegistrationChangeProviderPage.ClickChangeButton();
            RegistrationChangeCorePage.ClickYesRadioButton_AreYouSureChangeCorePage();
            RegistrationChangeCorePage.ClickContinueButton_AreYouSureChangeCorePage();

            RegistrationChangeProviderAndCorePage.ClickWithdrawButton(); 
         }

        [When(@"I click Withdraw Registration on the Active Options page")]
        public void WhenIClickWithdrawRegistrationOnTheActiveOptionsPage()
        {
            RegistrationsPage.ClickElement(RegistrationsSearchPage.SearchRegistrationLink);
            RegistrationsSearchPage.SearchForULN();
            RegistrationsSearchPage.VerifySearchResultPage();
            RegistrationsSearchPage.ClickChangeStatusLink();
            RegistrationsActiveOptionPage.ClickWithdrawRadioButton();
            RegistrationsActiveOptionPage.ClickContinueButton();
        }


        [When(@"I click the back link")]
        public void WhenIClickTheBackLink()
        {
            RegistrationsWithdrawRegistrations.ClickBackLink();
        }

        [Then(@"I will be navigated to the Change Core page")]
        public void ThenIWillBeNavigatedToTheChangeCorePage()
        {
            RegistrationChangeCorePage.VerifyChangeCorePageDetails();
        }

        [Then(@"I will be navigated to the Change Orovider and Core page")]
        public void ThenIWillBeNavigatedToTheChangeOroviderAndCorePage()
        {
            RegistrationChangeProviderAndCorePage.VerifyChangeProviderAndCorePage();
        }

        [Then(@"I am navigated to the Active options page")]
        public void ThenIAmNavigatedToTheActiveOptionsPage()
        {
            RegistrationsActiveOptionPage.VerifyAmendActiveRegistrationPage();
        }

        [When(@"I select No, do not withdraw registration")]
        public void WhenISelectNoDoNotWithdrawRegistration()
        {
            RegistrationsWithdrawRegistrations.DoNotWithdrawApplication();
        }

        [When(@"I press Submit button without selecting any radio buttons")]
        public void WhenIPressSubmitButtonWithoutSelectingAnyRadioButtons()
        {
            RegistrationsWithdrawRegistrations.ClickSubmitButton();
        }

        [Then(@"I will be shown an error on the Withdraw Registration page stating ""(.*)""")]
        public void ThenIWillBeShownAnErrorOnTheWithdrawRegistrationPageStating(string ErrorMessage)
        {
            RegistrationsWithdrawRegistrations.ErrorMessage_RadioButtonsNotSelected(ErrorMessage);
        }

        [When(@"I select Yes, withdraw registration")]
        public void WhenISelectYesWithdrawRegistration()
        {
            RegistrationsWithdrawRegistrations.WithdrawApplication();
        }

        [Then(@"I will be navigated to the Registration withdrawn successfully page")]
        public void ThenIWillBeNavigatedToTheRegistrationWithdrawnSuccessfullyPage()
        {
            RegistrationsWithdrawRegistrationsSuccess.VerifyWithdrawRegSuccessPage_EntryActiveOptionsPage();
        }

        [Then(@"the registration is successfully withdrawn")]
        public void ThenTheRegistrationIsSuccessfullyWithdrawn()
        {
            RegistrationsWithdrawRegistrationsSuccess.ClickViewWithdrawnRegistrationButton();
            RegistrationsSearchPage.ValidateUlnStatus("WITHDRAWN");
        }



    }
}
