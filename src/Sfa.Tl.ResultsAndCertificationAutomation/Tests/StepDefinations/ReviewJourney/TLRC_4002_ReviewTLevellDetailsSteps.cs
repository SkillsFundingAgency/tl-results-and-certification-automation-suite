using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.TLevelReview;


namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewJourney
{
    [Binding]
    public class TLRC_4002_ReviewTLevellDetailsSteps : SqlQueries
    {
        [When(@"I select ""(.*)"" and click continue")]
        public void WhenISelectAndClickContinue(string p0)
        {
            SelectTLevelPage.SelectAgricultureTLevel();
            SelectTLevelPage.ClickContinueBtn();
        }
        
        [When(@"I press the back link on the Review T Level details page")]
        public void WhenIPressTheBackLinkOnTheReviewTLevelDetailsPage()
        {
            ReviewTLevelDetailsPage.ClickBackLink();
        }
        
        [When(@"I click the Continue button without selecting any radio buttons on the Review T Level details page")]
        public void WhenIClickTheContinueButtonWithoutSelectingAnyRadioButtonsOnTheReviewTLevelDetailsPage()
        {
            ReviewTLevelDetailsPage.ClickContinueBtn();
        }
        
        [Then(@"I am shown the Review T Level details page")]
        public void ThenIAmShownTheReviewTLevelDetailsPage()
        {
            ReviewTLevelDetailsPage.VerifyReviewTLevelDetailsPage();
        }
        
        [Then(@"the radio buttons are not prepopulated on the Review T Level page")]
        public void ThenTheRadioButtonsAreNotPrepopulatedOnTheReviewTLevelPage()
        {
            ReviewTLevelDetailsPage.VerifyRadioButtonsNotPrepopulated();
        }
        
        [Then(@"the details for the ""(.*)"" T level are displayed")]
        public void ThenTheDetailsForTheTLevelAreDisplayed(string TLevel)
        {
            ReviewTLevelDetailsPage.VerifyTLevelDetails(TLevel);
        }
        
        [Then(@"I am shown the Review T Level page")]
        public void ThenIAmShownTheReviewTLevelPage()
        {
            ReviewTLevelDetailsPage.VerifyReviewTLevelDetailsPage();
        }
        
        [Then(@"I am shown the following error message on the Review T Level details page ""(.*)""")]
        public void ThenIAmShownTheFollowingErrorMessageOnTheReviewTLevelDetailsPage(string ErrorMessage)
        {
            ReviewTLevelDetailsPage.VerifyErrorMessage(ErrorMessage);
        }

        [Given(@"I set only one T Level \(T Level in Agriculture, Environmental and Animal Care\) for NCFE to unconfirmed")]
        public void GivenISetOnlyOneTLevelTLevelInAgricultureEnvironmentalAndAnimalCareForNCFEToUnconfirmed()
        {
            SetAllTLevelsToReviewed();
            SetOneTLevelsToNotReviewed();
        }

    }
}
