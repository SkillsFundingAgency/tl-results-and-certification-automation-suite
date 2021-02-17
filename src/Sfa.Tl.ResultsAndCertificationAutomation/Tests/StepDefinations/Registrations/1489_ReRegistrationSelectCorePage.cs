using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Features.Registrations
{
    [Binding]
    public class CreateSelectCorePageRe_Register_Story1489Steps : RegistrationReactivateChangeCorePage
    {


        private readonly ScenarioContext scenarionContext;

        public CreateSelectCorePageRe_Register_Story1489Steps(ScenarioContext scenarionContext)
        {
            this.scenarionContext = scenarionContext;
        }


        [Given(@"I create a new registration which I subsequently withdraw")]
        public void GivenICreateANewRegistrationWhichISubsequentlyWithdraw()
        {
            SqlQueries.DeleteFromRegistrationTables();
            RegistrationsManualPage.AddNewRegistrations();
            RegistrationsManualPage.CreateRegistrationWithSpecialism(Constants.ManualRegULN, Constants.ManualRegFirstName, Constants.ManualRegLastName, Constants.ManualRegDOBDay, Constants.ManualRegDOBMonth, Constants.ManualRegDOBYear);
            RegistrationsManualPage.ClickSubmit();
            ClickElement(RegistrationsPage.BacktoRegistrationLink);
            ClickElement(RegistrationsSearchPage.SearchRegistrationLink);
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


        [Given(@"I navigate to the dashboard")]
        public void GivenINavigateToTheDashboard()
        {
           WebDriver.Navigate().GoToUrl(StartPage.StartPageUrl); 
        }

 
        [When(@"I Register the learner on a new course using the same provider")]
        public void WhenIRegisterTheLearnerOnANewCourseUsingTheSameProvider()
        {
            RegistrationsWithdrawOptionsPage.ClickRegisterLearnerNewCourseRadioButton();
            RegistrationsWithdrawOptionsPage.ClickContinueButton();
            RegistrationsManualPage.SelectProviderFromList(RegistrationsManualPage.InputPovider);
            RegistrationsManualPage.ClickContiune();
        }



        [Then(@"I am navigated to the Select the Core Page for reactivate registration")]
        public void ThenIAmNavigatedToTheSelectTheCorePageForReactivateRegistration()
        {
            VerifyRegReactivateChangeCorePageDetails();
            VerifyDropDownListDefaultValue();
            scenarionContext["ReactivateRegChangeCoreURL"] = RegistrationChangeDOBPage.CapturePageURL();
            string URL = scenarionContext["ReactivateRegChangeCoreURL"].ToString();
            Console.WriteLine(URL);
        }


        [When(@"I click the back link on the Reactivate Registration Change Core Page")]
        public void WhenIClickTheBackLinkOnTheReactivateRegistrationChangeCorePage()
        {
            RegistrationReactivateChangeCorePage.ClickBackLink();
        }

        [Then(@"I am navigated to the Reactivate Registration Change Provider page")]
        public void ThenIAmNavigatedToTheReactivateRegistrationChangeProviderPage()
        {
            RegistrationReactivate.VerifyReactivateWithAnotherProviderPage();
            RegistrationReactivateChangeCorePage.VerifyProviderPageDropDownListValue();
        }

        [When(@"I click continue without selecting a dropdown value")]
        public void WhenIClickContinueWithoutSelectingADropdownValue()
        {
            RegistrationReactivateChangeCorePage.ClickContinueButton();
        }

        [Then(@"I am shown an error message on the  Select the Core Page for reactivate registration page stating ""(.*)""")]
        public void ThenIAmShownAnErrorMessageOnTheSelectTheCorePageForReactivateRegistrationPageStating(string ErrorMessage)
        {
            RegistrationReactivateChangeCorePage.VerifyErrorRegReactivateChangeCorePageDetails(ErrorMessage);
        }

        [When(@"I reactivate my registration and attempt to navigate back to the Change Core page using the URL")]
        public void WhenIReactivateMyRegistrationAndAttemptToNavigateBackToTheChangeCorePageUsingTheURL()
        {
            RegistrationReactivateChangeCorePage.ClickBackLink();
            RegistrationReactivate.ClickProviderBackLink();
            RegistrationsWithdrawOptionsPage.VerifyRegistrationsWithdrawOptionsPage();
            RegistrationsWithdrawOptionsPage.ClickReactiveRegistrationRadioButton();
            RegistrationsWithdrawOptionsPage.ClickContinueButton();
            RegistrationReactivate.VerifyAreYouSureReactivatePage();
            RegistrationReactivate.ReactivateApplication();
                       
            NavigateTo(scenarionContext["ReactivateRegChangeCoreURL"].ToString());
        }

        [When(@"I navigate away and attempt to navigate back using the URL")]
        public void WhenINavigateAwayAndAttemptToNavigateBackUsingTheURL()
        {
           
            string URL = scenarionContext["ReactivateRegChangeCoreURL"].ToString();
           
            RegistrationReactivateChangeCorePage.ClickBackLink();
            RegistrationChangeNamePage.NavigateToBookmarkedPage(scenarionContext["ReactivateRegChangeCoreURL"].ToString());
        }

        [Given(@"I press the Home breadcrumb on the registration details page")]
        public void GivenIPressTheHomeBreadcrumbOnTheRegistrationDetailsPage()
        {
            RegistrationsSearchPage.PressHomeBreadcrumb();
        }



    }
}
