using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.TLevelReview;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewJourney
{
    [Binding]
    public class TLRC_4048JourneyImprovements_ConfirmedTLevels_ViewConfirmedSteps : ElementHelper
    {
        [Given(@"I set some T Levels for NCFE to unconfirmed, queried and reviewed")]
        public void GivenISetSomeTLevelsForNCFEToUnconfirmedQueriedAndReviewed()
        {
            SqlQueries.SetTLevelstoReviewedQueriedUnconfirmed();
        }

        [When(@"I click the Confirmed T Levels link on the T Level dashboard")]
        [Given(@"I click the Confirmed T Levels link on the T Level dashboard")]
        public void GivenIClickTheConfirmedTLevelsLinkOnTheTLevelDashboard()
        {
            TLevelJourneyDashboardPage.ClickConfirmedTLevelsLink();
        }
        
        [Given(@"I click the Review link on the Confirmed T Levels page")]
        public void GivenIClickTheReviewLinkOnTheConfirmedTLevelsPage()
        {
            ConfirmedTLevelsPage.ClickICannotFinaATLevelLink();
            ConfirmedTLevelsPage.ClickReviewLink();
        }
        
        [When(@"I click the TLevels breadcrumb on the Confirmed T Levels page")]
        public void WhenIClickTheTLevelsBreadcrumbOnTheConfirmedTLevelsPage()
        {
            ConfirmedTLevelsPage.ClickTLevelsBreadcrumb();
        }
        
        [When(@"I click on the Home breadcrumb on Confirmed T Levels page")]
        public void WhenIClickOnTheHomeBreadcrumbOnConfirmedTLevelsPage()
        {
            ConfirmedTLevelsPage.ClickHomeBreadcrumb();
        }
        
        [When(@"I navigate back to the Confirmed T Levels page")]
        public void WhenINavigateBackToTheConfirmedTLevelsPage()
        {
            SelectTLevelPage.ClickTLevelsBreadcrumb();
            TLevelJourneyDashboardPage.ClickConfirmedTLevelsLink();
        }
        
        [When(@"I click the Queried link on the Confirmed T Levels page")]
        public void WhenIClickTheQueriedLinkOnTheConfirmedTLevelsPage()
        {
            ConfirmedTLevelsPage.ClickICannotFinaATLevelLink();
            ConfirmedTLevelsPage.ClickQueriedLink();
        }
        
        [Then(@"I am navigated to the Confirmed T Levels page")]
        public void ThenIAmNavigatedToTheConfirmedTLevelsPage()
        {
            ConfirmedTLevelsPage.VerifyConfirmedTLevelsPage();
        }
        
        [Then(@"I am navigated to the Queried T Levels page")]
        public void ThenIAmNavigatedToTheQueriedTLevelsPage()
        {
            QueriedTLevelsPage.VerifyQueriedTLevelsPage();
        }

        [Then(@"there is a Contact Us link present")]
        [Given(@"there is a Contact Us link present")]
        public void GivenThereIsAContactUsLinkPresent()
        {
            ConfirmedTLevelsPage.VerifyContactUsLinkPresent();
        }

        [When(@"I press the Back to T Levels button")]
        public void WhenIPressTheBackToHomeButton()
        {
            ConfirmedTLevelsPage.ClickBackToTLevelsBtn();
        }

        [When(@"I navigate back to the Confirmed T Levels page from the Queried T Levels page")]
        public void WhenINavigateBackToTheConfirmedTLevelsPageFromTheQueriedTLevelsPage()
        {
            QueriedTLevelsPage.ClickTLevelsBreadcrumb();
            TLevelJourneyDashboardPage.ClickConfirmedTLevelsLink();
        }

    }
}
