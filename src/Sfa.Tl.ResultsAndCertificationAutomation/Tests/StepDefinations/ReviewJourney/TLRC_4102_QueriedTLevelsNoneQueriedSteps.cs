using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.TLevelReview;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewJourney
{
    [Binding]
    public class TLRC_4102_QueriedTLevelsNoneQueriedSteps
    {
        [Given(@"I click the Review link on the No T Levels queried page")]
        public void GivenIClickTheReviewLinkOnTheNoTLevelsQueriedPage()
        {
            QueriedTLevelsNoneQueriedPage.ClickICannotFinaATLevelLink();
            QueriedTLevelsNoneQueriedPage.ClickReviewLink();
        }
        
        [When(@"I click the TLevels breadcrumb on the No T Levels queried page")]
        public void WhenIClickTheTLevelsBreadcrumbOnTheNoTLevelsQueriedPage()
        {
            QueriedTLevelsNoneQueriedPage.ClickTLevelsBreadcrumb();
        }
        
        [When(@"I click on the Home breadcrumb on the No T Levels queried page")]
        public void WhenIClickOnTheHomeBreadcrumbOnTheNoTLevelsQueriedPage()
        {
            QueriedTLevelsNoneQueriedPage.ClickHomeBreadcrumb();
        }
        
        [When(@"I navigate back to the No T Levels queried page")]
        public void WhenINavigateBackToTheNoTLevelsQueriedPage()
        {
            SelectTLevelPage.ClickTLevelsBreadcrumb();
            TLevelJourneyDashboardPage.ClickQueriedTLevelsLink();
        }
        
        [When(@"I click the Confirmed link on the No T Levels queried page")]
        public void WhenIClickTheConfirmedLinkOnTheNoTLevelsQueriedPage()
        {
            QueriedTLevelsNoneQueriedPage.ClickICannotFinaATLevelLink();
            QueriedTLevelsNoneQueriedPage.ClickConfirmedLink();
        }
        
        [When(@"I navigate back to the No T Levels queried page from the Confirmed T Levels page")]
        public void WhenINavigateBackToTheNoTLevelsQueriedPageFromTheConfirmedTLevelsPage()
        {
            ConfirmedTLevelsPage.ClickTLevelsBreadcrumb();
            TLevelJourneyDashboardPage.ClickQueriedTLevelsLink();
        }
        
        [When(@"I press the Back to T Levels button on the No T Levels queried page")]
        public void WhenIPressTheBackToTLevelsButtonOnTheNoTLevelsQueriedPage()
        {
            QueriedTLevelsNoneQueriedPage.ClickBackToTLevelsBtn();
        }
        
        [Then(@"I am navigated to the No T Levels queried page")]
        public void ThenIAmNavigatedToTheNoTLevelsQueriedPage()
        {
            QueriedTLevelsNoneQueriedPage.VerifyNoTLevelsQueriedPage();
        }
        
        [Then(@"there is a Contact Us link present on the No T Levels queried page")]
        public void ThenThereIsAContactUsLinkPresentOnTheNoTLevelsQueriedPage()
        {
            QueriedTLevelsNoneQueriedPage.VerifyContactUsLinkPresent();
        }
    }
}
