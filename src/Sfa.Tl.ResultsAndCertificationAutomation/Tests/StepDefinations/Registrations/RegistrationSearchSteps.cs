using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationSearchSteps : RegistrationsManualPage
    {

        private readonly ScenarioContext _scenarioContext;

        public RegistrationSearchSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [When(@"I click on BackToRegistration button")]
        public void WhenIClickOnBackToRegistrationButton()
        {
            ClickBackToRegistrations();
        }

        [When(@"I click on Search For A registration link")]
        public void WhenIClickOnSearchForARegistrationLink()
        {
            SqlQueries.DeleteFromRegistrationTables();
            RegistrationsPage.ClickRegLink(); 
            ClickSearchForRegistrationLink();
        }

        [Then(@"the Search for a registration page is displayed")]
        public void ThenTheSearchForARegistrationPageIsDisplayed()
        {
            VerifyRegistrationSearchPage();
        }


        [Then(@"I enter (.*) as a valid ULN which is not registered and press enter")]
        public void ThenIEnterAsAValidULNWhichIsNotRegisteredAndPressEnter(String ULN)
        {
            _scenarioContext["_ULN"] = ULN;
            EnterSearchUln(ULN);
            ClickSearchButton();
        }


        [Then(@"I am shown the ULN cannot be found page")]
        public void ThenIAmShownTheULNCannotBeFoundPage()
        {
            String ULN = (String)_scenarioContext["_ULN"];
            VerifyURLNotFoundPage(ULN);
        }


        [Then(@"I enter (.*) as an invalid ULN which is not registered and press enter")]
        public void ThenIEnterAsAnInvalidULNWhichIsNotRegisteredAndPressEnter(string ULN)
        {
            EnterSearchUln(ULN);
            ClickSearchButton();
        }

        [Then(@"I press enter on Search for a registration page")]
        public void ThenIPressEnterOnSearchForARegistrationPage()
        {
            ClickSearchButton();
        }

                [Then(@"when I click the back link")]
        public void ThenWhenIClickTheBackLink()
        {
            ClickBackLink_ULNNotFoundPage();
        }

        [Then(@"the Registration Search page is displayed with the ULN field still populated with (.*)")]
        public void ThenTheRegistrationSearchPageIsDisplayedWithTheULNFieldStillPopulatedWith(string ULN)
        {
            VerifyRegistrationSearchPage();
            VerifyULNFieldIsPopulated(ULN);
        }



        [When(@"I click Search For A registration link")]
        public void WhenIClickSearchForARegistrationLink()
        {
           // RegistrationsPage.ClickRegLink();
            ClickSearchForRegistrationLink();
        }


        [When(@"I click the Registrations link in the breadcrumbs")]
        public void WhenIClickTheRegistrationsLinkInTheBreadcrumbs()
        {
            SearchReg_ClickRegistrationsBCLink();
        }

        [When(@"I click the Home link in the breadcrumbs")]
        public void WhenIClickTheHomeLinkInTheBreadcrumbs()
        {
            SearchReg_ClickHomeBCLink();
        }

        [Then(@"I will be shown the Registrations dashboard page")]
        public void ThenIWillBeShownTheRegistrationsDashboardPage()
        {
            RegistrationsPage.VerifyRegistrationDashboardPage();
        }

        [Then(@"I will be shown the Tlevel dashboard page")]
        public void ThenIWillBeShownTheTlevelDashboardPage()
        {
            TlevelDashboardPage.VerifyDashboardpage();
        }









    }
}
