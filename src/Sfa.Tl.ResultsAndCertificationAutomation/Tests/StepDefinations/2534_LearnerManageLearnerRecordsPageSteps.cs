using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class _2534_LearnerManageLearnerRecords
    {
        [Then(@"I am shown the Manage Learner Records page")]
        public void ThenIAmShownTheManageLearnerRecordsPage()
        {
            LearnerManageLearnerRecordsPage.VerifyManageLearnerRecordsPage();
        }

        [Given(@"I navigate to the Manage Learner Records page")]
        public void GivenINavigateToTheManageLearnerRecordsPage()
        {
            TlevelDashboardPage.ClickManageLearnerRecordsLink();
        }

        [Then(@"the page headings, page text URL and title will match the expected values for the Manage Learner Records page")]
        public void ThenThePageHeadingsPageTextURLAndTitleWillMatchTheExpectedValuesForTheManageLearnerRecordsPage()
        {
            LearnerManageLearnerRecordsPage.VerifyManageLearnerRecordsPage();
        }

        [Given(@"I press the home breadcrumb on the Manage Learner Record page")]
        public void GivenIPressTheHomeBreadcrumbOnTheManageLearnerRecordPage()
        {
            LearnerManageLearnerRecordsPage.ClickHomeLink();
        }


        [Then(@"there will be two box options '(.*)' and '(.*)'")]
        public void ThenThereWillBeTwoBoxOptionsAnd(string ExpectedAddLearnerRecordLinkText, string ExpectedUpdateALearnerRecordLinkText)
        {
            LearnerManageLearnerRecordsPage.VerifyBoxText(ExpectedAddLearnerRecordLinkText, ExpectedUpdateALearnerRecordLinkText);
        }

    }
}
