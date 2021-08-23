using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.TLevelReview;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewJourney
{
    [Binding]
    public class TLRC_4001_ReviewTLevels_NoTLevelsToReviewSteps : ElementHelper
    {
        [Given(@"I set all of the T Levels for NCFE to confirmed")]
        public void GivenISetAllOfTheTLevelsForNCFEToConfirmed()
        {
            SqlQueries.SetAllTLevelsToReviewed();
        }
        
        [When(@"I press the confirmed T Levels link on the All T Levels reviewed page")]
        public void WhenIPressTheConfirmedTLevelsLinkOnTheAllTLevelsReviewedPage()
        {
            AllTLevelsReviewedPage.ClickConfirmTLevelsLink();
        }
        
        [When(@"I navigate back to the Review T Levels - All T Levels reviewed page")]
        public void WhenINavigateBackToTheReviewTLevels_AllTLevelsReviewedPage()
        {
            WebDriver.Navigate().GoToUrl("https://test.manage-tlevel-results.tlevels.gov.uk/all-tlevels-reviewed");
        }
        
        [When(@"I click the Register link on the All T Levels reviewed page")]
        public void WhenIClickTheRegisterLinkOnTheAllTLevelsReviewedPage()
        {
            AllTLevelsReviewedPage.ClickRegisterLink();
        }
        
        [When(@"I click the Add T Levels link on the All T Levels reviewed page")]
        public void WhenIClickTheAddTLevelsLinkOnTheAllTLevelsReviewedPage()
        {
            AllTLevelsReviewedPage.ClickAddTLevelsLink();
        }
        
        [When(@"I click the Back to TLevels button on the All T Levels reviewed page")]
        public void WhenIClickTheBackToTLevelsButtonOnTheAllTLevelsReviewedPage()
        {
            AllTLevelsReviewedPage.ClickBackToTLevelsBtn();
        }
        
        [When(@"I click the Back to home button on the All T Levels reviewed page")]
        public void WhenIClickTheBackToHomeButtonOnTheAllTLevelsReviewedPage()
        {
            AllTLevelsReviewedPage.ClickBackToHomeBtn();
        }
        
        [Then(@"the Review T Levels - All T Levels reviewed page is displayed")]
        public void ThenTheReviewTLevels_AllTLevelsReviewedPageIsDisplayed()
        {
            AllTLevelsReviewedPage.VerifyAllTLevelsReviewedPage();
        }
        
        [Then(@"I am navigated to the Your TLevels page")]
        public void ThenIAmNavigatedToTheYourTLevelsPage()
        {
            YourTLevelsPage.VerifyYourTLevelPage();
        }
        
        [Then(@"I will be shown the Find a provider page")]
        public void ThenIWillBeShownTheFindAProviderPage()
        {
            ProviderPage.VerifyFindAProviderPage();
        }
    }
}
