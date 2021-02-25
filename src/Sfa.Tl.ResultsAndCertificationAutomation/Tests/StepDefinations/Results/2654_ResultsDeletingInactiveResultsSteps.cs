using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Hooks;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using NUnit.Framework;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class _2654_DeletingInactiveResultsSteps : ElementHelper
    {
        private readonly ScenarioContext scenarionContext;

        public _2654_DeletingInactiveResultsSteps(ScenarioContext scenarionContext)
        {
            this.scenarionContext = scenarionContext;
        }


        //[Given(@"I attempt to delete an active registration with an active result")]
        //public void GivenIAttemptToDeleteAnActiveRegistrationWithAnActiveResult()
        //{
        //    var uln = scenarionContext["uln"] as string;
        //    WebDriver.FindElement(ResultsDashboardPage.BackToResultsBtn).Click();
        //    ResultsLearnersResultsPage.ClickHomeBreadcrumb();
        //    RegistrationsPage.ClickRegLink();
        //    RegistrationsManualPage.ClickSearchForRegistrationLink();
        //    RegistrationsSearchPage.SearchForULN(uln);
        //    RegistrationsSearchPage.VerifySearchResultPage();
        //    RegistrationsSearchPage.ClickChangeStatusLink();
        //    RegistrationDeletePage.ClickElement(RegistrationDeletePage.DeleteRadioBtn);
        //    RegistrationDeletePage.ClickElement(RegistrationDeletePage.ContinueBtn);

        //    int PAID = SqlQueries.RetrievePathwayAssessmentID(uln);
        //    SqlQueries.CreatePathwayResult(PAID);

        //    RegistrationsActiveOptionPage.YesToCancelReg();
        //}

        [When(@"I select continue on the Are you sure page")]
        public void WhenISelectContinueOnTheAreYouSurePage()
        {
            RegistrationsActiveOptionPage.YesToCancelReg();
        }


        [When(@"I refresh the browser")]
        public void WhenIRefreshTheBrowser()
        {
           WebDriver.Navigate().Refresh();
        }


        [Given(@"I attempt to delete an active registration without an active result however someone else has just added a result")]
        public void GivenIAttemptToDeleteAnActiveRegistrationWithoutAnActiveResultHoweverSomeoneElseHasJustAddedAResult()
        {
            var uln = scenarionContext["uln"] as string;
            WebDriver.FindElement(ResultsDashboardPage.BackToResultsBtn).Click();
            ResultsLearnersResultsPage.ClickHomeBreadcrumb();
            RegistrationsPage.ClickRegLink();
            RegistrationsManualPage.ClickSearchForRegistrationLink();
            RegistrationsSearchPage.SearchForULN(uln);
            RegistrationsSearchPage.VerifySearchResultPage();
            RegistrationsSearchPage.ClickChangeStatusLink();
            RegistrationDeletePage.ClickElement(RegistrationDeletePage.DeleteRadioBtn);
            RegistrationDeletePage.ClickElement(RegistrationDeletePage.ContinueBtn);

            int PAID = SqlQueries.RetrievePathwayAssessmentID(uln);
            SqlQueries.CreatePathwayResult(PAID);

            //RegistrationsActiveOptionPage.YesToCancelReg();
        }


        [Given(@"I attempt to delete an active registration without an active result")]
        public void GivenIAttemptToDeleteAnActiveRegistrationWithoutAnActiveResult()
        {
            var uln = scenarionContext["uln"] as string;
            WebDriver.FindElement(ResultsDashboardPage.BackToResultsBtn).Click();
            ResultsLearnersResultsPage.ClickHomeBreadcrumb();
            RegistrationsPage.ClickRegLink();
            RegistrationsManualPage.ClickSearchForRegistrationLink();
            RegistrationsSearchPage.SearchForULN(uln);
            RegistrationsSearchPage.VerifySearchResultPage();
            RegistrationsSearchPage.ClickChangeStatusLink();
            RegistrationDeletePage.ClickElement(RegistrationDeletePage.DeleteRadioBtn);
            RegistrationDeletePage.ClickElement(RegistrationDeletePage.ContinueBtn);
            RegistrationsActiveOptionPage.YesToCancelReg();
        }

        [Then(@"I will be shown the Problem with service page")]
        public void ThenIWillBeShownTheProblemWithServicePage()
        {
            PageHelper.VerifyPageUrl(WebDriver.Url, StartPage.ExpectedError500);
            Assert.AreEqual(Constants.Error500, WebDriver.FindElement(By.XPath("//*[@id='main-content']//h1")).Text);
        }


        [Then(@"the registration is deleted along with all previous inactive results")]
        public void ThenTheRegistrationIsDeletedAlongWithAllPreviousInactiveResults()
        {

            var uln = scenarionContext["uln"] as string;
            RegistrationDeletePage.VerifyDeleteConfirmationPage();
            int Records = SqlQueries.VerifyRegistrationDeleted(uln);
            Assert.AreEqual(Records,0);
        }
    }
}
