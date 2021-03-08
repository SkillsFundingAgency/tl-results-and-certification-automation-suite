using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class _2414_UpdatingDataWithResultsRe_Activate_ManualSteps : ElementHelper
    {

        private readonly ScenarioContext scenarionContext;

        public _2414_UpdatingDataWithResultsRe_Activate_ManualSteps(ScenarioContext scenarionContext)
        {
            this.scenarionContext = scenarionContext;
        }


        [Given(@"I successfully change the grade to E")]
        public void GivenISuccessfullyChangeTheGradeToE()
        {
            
            ResultsChangeCoreGradePage.SelectEResult();
        }

        [Given(@"I withdraw the registration and reactivate it")]
        public void GivenIWithdrawTheRegistrationAndReactivateIt()
        {
            var uln = scenarionContext["uln"] as string;
          
            WebDriver.FindElement(ResultsDashboardPage.BackToResultsBtn).Click();
            ResultsLearnersResultsPage.ClickHomeBreadcrumb();
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

            ResultsDashboardPage.ClickResultsLink();
            ResultsDashboardPage.searchResult(uln);
       
        }

        [Given(@"I maximise the browser window")]
        public void GivenIMaximiseTheBrowserWindow()
        {
            ResultsLearnersResultsPage.MaximiseWindow();
        }


        [Then(@"the reactivated registration will display the grade as ""(.*)""")]
        public void ThenTheReactivatedRegistrationWillDisplayTheGradeAs(string ExpectedGrade)
        {
            var uln = scenarionContext["uln"] as string;
            int GradeCount = SqlQueries.ReturnLastActiveGradeCount(uln);
        
            if (GradeCount == 0)
            {

                string ExpectedDBGrade = "Grade: Not received";
                Console.WriteLine(ExpectedDBGrade);
                ResultsLearnersResultsPage.VerifyGradeText(ExpectedGrade);
                //This checks the last active grade on the database matches the grade shown against the registration
                ResultsLearnersResultsPage.VerifyGradeText(ExpectedDBGrade);
            }
            else
            {
                string ExpectedDBGrade = "Grade: " + SqlQueries.ReturnLastActiveGrade(uln);
                Console.WriteLine(ExpectedDBGrade);
                ResultsLearnersResultsPage.VerifyGradeText(ExpectedGrade);
                //This checks the last active grade on the database matches the grade shown against the registration
                ResultsLearnersResultsPage.VerifyGradeText(ExpectedDBGrade);
            }

           
        }

        [Given(@"I successfully remove the grade")]
        public void GivenISuccessfullyRemoveTheGrade()
        {
            ResultsChangeCoreGradePage.SelectNoResult();
        }

        [Then(@"the registration for this test is deleted")]
        public void ThenTheRegistrationForThisTestIsDeleted()
        {
            var uln = scenarionContext["uln"] as string;
            CrateRegistrationInDb createReg = new CrateRegistrationInDb();
            createReg.DeleteRegistrationFromTables(uln);
        }

    }
}
