using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.TLevelReview;


namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewJourney
{
    [Binding]
    public class TLRC_4050_QueriedTLevelsViewQueriedTLevelsSteps
    {
        [Given(@"I click the Queried T Levels link on the T Level dashboard")]
        public void GivenIClickTheQueriedTLevelsLinkOnTheTLevelDashboard()
        {
            TLevelJourneyDashboardPage.ClickQueriedTLevelsLink();
        }
        
        [Given(@"I click the Review link on the Queried T Levels page")]
        public void GivenIClickTheReviewLinkOnTheQueriedTLevelsPage()
        {
            QueriedTLevelsPage.ClickICannotFinaATLevelLink();
            QueriedTLevelsPage.ClickReviewLink();
        }
        
        [When(@"I click the TLevels breadcrumb on the Queried T Levels page")]
        public void WhenIClickTheTLevelsBreadcrumbOnTheQueriedTLevelsPage()
        {
            QueriedTLevelsPage.ClickTLevelsBreadcrumb();
        }
        
        [When(@"I click the Queried T Levels link on the T Level dashboard")]
        public void WhenIClickTheQueriedTLevelsLinkOnTheTLevelDashboard()
        {
            TLevelJourneyDashboardPage.ClickQueriedTLevelsLink();
        }
        
        [When(@"I click on the Home breadcrumb on the Queried T Levels page")]
        public void WhenIClickOnTheHomeBreadcrumbOnTheQueriedTLevelsPage()
        {
            QueriedTLevelsPage.ClickHomeBreadcrumb();
        }
        
        [When(@"I navigate back to the Queried T Levels page")]
        public void WhenINavigateBackToTheQueriedTLevelsPage()
        {
            SelectTLevelPage.ClickTLevelsBreadcrumb();
            TLevelJourneyDashboardPage.ClickQueriedTLevelsLink();
        }
        
        [When(@"I click the Confirmed link on the Queried T Levels page")]
        public void WhenIClickTheConfirmdLinkOnTheQueriedTLevelsPage()
        {
            QueriedTLevelsPage.ClickICannotFinaATLevelLink();
            QueriedTLevelsPage.ClickConfirmedLink();
        }
        
        [When(@"I navigate back to the Queried T Levels page from the Confirmed T Levels page")]
        public void WhenINavigateBackToTheQueriedTLevelsPageFromTheConfirmedTLevelsPage()
        {
            ConfirmedTLevelsPage.ClickTLevelsBreadcrumb();
            TLevelJourneyDashboardPage.ClickQueriedTLevelsLink();
        }
        
        [When(@"I press the Back to T Levels button on the Queried T Levels page")]
        public void WhenIPressTheBackToTLevelsButtonOnTheQueriedTLevelsPage()
        {
            QueriedTLevelsPage.ClickBackToTLevelsBtn();
        }
        
        [Then(@"there is a Contact Us link present on the Queried T Levels page")]
        public void ThenThereIsAContactUsLinkPresentOnTheQueriedTLevelsPage()
        {
            QueriedTLevelsPage.VerifyContactUsLinkPresent();
        }
    }
}
