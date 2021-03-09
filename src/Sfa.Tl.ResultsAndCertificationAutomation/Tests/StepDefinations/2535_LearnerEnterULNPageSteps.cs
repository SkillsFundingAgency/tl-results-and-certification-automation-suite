using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;


namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class _2535EnterULNPageSteps
    {
        [Given(@"I click on the Manage Learner Records link")]
        public void GivenIClickOnTheManageLearnerRecordsLink()
        {
            TlevelDashboardPage.ClickManageLearnerRecordsLink();
            
        }

        [Given(@"I navigate to the Enter ULN page for Add a new learner")]
        public void GivenINavigateToTheEnterULNPageForAddANewLearner()
        {
            TlevelDashboardPage.ClickManageLearnerRecordsLink();
            LearnerManageLearnerRecordsPage.ClickAddANewLearnerRecordLink();
        }

        [Then(@"the page headings, page text URL and title will match the expected values")]
        public void ThenThePageHeadingsPageTextURLAndTitleWillMatchTheExpectedValues()
        {
            LearnerAddLearnerPage.VerifyAddANewLearnerRecordPage();
        }


        [Then(@"I enter a ULN on the Enter ULN page of (.*)")]
        public void ThenIEnterAULNOnTheEnterULNPageOf(string ULN)
        {
            LearnerAddLearnerPage.EnterULN(ULN);
        }


        [Given(@"I press Continue without entering a ULN")]
        public void GivenIPressContinueWithoutEnteringAULN()
        {
            LearnerAddLearnerPage.PressContinueButton();
        }
        
        
        [Then(@"I am shown an error message on the Enter ULN page stating ""(.*)""")]
        public void ThenIAmShownAnErrorMessageOnTheEnterULNPageStating(string ErrorMessage)
        {
            LearnerAddLearnerPage.VerifyErrorMessage(ErrorMessage);
        }

        [Given(@"I click the back link on the Enter ULN page for Add a new learner")]
        public void GivenIClickTheBackLinkOnTheEnterULNPageForAddANewLearner()
        {
            LearnerAddLearnerPage.ClickBackLink();
        }
    }
}
