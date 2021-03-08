using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class _1932_UpdateRegistrationDetailsPageSteps
    {
        [Then(@"there will not be a View and amend this learner's assessment entries link on the Withdrawn registration deals page")]
        public void ThenThereWillNotBeAViewAndAmendThisLearnerSAssessmentEntriesLinkOnTheWithdrawnRegistrationDealsPage()
        {
            RegistrationsSearchPage.VerifyViewLearnersAssessmentEntriesLinkNotPresent();
            SqlQueries.DeleteFromRegistrationTables();
        }

        [Given(@"I click the View and amend this learner's assessment entries link")]
        public void GivenIClickTheViewAndAmendThisLearnerSAssessmentEntriesLink()
        {
            RegistrationsSearchPage.ClickViewAndAmendLearnersAssessmentEntriesLink();
        }
    }
}
