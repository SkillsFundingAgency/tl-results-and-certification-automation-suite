using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationChangeDOBSteps
    {

        private readonly ScenarioContext scenarionContext;

        public RegistrationChangeDOBSteps (ScenarioContext scenarionContext)
        {
            this.scenarionContext = scenarionContext;
        }

        [Then(@"I am shown the Change Details DOB page")]
        public void ThenIAmShownTheChangeDetailsDOBPage()
        {
            RegistrationChangeDOBPage.VerifyChangeDOBPageDetails();
        }

        [Then(@"I am shown the Change Details DOB page prepopulated with the DOB registered to the ULN")]
        public void ThenIAmShownTheChangeDetailsDOBPagePrepopulatedWithTheDOBRegisteredToTheULN()
        {
            RegistrationChangeDOBPage.VerifyChangeDOBPageDetails();
            RegistrationChangeDOBPage.VerifyDOBFieldsArePrePopulated();
        }
    



        [When(@"then press Change after making no amendments to the DOB")]
        public void WhenThenPressChangeAfterMakingNoAmendmentsToTheDOB()
        {
            RegistrationChangeDOBPage.ClickChangeButton();
        }

        [When(@"I change the date of birth to (.*) (.*) (.*) and press Change")]
        public void WhenIChangeTheDateOfBirthToAndPressChange(string DD, string MM, string YYYY)
        {
            RegistrationChangeDOBPage.EnterValidDOB(DD,MM,YYYY);
        }



        [When(@"I click the Back link on the Change Details DOB page")]
        public void WhenIClickTheBackLinkOnTheChangeDetailsDOBPage()
        {
            RegistrationChangeDOBPage.ClickBackLink();
        }

        [When(@"I clear the DOB fields and press Change")]
        public void WhenIClearTheDOBFieldsAndPressChange()
        {

            RegistrationChangeDOBPage.EnterNullDOBFields();
        }

        [Then(@"I am shown an error message stating ""(.*)""")]
        public void ThenIAmShownAnErrorMessageStating(string ErrorMessage)
        {
            RegistrationChangeDOBPage.AssertErrorMessage(ErrorMessage);
        }

        [When(@"I enter the day only and press Change")]
        public void WhenIEnterTheDayOnlyAndPressChange()
        {
            RegistrationChangeDOBPage.EnterDayOnly();
        }

        [When(@"I enter the Month only and press Change")]
        public void WhenIEnterTheMonthOnlyAndPressChange()
        {
            RegistrationChangeDOBPage.EnterMonthOnly();
        }

        [When(@"I enter the Year only and press Change")]
        public void WhenIEnterTheYearOnlyAndPressChange()
        {
            RegistrationChangeDOBPage.EnterYearOnly();
        }


        [When(@"I enter the day and month only and press Change")]
        public void WhenIEnterTheDayAndMonthOnlyAndPressChange()
        {
            RegistrationChangeDOBPage.EnterDayAndMonthOnly();
        }

        [When(@"I enter the day and year only and press Change")]
        public void WhenIEnterTheDayAndYearOnlyAndPressChange()
        {
            RegistrationChangeDOBPage.EnterDayAndYearOnly();
        }

        [When(@"I enter the month and year only and press Change")]
        public void WhenIEnterTheMonthAndYearOnlyAndPressChange()
        {
            RegistrationChangeDOBPage.EnterMonthAndYearOnly();
        }

        [When(@"I enter an invalid date and press Change")]
        public void WhenIEnterAnInvalidDateAndPressChange()
        {
            RegistrationChangeDOBPage.EnterInvalidDate();
        }

        [When(@"I capture the Change DOB URL")]
        public void WhenICaptureTheChangeDOBURL()
        {
            scenarionContext["ChangeDOBPageURL"] = RegistrationChangeDOBPage.CapturePageURL();
        }

        [When(@"I enter a DOB in the future and press Change")]
        public void WhenIEnterADOBInTheFutureAndPressChange()
        {
            RegistrationChangeDOBPage.EnterFutureDatedDOB();
        }

        [When(@"I attempt to access the Change DOB page using the captured URL")]
        public void WhenIAttemptToAccessTheChangeDOBPageUsingTheCapturedURL()
        {
            RegistrationChangeDOBPage.NavigateToBookmarkedPage(scenarionContext["ChangeDOBPageURL"].ToString());
        }

        [When(@"I click the Back to Registration button")]
        public void WhenIClickTheBackToRegistrationButton()
        {
            RegistrationChangeSuccessPage.ClickBackToRegistrationsButton();
        }

        [Then(@"I can see the amended date of birth (.*) (.*) (.*) on the Registration Details page")]
        public void ThenICanSeeTheAmendedDateOfBirthOnTheRegistrationDetailsPage(string DD, string MM, string YYYY)
        {
            RegistrationsSearchPage.VerifyDOBChangesAreDisplayed(DD,MM,YYYY);
        }

        [Then(@"I can see the amended name (.*) (.*) on the Registration Details page")]
        public void ThenICanSeeTheAmendedNameOnTheRegistrationDetailsPage(string FirstName, string LastName)
        {
            RegistrationsSearchPage.VerifyNameChangesAreDisplayed(FirstName, LastName);
        }


    }
}
