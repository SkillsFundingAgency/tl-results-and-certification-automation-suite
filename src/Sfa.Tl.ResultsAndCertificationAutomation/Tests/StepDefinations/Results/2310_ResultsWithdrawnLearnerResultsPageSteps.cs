using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class _2310CreateLearnerSResultsPageWithdrawnLearnerSteps : AssessmentEntriesPage
    {
        [When(@"I withdraw my application and navigate to the Results Search for a Learner Page")]
        public void WhenIWithdrawMyApplicationAndNavigateToTheResultsSearchForALearnerPage()
        {
            RegistrationsPage.ClickElement(RegistrationsSearchPage.SearchRegistrationLink);
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
            RegistrationsSearchPage.PressHomeBreadcrumb();
            ClickLinkByLabel("Results");
            ClickLinkByLabel("Search for a learner");

        }
        
        [When(@"I search for the (.*) which is withdrawn")]
        public void WhenISearchForTheWhichIsWithdrawn(string ULN)
        {
            ResultsSearchForALearnerPage.EnterULN(ULN);
            
        }


        [Then(@"the Learners Results for Withdrawn Learner page will be displayed for the (.*)")]
        public void ThenTheLearnersResultsForWithdrawnLearnerPageWillBeDisplayedForThe(string ULN)
        {
            ResultsLearnersResultsWithdrawnLearnerPage.VerifyWithdrawnLearnersResultsPage(ULN, Constants.ManualRegFirstName, Constants.ManualRegLastName, RegistrationsManualPage.InputPovider);

        }

        [When(@"I click the Search again link on the Learners Results page")]
        public void WhenIClickTheSearchAgainLinkOnTheLearnersResultsPage()
        {
            ResultsLearnersResultsWithdrawnLearnerPage.ClickSearchAgainLink();
        }

        [Then(@"the ULN Search field will be empty")]
        public void ThenTheULNSearchFieldWillBeEmpty()
        {
            ResultsSearchForALearnerPage.VerifySearchFieldIsEmpty();
        }

        [When(@"I click the Search for a learner breadcrumb link")]
        public void WhenIClickTheSearchForALearnerBreadcrumbLink()
        {
            ResultsLearnersResultsWithdrawnLearnerPage.ClickSearchAgainLink();
        }

        [When(@"I navigate back to the Learners Results Page \(Withdrawn\) page using (.*) from the Results Search for a Learner page")]
        public void WhenINavigateBackToTheLearnersResultsPageWithdrawnPageUsingFromTheResultsSearchForALearnerPage(string ULN)
        {
            ResultsSearchForALearnerPage.EnterULN(ULN);
        }

        [When(@"I press the Results breadcrumb link")]
        public void WhenIPressTheResultsBreadcrumbLink()
        {
            ResultsLearnersResultsWithdrawnLearnerPage.ClickResultsBreadcrumb();
        }

        [When(@"I navigate back to the Learners Results Page \(Withdrawn\) page for (.*) from the Results dashboard page")]
        public void WhenINavigateBackToTheLearnersResultsPageWithdrawnPageForFromTheResultsDashboardPage(string ULN)
        {
            ClickLinkByLabel("Search for a learner");
            ResultsSearchForALearnerPage.EnterULN(ULN);
        }

        [When(@"I click the Home breadcrumb link")]
        public void WhenIClickTheHomeBreadcrumbLink()
        {
            ResultsLearnersResultsWithdrawnLearnerPage.ClickHomeBreadcrumb();
        }




    }
}
