using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2695_SearchForALearnerPageSteps : CrateRegistrationInDb
    {
        [Given(@"I navigate to the Manage Learner Record Search for a learner page")]
        public void GivenINavigateToTheManageLearnerRecordSearchForALearnerPage()
        {

            TlevelDashboardPage.ClickManageLearnerRecordsLink();
            LearnerManageLearnerRecordsPage.ClickUpdateLearnerRecordLink();

            LearnerSearchForLearnerPage.VerifySearchForALearnerPage();
        }

        [Given(@"I click the Home breadcrumb on the  Manage Learner Record Search for a learner page")]
        public void GivenIClickTheHomeBreadcrumbOnTheManageLearnerRecordSearchForALearnerPage()
        {
            LearnerSearchForLearnerPage.ClickHomeBreadcrumb();
        }

        [Given(@"I press the Manage learner records breadcrumb on the  Manage Learner Record Search for a learner page")]
        public void GivenIPressTheManageLearnerRecordsBreadcrumbOnTheManageLearnerRecordSearchForALearnerPage()
        {
            LearnerSearchForLearnerPage.ClickManageLearnerRecordsBreadcrumb();
        }

        [Then(@"I am shown the Manage learner records page")]
        public void ThenIAmShownTheManageLearnerRecordsPage()
        {
            LearnerManageLearnerRecordsPage.VerifyManageLearnerRecordsPage();
        }

        [Then(@"the error message ""(.*)"" is shown on the Manage learner records Search for a learner page")]
        public void ThenTheErrorMessageIsShownOnTheManageLearnerRecordsSearchForALearnerPage(string ErrorMessage)
        {
            LearnerSearchForLearnerPage.VerifyErrorMessage(ErrorMessage);
        }

        [When(@"I enter ""(.*)"" in the Search ULN box and click Search")]
        public void WhenIEnterInTheSearchULNBoxAndClickSearch(string ULN)
        {
            LearnerSearchForLearnerPage.EnterULN(ULN);
        }

        [Then(@"the error message ""(.*)"" is shown on the Manage learner Search for a learner page")]
        public void ThenTheErrorMessageIsShownOnTheManageLearnerSearchForALearnerPage(string ErrorMessage)
        {
            LearnerSearchForLearnerPage.VerifyErrorMessage(ErrorMessage);
        }

    }
}
