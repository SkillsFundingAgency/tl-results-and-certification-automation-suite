using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class TLRC2001_AssessmentEntriesWithdrawnLearnerPageSteps : AssessmentEntriesPage
    {
        [Then(@"I am shown the Assessment Entries Withdrawn Learner page")]
        public void ThenIAmShownTheAssessmentEntriesWithdrawnLearnerPage()
        {
            AssessmentEntriesWithdrawnLearnerPage.VerifyAssessmentEntriesWithdrawnLearnerPage();
            AssessmentEntriesWithdrawnLearnerPage.VerifyDynamicHeaders();

        }

        [When(@"I click the Search again link")]
        public void WhenIClickTheSearchAgainLink()
        {
             AssessmentEntriesWithdrawnLearnerPage.PressSearchAgain();
        }

        [When(@"I click the View this learner’s registration details’ link")]
        public void WhenIClickTheViewThisLearnerSRegistrationDetailsLink()
        {
          AssessmentEntriesWithdrawnLearnerPage.PressViewLearnersRegistrationDetailsLink();
        }

        [Then(@"I am taken to the Registrations Details page of the given withdrawn learner")]
        public void ThenIAmTakenToTheRegistrationsDetailsPageOfTheGivenWithdrawnLearner()
        {
            RegistrationsSearchPage.VerifySearchResultPage();
        }

        [Then(@"the Search for a learner page search entry will not be retained")]
        public void ThenTheSearchForALearnerPageSearchEntryWillNotBeRetained()
        {
            AssessmentEntriesSearchForLearnerPage.VerifyULNSearchFieldIsEmpty();
            SqlQueries.DeleteFromRegistrationTables();
        }

        [Then(@"I press the Assessment Entries breadcrumb link on the Assessment Entries Withdrawn Learner page")]
        public void ThenIPressTheAssessmentEntriesBreadcrumbLinkOnTheAssessmentEntriesWithdrawnLearnerPage()
        {
            AssessmentEntriesWithdrawnLearnerPage.PressAssessmentEntriesBreadcrumb();
        }

        [Given(@"I press the Home breadcrumb link on the Assessment Entries Withdrawn Learner page")]
        public void GivenIPressTheHomeBreadcrumbLinkOnTheAssessmentEntriesWithdrawnLearnerPage()
        {
            AssessmentEntriesWithdrawnLearnerPage.PressHomeBreadcrumb();
        }

        [Given(@"I press the Search for a learner breadcrumb link on the Assessment Entries Withdrawn Learner page")]
        public void GivenIPressTheSearchForALearnerBreadcrumbLinkOnTheAssessmentEntriesWithdrawnLearnerPage()
        {
            AssessmentEntriesWithdrawnLearnerPage.PressSearchForALearnerBreadcrumb();
        }

    }
}
