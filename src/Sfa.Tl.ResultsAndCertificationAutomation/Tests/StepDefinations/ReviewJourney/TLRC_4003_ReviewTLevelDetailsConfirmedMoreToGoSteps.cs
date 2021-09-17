using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.TLevelReview;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewJourney
{
    [Binding]
    public class TLRC_4003_ReviewTLevelDetailsConfirmedMoreToGoSteps : SqlQueries
    {
        [Given(@"I set three of the T Levels for NCFE to unconfirmed")]
        public void GivenISetThreeOfTheTLevelsForNCFEToUnconfirmed()
        {
            SetAllTLevelsToReviewed();
            SetThreeTLevelsToNotReviewed();
        }
        
        [Given(@"I set two of the T Levels for NCFE to unconfirmed")]
        public void GivenISetTwoOfTheTLevelsForNCFEToUnconfirmed()
        {
            SetAllTLevelsToReviewed();
            SetTwoTLevelsToNotReviewed();
        }
        
        [When(@"I select the Yes radio button and press Submit on the Review T Level details page")]
        public void WhenISelectTheYesRadioButtonAndPressSubmitOnTheReviewTLevelDetailsPage()
        {
            ReviewTLevelDetailsPage.ClickYesRadioBtn();
            ReviewTLevelDetailsPage.ClickContinueBtn();
        }
        
        [When(@"I press the Review another T Level button")]
        public void WhenIPressTheReviewAnotherTLevelButton()
        {
            ReviewTLevelDetailsConfirmedPage.ClickReviewAnotherTLevelBtn();
        }
        
        [Then(@"the Review T Levels - Details confirmed page is displayed")]
        public void ThenTheReviewTLevels_DetailsConfirmedPageIsDisplayed()
        {
            ReviewTLevelDetailsConfirmedPage.VerifyReviewTLevelDetailsPage();
        }
        
        [Then(@"the green confirmation box shows the T Level ""(.*)"" is confirmed")]
        public void ThenTheGreenConfirmationBoxShowsTheTLevelIsConfirmed(string TLevel)
        {
            ReviewTLevelDetailsConfirmedPage.VerifyTLevelNameDisplayed(TLevel);
        }
    }
}
