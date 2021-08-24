using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.TLevelReview;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewJourney
{
    [Binding]
    public class TLRC_4011JourneyImprovements_ReviewTLevels_DetailsConfirmedMoreToGoSteps : SqlQueries
    {
        [Given(@"I set one of the T Levels for NCFE to unconfirmed")]
        public void GivenISetOneOfTheTLevelsForNCFEToUnconfirmed()
        {
            SetAllTLevelsToReviewed();
            SetOneTLevelsToNotReviewed();
        }
        
        [When(@"I click the Back to home button on the All T Levels reviewed success page")]
        public void WhenIClickTheBackToHomeButtonOnTheAllTLevelsReviewedSuccessPage()
        {
            AllTLevelsReviewedSuccessPage.ClickBackToHomeBtn();
        }
        
        [When(@"I click the Back to T Levels button on the All T Levels reviewed success page")]
        public void WhenIClickTheBackToTLevelsButtonOnTheAllTLevelsReviewedSuccessPage()
        {
            AllTLevelsReviewedSuccessPage.ClickBackToTLevelsBtn();
        }
        
        [When(@"I click the confirmed T Levels link on the All T Levels reviewed success page")]
        public void WhenIClickTheConfirmedTLevelsLinkOnTheAllTLevelsReviewedSuccessPage()
        {
            AllTLevelsReviewedSuccessPage.ClickConfirmedTLevelsLink();
        }
        
        [When(@"I click the Register your learners link on the All T Levels reviewed success page")]
        public void WhenIClickTheRegisterYourLearnersLinkOnTheAllTLevelsReviewedSuccessPage()
        {
            AllTLevelsReviewedSuccessPage.ClickRegisterLink();
        }
        
        [When(@"I click the Add T Levels link on the All T Levels reviewed success page")]
        public void WhenIClickTheAddTLevelsLinkOnTheAllTLevelsReviewedSuccessPage()
        {
            AllTLevelsReviewedSuccessPage.ClickAddTLevelsLink();
        }
        
        [Then(@"the All T Levels reviewed success page is displayed")]
        public void ThenTheAllTLevelsReviewedSuccessPageIsDisplayed()
        {
            AllTLevelsReviewedSuccessPage.VerifyALLTLevelsReviewedSuccessPage();
            
        }
        
        [Then(@"the green confirmation box on the All T Levels reviewed success page shows the T Level ""(.*)"" is confirmed")]
        public void ThenTheGreenConfirmationBoxOnTheAllTLevelsReviewedSuccessPageShowsTheTLevelIsConfirmed(string TLevel)
        {
            AllTLevelsReviewedSuccessPage.VerifyTLevelNameDisplayed(TLevel);
        }
        
        [Then(@"the page displays text as per the Copy Deck")]
        public void ThenThePageDisplaysTextAsPerTheCopyDeck()
        {
            AllTLevelsReviewedSuccessPage.VerifyPageText();
        }

        [Then(@"the links on the All T Levels reviewed success page link to the expected pages")]
        public void ThenTheLinksOnTheAllTLevelsReviewedSuccessPageLinkToTheExpectedPages()
        {
            AllTLevelsReviewedSuccessPage.VerifyLinks();
        }

    }
}
