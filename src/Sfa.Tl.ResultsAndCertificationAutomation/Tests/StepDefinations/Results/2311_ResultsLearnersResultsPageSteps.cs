using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class _2311_CreateLearnerSResultsPageSteps
    {
        [Given(@"I navigate to the Results Search for a learner page")]
        public void GivenINavigateToTheResultsSearchForALearnerPage()
        {
            AssessmentEntriesPage.ClickBacktoAssessmentEntriesButton();
            AssessmentEntriesLearnersAssessmentEntriesPage.PressHomeBreadcrumb();
        }

        [Given(@"I search for a (.*)")]
        public void GivenISearchForA(string ULN)
        {
            ResultsSearchForALearnerPage.EnterULN(ULN);
        }

        [Then(@"the Learners Results for Withdrawn Learner page will be displayed for (.*)")]
        public void ThenTheLearnersResultsForWithdrawnLearnerPageWillBeDisplayedFor(string ULN)
        {
            ResultsLearnersResultsPage.VerifyLearnersResultsPage();
        }

        [Then(@"the Learners Results page will be displayed for (.*)")]
        public void ThenTheLearnersResultsPageWillBeDisplayedFor(string ULN)
        {
            ResultsLearnersResultsPage.VerifyLearnersResultsPage();
        }


        [Then(@"the Core is displayed as ""(.*)""")]
        public void ThenTheCoreIsDisplayedAs(string CoreText)
        {
            ResultsLearnersResultsPage.VerifyCore(CoreText);
        }

        [Then(@"Specialism is displayed as ""(.*)""")]
        public void ThenSpecialismIsDisplayedAs(string SpecialismText)
        {
            ResultsLearnersResultsPage.VerifySpecialismAdded(SpecialismText);
        }

        [Then(@"the text below the Core will display ""(.*)""")]
        public void ThenTheTextBelowTheCoreWillDisplay(string AssessmentEntryText)
        {
            ResultsLearnersResultsPage.VerifyCoreAssessmentEntryText(AssessmentEntryText);
        }

        [Then(@"the text below the Specialism will display ""(.*)""")]
        public void ThenTheTextBelowTheSpecialismWillDisplay(string AssessmentEntryText)
        {
            ResultsLearnersResultsPage.VerifySpecialismAssessmentEntryText(AssessmentEntryText);
        }

        [Then(@"I will be shown the Assessments Upload success page")]
        public void ThenIWillBeShownTheAssessmentsUploadSuccessPage()
        {
            AssessmentEntriesPage.VerifyAssessmentUploadSuccessPage();
        }

        [Given(@"I initially clear the database")]
        public void GivenIInitiallyClearTheDatabase()
        {
            Data.SqlQueries.DeleteFromRegistrationTables();
        }

        [Then(@"there will no text below the Specialism")]
        public void ThenThereWillNoTextBelowTheSpecialism()
        {
            ResultsLearnersResultsPage.VerifyAssessmentEntryTextNotPresent();
        }

        [Then(@"the text below the Core will display the assessment series as ""(.*)"" and ""(.*)""")]
        public void ThenTheTextBelowTheCoreWillDisplayTheAssessmentSeriesAsAnd(string Series, string Grade)
        {
            ResultsLearnersResultsPage.VerifyAssessmenSeriesText(Series,Grade);
        }

        [Then(@"""(.*)"" link is displayed")]
        public void ThenLinkIsDisplayed(string AddEntryLink)
        {
            ResultsLearnersResultsPage.VerifyAddEntryLink(AddEntryLink);
        }


        [When(@"I click the Search for a Learner breadcrumb link on the Learner's results page")]
        public void WhenIClickTheSearchForALearnerBreadcrumbLinkOnTheLearnerSResultsPage()
        {
            ResultsLearnersResultsPage.ClickSearchAgainBreadcrumb();
        }

        [Given(@"I navigate back to the Results Learners Results page from the Results Search for a learner page using (.*) and click the Results breadcrumb")]
        public void GivenINavigateBackToTheResultsLearnersResultsPageFromTheResultsSearchForALearnerPageUsingAndClickTheResultsBreadcrumb(string ULN)
        {
            ResultsSearchForALearnerPage.EnterULN(ULN);
        }

        [Given(@"I click the Results breadcrumb link")]
        public void GivenIClickTheResultsBreadcrumbLink()
        {
            ResultsSearchForALearnerPage.ClickResultsBreadcrumb();
        }

        
        [Given(@"I navigate back to the Results Learners Results page from the Results dashboard using (.*) and click the Home breadcrumb")]
        public void GivenINavigateBackToTheResultsLearnersResultsPageFromTheResultsDashboardUsingAndClickTheHomeBreadcrumb(string ULN)
        {
            AssessmentEntriesPage.ClickLinkByLabel("Manage a result");
            ResultsSearchForALearnerPage.EnterULN(ULN);
        }

        [Given(@"I click the Home breadcrumb link")]
        public void GivenIClickTheHomeBreadcrumbLink()
        {
            ResultsSearchForALearnerPage.ClickHomeBreadcrumb();
        }

        [When(@"I click the Search again link on the Results Learners Results page")]
        public void WhenIClickTheSearchAgainLinkOnTheResultsLearnersResultsPage()
        {
            ResultsLearnersResultsPage.ClickSearchAgainLink();
        }




    }
}
