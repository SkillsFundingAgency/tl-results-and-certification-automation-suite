using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class CreateLearnerWithdrawnSuccessfullyPage_Story992Steps
    {
        [Then(@"I will be navigated to the Registration withdrawn successfully page \(from Change Core page\)")]
        public void ThenIWillBeNavigatedToTheRegistrationWithdrawnSuccessfullyPageFromChangeCorePage()
        {
            RegistrationsWithdrawRegistrationsSuccess.VerifyWithdrawRegSuccessPage_EntryChangeProviderCorePages();
        }
        
        [Then(@"I will be navigated to the Registration withdrawn successfully page \(from Change Provide and Core page\)")]
        public void ThenIWillBeNavigatedToTheRegistrationWithdrawnSuccessfullyPageFromChangeProvideAndCorePage()
        {
            RegistrationsWithdrawRegistrationsSuccess.VerifyWithdrawRegSuccessPage_EntryChangeProviderCorePages();
        }

        [Then(@"I will be navigated to the Registration withdrawn successfully page \(From Active Options page\)")]
        public void ThenIWillBeNavigatedToTheRegistrationWithdrawnSuccessfullyPageFromActiveOptionsPage()
        {
            RegistrationsWithdrawRegistrationsSuccess.VerifyWithdrawRegSuccessPage_EntryActiveOptionsPage();
        }

        [When(@"I click the Home button")]
        public void WhenIClickTheHomeButton()
        {
            RegistrationsWithdrawRegistrationsSuccess.ClickHomeButton();
        }

        [Then(@"I will be navigated to the Registrations Dashboard page")]
        public void ThenIWillBeNavigatedToTheRegistrationsDashboardPage()
        {
            TlevelDashboardPage.VerifyDashboardpage();
        }

        [When(@"I Withdraw my Registration starting on the Active Options page")]
        public void WhenIWithdrawMyRegistrationStartingOnTheActiveOptionsPage()
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
        }

        [When(@"I click the View Withdrawn Registration button")]
        public void WhenIClickTheViewWithdrawnRegistrationButton()
        {
            RegistrationsWithdrawRegistrationsSuccess.ClickViewWithdrawnRegistrationButton();
        }

        [Then(@"I am navigated to the Registration Details page which shows my registration is withdrawn")]
        public void ThenIAmNavigatedToTheRegistrationDetailsPageWhichShowsMyRegistrationIsWithdrawn()
        {
            RegistrationsSearchPage.VerifySearchResultPage();
            RegistrationsSearchPage.ValidateUlnStatus("WITHDRAWN");
            RegistrationsSearchPage.VerifyRegistrationDetailsPageSubHeading();
            RegistrationsSearchPage.ValidateChangeLinksAreNotDisplayed();
        }

        [Then(@"there are no change links next to any of the data items")]
        public void ThenThereAreNoChangeLinksNextToAnyOfTheDataItems()
        {
            RegistrationsSearchPage.ValidateChangeLinksAreNotDisplayed();
        }


        [When(@"I search for my registration")]
        public void WhenISearchForMyRegistration()
        {
            RegistrationsSearchPage.NavigateTo("registrations");
            RegistrationsPage.ClickElement(RegistrationsSearchPage.SearchRegistrationLink);
            RegistrationsSearchPage.SearchForULN();
            RegistrationsSearchPage.ValidateChangeStatusLink();
        }

        [When(@"I click the Change Status link")]
        public void WhenIClickTheChangeStatusLink()
        {
            RegistrationsSearchPage.ClickChangeStatusLink();
        }


        [Then(@"I am navigated to the Withdrawn options page")]
        public void ThenIAmNavigatedToTheWithdrawnOptionsPage()
        {
            RegistrationsWithdrawOptionsPage.VerifyRegistrationsWithdrawOptionsPage();
            RegistrationsWithdrawOptionsPage.VerifyRadioButtonsNotSelected();
        }


    }
}
