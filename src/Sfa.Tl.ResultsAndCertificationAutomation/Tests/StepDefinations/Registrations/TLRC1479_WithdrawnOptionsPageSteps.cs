using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class AreYouSureYouWantToReactivateTheRegistrationWithTheSameCoursePage_Story1479Steps
    {
        [When(@"I withdraw the registration and then Reactivate this registration with the same course")]
        public void WhenIWithdrawTheRegistrationAndThenReactivateThisRegistrationWithTheSameCourse()
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
            //RegistrationsSearchPage.ValidateUlnStatusWithdrawn();
            RegistrationsSearchPage.ClickChangeStatusLink();
            RegistrationsWithdrawOptionsPage.ClickReactiveRegistrationRadioButton();
            RegistrationsWithdrawOptionsPage.ClickContinueButton();
        }
        
        [Then(@"I am shown the Withdrawn Options page")]
        public void ThenIAmShownTheWithdrawnOptionsPage()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
