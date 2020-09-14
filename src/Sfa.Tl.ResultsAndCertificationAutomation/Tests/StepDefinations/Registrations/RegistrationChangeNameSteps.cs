using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationChangeNameSteps
    {

        private readonly ScenarioContext scenarionContext;

        public RegistrationChangeNameSteps(ScenarioContext scenarionContext)
        {
            this.scenarionContext = scenarionContext;
        }


        [Then(@"I am shown the Change Details Name page defaulted with the name registered to the ULN")]
        public void ThenIAmShownTheChangeDetailsNamePageDefaultedWithTheNameRegisteredToTheULN()
        {
            RegistrationChangeNamePage.VerifyChangeNamePageDetails();
            RegistrationChangeNamePage.VerifyNameFieldsArePrePopulated();
        }


        [When(@"I click the Back link")]
        public void WhenIClickTheBackLink()
        {
            RegistrationChangeNamePage.ClickBackLink();
        }

        [When(@"press the change link without making amendments to the name")]
        public void WhenPressTheChangeLinkWithoutMakingAmendmentsToTheName()
        {
            RegistrationChangeNamePage.ClickChangeButton();
        }



        [Then(@"I will be directed to the Registration Details page")]
        public void ThenIWillBeDirectedToTheRegistrationDetailsPage()
        {
            RegistrationsSearchPage.VerifySearchResultPage();
        }

        [When(@"I clear the name fields and press Change")]
        public void WhenIClearTheNameFieldsAndPressChange()
        {
            RegistrationChangeNamePage.EnterNullNames();
        }


          [When(@"I enter only the first name and press Change")]
        public void WhenIEnterOnlyTheFirstNameAndPressChange()
        {
            RegistrationChangeNamePage.EnterFirstNameOnly();
        }


        [Then(@"I am shown an error for missing last name stating ""(.*)""")]
        public void ThenIAmShownAnErrorForMissingLastNameStating(string p0)
        {
            RegistrationChangeNamePage.AssertLastNameEmptyErrorMessage();
        }

        [Then(@"I am shown an error for null name fields stating ""(.*)"" and ""(.*)""")]
        public void ThenIAmShownAnErrorForNullNameFieldsStatingAnd(string p0, string p1)
        {
            RegistrationChangeNamePage.AssertBothNamesEmptyErrorMessages();
        }

        [When(@"I enter only the last name and press Change")]
        public void WhenIEnterOnlyTheLastNameAndPressChange()
        {
            RegistrationChangeNamePage.EnterLastNameOnly();
        }


        [Then(@"I am shown an error formissing first name stating ""(.*)""")]
        public void ThenIAmShownAnErrorFormissingFirstNameStating(string p0)
        {
            RegistrationChangeNamePage.AssertFirstNameEmptyErrorMessage();
        }


        [When(@"I enter a first name greater than (.*) characters and press Change")]
        public void WhenIEnterAFirstNameGreaterThanCharactersAndPressChange(int p0)
        {
            RegistrationChangeNamePage.EnterFirstNameOnly();
        }

        [When(@"I enter a last name and first name greater than (.*) characters and press Change")]
        public void WhenIEnterALastNameAndFirstNameGreaterThanCharactersAndPressChange(int p0)
        {
            RegistrationChangeNamePage.EnterNamesGreaterThan100Characters();
        }

        [Then(@"I am shown an error stating ""(.*)"" and ""(.*)""")]
        public void ThenIAmShownAnErrorStatingAnd(string p0, string p1)
        {
            RegistrationChangeNamePage.AssertLongNamesErrorMessage();
        }


        [When(@"I capture the Change Name URL")]
        public void WhenICaptureTheChangeNameURL()
        {
            scenarionContext["PageURL"] = RegistrationChangeNamePage.CapturePageURL();
            
        }

        [When(@"I cancel the registration")]
        public void WhenICancelTheRegistration()
        {
            RegistrationChangeDOBPage.ClickBackLink();
            RegistrationsSearchPage.ClickCancelRegistration();
            RegistrationsSearchPage.YesToCancelReg();

        }

        [When(@"I attempt to access the Change Name page using the captured URL")]
        public void WhenIAttemptToAccessTheChangeNamePageUsingTheCapturedURL()
        {
          RegistrationChangeNamePage.NavigateToBookmarkedPage(scenarionContext["PageURL"].ToString());
        }

        [Then(@"I am shown the Page Not Found page")]
        public void ThenIAmShownThePageNotFoundPage()
        {
            RegistrationChangeNamePage.AssertPageNotFoundPageDisplayed();
        }


        [When(@"I change the first and last name to (.*) (.*) and press Change")]
        public void WhenIChangeTheFirstAndLastNameToAndPressChange(string FirstName, string LastName)
        {
            RegistrationChangeNamePage.EnterValidNames(FirstName, LastName);
        }



        [Then(@"I am shown the Registration Change Success Page")]
        public void ThenIAmShownTheRegistrationChangeSuccessPage()
        {
           
            RegistrationChangeSuccessPage.VerifyRegistrationChangeSuccessPage();
        }


        [Given(@"I create a manual registration")]
        public void GivenICreateAManualRegistration()
        {
            RegistrationsManualPage.CreateRegistrationWithSpecialism(Constants.ManualRegULN,Constants.ManualRegFirstName, Constants.ManualRegLastName, Constants.ManualRegDOBDay, Constants.ManualRegDOBMonth, Constants.ManualRegDOBYear);
            RegistrationsManualPage.ClickSubmit();
            RegistrationsManualPage.ClickElement(RegistrationsPage.BacktoRegistrationLink);
        }

        [Given(@"I search for my registration")]
        public void GivenISearchForMyRegistration()
        {
            RegistrationsPage.ClickElement(RegistrationsSearchPage.SearchRegistrationLink);
            RegistrationsSearchPage.SearchForULN();

        }



    }
}
