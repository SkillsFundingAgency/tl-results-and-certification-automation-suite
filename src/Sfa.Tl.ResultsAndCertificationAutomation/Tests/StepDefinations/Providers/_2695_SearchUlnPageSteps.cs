using System;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using TechTalk.SpecFlow;


namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2695_SearchUlnPageSteps
    {
        [Given(@"I am shown the Search for a learner page")]
        public void GivenIAmShownTheSearchForALearnerPage()
        {
            LearnerSearchForLearnerPage.VerifyLearnerSearchForLearnerPage();
        }

        [Given(@"I press the Manage learner records breadcrumb on the Search for a learner page")]
        public void GivenIPressTheManageLearnerRecordsBreadcrumbOnTheSearchForALearnerPage()
        {
            LearnerSearchForLearnerPage.ClickManageLearnerRecordsBreadcrumb();
        }

        [Then(@"I navigate back to the Search for a learner page")]
        public void ThenINavigateBackToTheSearchForALearnerPage()
        {
            ScenarioContext.Current.Pending();
        }
        

        [When(@"I press the Home breadcrumb link on the Search for a learner page")]
        public void WhenIPressTheHomeBreadcrumbLinkOnTheSearchForALearnerPage()
        {
            LearnerSearchForLearnerPage.ClickHomeBreadcrumb();
        }



        [Then(@"I should see the following error message ""(.*)"" on the Search for a learner page")]
        public void ThenIShouldSeeTheFollowingErrorMessageOnTheSearchForALearnerPage(string ErrorMessage)
        {
            LearnerSearchForLearnerPage.VerifyErrorMessage(ErrorMessage);
        }

        [Then(@"I clear the Search field")]
        public void ThenIClearTheSearchField()
        {
            LearnerSearchForLearnerPage.ClearSearchField();
        }


    }
}
