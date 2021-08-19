using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.TLevelReview;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewJourney
{
    [Binding]
    public class JourneyImprovements_ReviewTLevels_MoreThanOneTLevelSteps
    {
        [When(@"I click the Review new T Levels link on the TLevels dashboard page")]
        public void WhenIClickTheReviewNewTLevelsLinkOnTheTLevelsDashboardPage()
        {
            TLevelJourneyDashboardPage.ClickReviewNewTLevelsLink();
        }
        
        [When(@"I click the TLevels breadcrumb on the Select T Level to review page")]
        public void WhenIClickTheTLevelsBreadcrumbOnTheSelectTLevelToReviewPage()
        {
            SelectTLevelPage.ClickTLevelsBreadcrumb();
        }
        
        [When(@"I click the Continue button without selecting any T Levels to review")]
        public void WhenIClickTheContinueButtonWithoutSelectingAnyTLevelsToReview()
        {
            SelectTLevelPage.ClickContinueBtn();
        }
        
        [Then(@"I am navigated to the Select T Level to review page")]
        public void ThenIAmNavigatedToTheSelectTLevelToReviewPage()
        {
            SelectTLevelPage.VerifySelectTLevelPage();
        }
        
        [Then(@"I am shown the following error message on the Select a T Level to review page ""(.*)""")]
        public void ThenIAmShownTheFollowingErrorMessageOnTheSelectATLevelToReviewPage(string ErrorMessage)
        {
            SelectTLevelPage.VerifyErrorMessage(ErrorMessage);
        }

        [Then(@"I set all of the T Levels for NCFE to unconfirmed")]
        [Given(@"I set all of the T Levels for NCFE to unconfirmed")]
        public void GivenISetAllOfTheTLevelsForNCFEToUnconfirmed()
        {
            SqlQueries.SetAllTLevelsToNotReviewed();
        }

        [When(@"I click on the Home breadcrumb on the Select T Level to review page")]
        public void WhenIClickOnTheHomeBreadcrumbOnTheSelectTLevelToReviewPage()
        {
            SelectTLevelPage.ClickHomeBreadcrumb();
        }

        [When(@"I click the Contact Us link on the Select T Level to review page")]
        public void WhenIClickTheContactUsLinkOnTheSelectTLevelToReviewPage()
        {
            SelectTLevelPage.ClickICannotFinaATLevelLink();
            SelectTLevelPage.ClickContactUsLink();
        }

        [Then(@"I am shown the Contact Us page")]
        public void ThenIAmShownTheContactUsPage()
        {
            ContactUsPage.VerifyContactUsPage(); 
        }
    }
}
