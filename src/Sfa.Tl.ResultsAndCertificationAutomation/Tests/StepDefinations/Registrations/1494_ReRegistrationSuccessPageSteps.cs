using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class CreateChangeRegistration_DOBPage_Story980Steps
    {
        [Then(@"I select Yes to reactivate the registration")]
        public void ThenISelectYesToReactivateTheRegistration()
        {
            RegistrationReactivate.VerifyAreYouSureReactivatePage();
            RegistrationReactivate.ReactivateApplication();
        }

        [Then(@"I am shown the ReRegistration Success page")]
        public void ThenIAmShownTheReRegistrationSuccessPage()
        {
            // RegistrationReactivate.VerifyReactivateSuccessPage();
            ReactivateRegistrationSuccessPage.VerifyReRegistrationSuccessPage();
        
        }

        [When(@"I select Register learner on a different course and click continue")]
        public void WhenISelectRegisterLearnerOnADifferentCourseAndClickContinue()
        {
            RegistrationsWithdrawOptionsPage.ClickRegisterLearnerNewCourseRadioButton();
            RegistrationsWithdrawOptionsPage.ClickContinueButton();
        }


        [When(@"I select a different provider, core and specialism and submit the changes")]
        public void WhenISelectADifferentProviderCoreAndSpecialismAndSubmitTheChanges()
        {
            RegistrationsManualPage.SelectProviderFromList(Constants.ManualRegUpdatedProvider);
            RegistrationsManualPage.ClickContiune();
            RegistrationReactivateChangeCorePage.SelectUpdatedCore(Constants.ManualRegUpdatedCore);
            ReregisterHasLearnerDecidePage.SelectYesAddSpecialismNow();
            ReregisterCreateSpecialismPage.UpdateSpecialism();
            ReregisterCheckAndSubmitPage.VerifyUpdatedReregisterData();
            ReregisterCheckAndSubmitPage.ClickSubmitButton();
        }

        [When(@"I click the View Withdrawn Registration button om the Reactivate registration success page")]
        public void WhenIClickTheViewWithdrawnRegistrationButtonOmTheReactivateRegistrationSuccessPage()
        {
            ReactivateRegistrationSuccessPage.ClickViewRegistrationButton();
        }

        [Then(@"I am shown the registration details page with the new registration details")]
        public void ThenIAmShownTheRegistrationDetailsPageWithTheNewRegistrationDetails()
        {
            string expectedName = Constants.ManualRegFirstName + " " + Constants.ManualRegLastName;
            //Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(Constants.ManualRegULN));
            RegistrationsSearchPage.VerifyProvider(Constants.ManualRegUpdatedProvider);
            RegistrationsSearchPage.VerifyCore(Constants.ManualRegUpdatedCore);
            RegistrationsSearchPage.VerifySpecialism(Constants.ManualRegUpdatedSpecialism);
            RegistrationsSearchPage.VerifyName(expectedName);
            RegistrationsSearchPage.VerifyDOBChangesAreDisplayed(Constants.ManualRegDOBDay, Constants.ManualRegDOBMonth, Constants.ManualRegDOBYear);
            RegistrationsSearchPage.VerifyActiveYear();
        }

    }
}
