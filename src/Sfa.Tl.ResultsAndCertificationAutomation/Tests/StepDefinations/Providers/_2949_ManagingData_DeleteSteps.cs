using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;


namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2949_ManagingData_DeleteSteps : CrateRegistrationInDb
    {

        private readonly ScenarioContext scenarionContext;

        public _2949_ManagingData_DeleteSteps(ScenarioContext scenarionContext)
        {
            this.scenarionContext = scenarionContext;
        }

        [Given(@"I attempt to delete the registration which has IP data against it")]
        public void GivenIAttemptToDeleteTheRegistrationWhichHasIPDataAgainstIt()
        {
            var uln = scenarionContext["uln"] as string;

            RegistrationsPage.ClickRegLink();
            RegistrationsManualPage.ClickSearchForRegistrationLink();
            RegistrationsSearchPage.SearchForULN(uln);
            RegistrationsSearchPage.VerifySearchResultPage();
            RegistrationsSearchPage.ClickChangeStatusLink();
            RegistrationsActiveOptionPage.ClickDeleteRegistrationRadioButton();
            RegistrationsActiveOptionPage.ClickContinueButton();

        }

        [Given(@"I navigate to the Delete Registration Page")]
        public void GivenINavigateToTheDeleteRegistrationPage()
        {
            var uln = scenarionContext["uln"] as string;

            RegistrationsPage.ClickRegLink();
            RegistrationsManualPage.ClickSearchForRegistrationLink();
            RegistrationsSearchPage.SearchForULN(uln);
            RegistrationsSearchPage.VerifySearchResultPage();
            RegistrationsSearchPage.ClickChangeStatusLink();
            RegistrationsActiveOptionPage.ClickDeleteRegistrationRadioButton();
            RegistrationsActiveOptionPage.ClickContinueButton();
        }


        [Then(@"the Registration cannot be deleted page will be displayed")]
        public void ThenTheRegistrationCannotBeDeletedPageWillBeDisplayed()
        {
            RegistrationCannotBeDeletedPage.VerifyRegistrationCannotBeDeletedPage();
        }

        [Then(@"when I click the back link on the Registration cannot be deleted page")]
        public void ThenWhenIClickTheBackLinkOnTheRegistrationCannotBeDeletedPage()
        {
            RegistrationCannotBeDeletedPage.ClickBackLink();
        }

        [Then(@"when I click the back to registration details button")]
        public void ThenWhenIClickTheBackToRegistrationDetailsButton()
        {
            RegistrationCannotBeDeletedPage.ClickBackToRegistrationDetailsBtn();
        }

        [Given(@"I directly navigate to the Registration cannot be deleted page")]
        public void GivenIDirectlyNavigateToTheRegistrationCannotBeDeletedPage()
        {
            WebDriver.Navigate().GoToUrl("https://test.manage-tlevel-results.tlevels.gov.uk/registration-cannot-be-deleted");
        }

        [Then(@"I am shown the Active options page")]
        public void ThenIAmShownTheActiveOptionsPage()
        {
            RegistrationsActiveOptionPage.VerifyAmendActiveRegistrationPage();
        }

        [Then(@"I am shown the Registration Details page")]
        public void ThenIAmShownTheRegistrationDetailsPage()
        {
            RegistrationsSearchPage.VerifySearchResultPage();
        }

        [Given(@"I add IP data in parallel to the registration")]
        public void GivenIAddIPDataInParallelToTheRegistration()
        {
            var uln = scenarionContext["uln"] as string;
            CreateIndustryPlacementRecord(uln);
        }

        [Given(@"I press Continue on the Delete Registration Page")]
        public void GivenIPressContinueOnTheDeleteRegistrationPage()
        {
            //
        }

    }
}
