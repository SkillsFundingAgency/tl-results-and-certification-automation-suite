using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2950_ManagingData_ReactivateSteps : ElementHelper
    {
        private readonly ScenarioContext scenarionContext;

        public _2950_ManagingData_ReactivateSteps(ScenarioContext scenarionContext)
        {
            this.scenarionContext = scenarionContext;
        }

        [Given(@"I change the radio option to ""(.*)""")]
        public void GivenIChangeTheRadioOptionTo(string RadioButtonSelection)
        {
            LearnerHasTheLearnerCompletedIPPage.ClickRadioButton(RadioButtonSelection);
        }
        
 

        [Then(@"the IndustryPlacement table will still have a status value of ""(.*)""")]
        public void ThenTheIndustryPlacementTableWillStillHaveAStatusValueOf(int Status)
        {
            var uln = scenarionContext["uln"] as string;
            int actualStatus = SqlQueries.ReturnIPStatus(uln);
            Assert.AreEqual(actualStatus, Status);

        }

        [Given(@"I click on the Sign Out link")]
        public void GivenIClickOnTheSignOutLink()
        {
            WebDriver.FindElement(TlevelDashboardPage.SignOutLink).Click();
        }

        [Given(@"I withdraw the registration and then reactivate it")]
        public void GivenIWithdrawTheRegistrationAndThenReactivateIt()
        {
            var uln = scenarionContext["uln"] as string;

           
            RegistrationsPage.ClickRegLink();
            RegistrationsManualPage.ClickSearchForRegistrationLink();
            RegistrationsSearchPage.SearchForULN(uln);
            RegistrationsSearchPage.VerifySearchResultPage();

            RegistrationsSearchPage.ClickChangeStatusLink();
            RegistrationsActiveOptionPage.ClickWithdrawRadioButton();
            RegistrationsActiveOptionPage.ClickContinueButton();

            RegistrationsWithdrawRegistrations.WithdrawApplication();
            RegistrationsWithdrawRegistrationsSuccess.ClickViewWithdrawnRegistrationButton();

            RegistrationsSearchPage.ClickChangeStatusLink();
            RegistrationsWithdrawOptionsPage.ClickReactiveRegistrationRadioButton();
            RegistrationsWithdrawOptionsPage.ClickContinueButton();
            RegistrationReactivateAreYouSurePage.ClickYesRadioButton();
            RegistrationReactivateAreYouSurePage.ClickSubmitButton();
            RegistrationReactivate.ClickViewThisRegistrationButton();
            RegistrationsSearchPage.PressHomeBreadcrumb();

        }

        [Given(@"I click Submit button on the Learner CHeck and submit page")]
        public void GivenIClickSubmitButtonOnTheLEarnerCHeckAndSubmitPage()
        {
            LearnerCheckAndSubmitPage.ClickSubmitButton();
        }


    }
}
