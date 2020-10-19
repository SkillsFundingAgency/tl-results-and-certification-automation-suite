using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class IntegratingSelectProviderPageRegisterLearnerOnNewCourse_Story1827Steps
    {
        [Then(@"I am shown the Registration withdrawn successfully page")]
        public void ThenIAmShownTheRegistrationWithdrawnSuccessfullyPage()
        {
            RegistrationsWithdrawRegistrationsSuccess.VerifyWithdrawRegSuccessPage_EntryChangeProviderCorePages();
        }

        [When(@"I click on the Register learner on new course button")]
        public void WhenIClickOnTheRegisterLearnerOnNewCourseButton()
        {
            RegistrationsWithdrawRegistrationsSuccess.ClickRegisterNewCourseButton();
        }

        [Then(@"I am navigated to the Select the provider page for Register learner on a new course")]
        public void ThenIAmNavigatedToTheSelectTheProviderPageForRegisterLearnerOnANewCourse()
        {
            RegistrationReactivate.VerifyReactivateWithAnotherProviderPage();
        }

        [When(@"I click Withdraw Registration button on the Change Provider and Core page")]
        public void WhenIClickWithdrawRegistrationButtonOnTheChangeProviderAndCorePage()
        {
            RegistrationsPage.ClickElement(RegistrationsSearchPage.SearchRegistrationLink);
            RegistrationsSearchPage.SearchForULN();
            RegistrationsSearchPage.VerifySearchResultPage();
            RegistrationsSearchPage.ClickChangeProviderLink();
            RegistrationChangeProviderPage.SelectProviderFromList("Automation Test1 (99999901)");
            RegistrationChangeProviderPage.ClickChangeButton();
            RegistrationChangeCorePage.ClickYesRadioButton_AreYouSureChangeCorePage();
            RegistrationChangeCorePage.ClickContinueButton_AreYouSureChangeCorePage();

            RegistrationChangeProviderAndCorePage.ClickWithdrawButton();
        }

        [When(@"I click the back link on the Select the provider page for Register learner on a new course")]
        public void WhenIClickTheBackLinkOnTheSelectTheProviderPageForRegisterLearnerOnANewCourse()
        {
            RegistrationReactivate.ClickProviderBackLink();
        }

        [Then(@"the Radio buttons will not be populated on entry")]
        public void ThenTheRadioButtonsWillNotBePopulatedOnEntry()
        {
            RegistrationsWithdrawOptionsPage.VerifyRadioButtonsNotSelected();
        }




    }
}
