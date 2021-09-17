using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.TLevelReview;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewJourney
{
    [Binding]
    public class TLRC4096_ConfirmedTLevels_NoneConfirmedSteps : SqlQueries
    {
        [Given(@"I click the Review link on the No T Levels confirmed page")]
        public void GivenIClickTheReviewLinkOnTheNoTLevelsConfirmedPage()
        {
            ConfirmedTLevelsNoneConfirmedPage.ClickICannotFinaATLevelLink();
            ConfirmedTLevelsNoneConfirmedPage.ClickReviewLink();
        }
        
        [When(@"I click the TLevels breadcrumb on the No T Levels confirmed page")]
        public void WhenIClickTheTLevelsBreadcrumbOnTheNoTLevelsConfirmedPage()
        {
            ConfirmedTLevelsNoneConfirmedPage.ClickTLevelsBreadcrumb();
        }
        
        [When(@"I click on the Home breadcrumb on the No T Levels confirmed page")]
        public void WhenIClickOnTheHomeBreadcrumbOnTheNoTLevelsConfirmedPage()
        {
            ConfirmedTLevelsNoneConfirmedPage.ClickHomeBreadcrumb();
        }
        
        [When(@"I click on the TLevels link on the homepage")]
        public void WhenIClickOnTheTLevelsLinkOnTheHomepage()
        {
            TlevelDashboardPage.ClickTLevelsLinks();
        }
        
        [When(@"I click the Contact Us link on the No T Levels confirmed page")]
        public void WhenIClickTheContactUsLinkOnTheNoTLevelsConfirmedPage()
        {
            ConfirmedTLevelsNoneConfirmedPage.ClickICannotFinaATLevelLink();
            ConfirmedTLevelsNoneConfirmedPage.ClickContactUsLink();
        }
        
        [When(@"I navigate back to the No T Levels confirmed page")]
        public void WhenINavigateBackToTheNoTLevelsConfirmedPage()
        {
            AllTLevelsReviewedPage.ClickTLevelsBreadcrumb();
            TLevelJourneyDashboardPage.ClickConfirmedTLevelsLink();
        }
        
        [When(@"I click the Review link on the No T Levels confirmed page")]
        public void WhenIClickTheReviewLinkOnTheNoTLevelsConfirmedPage()
        {
            ConfirmedTLevelsNoneConfirmedPage.ClickReviewLink();
        }

        [When(@"I navigate back to the No T Levels confirmed page from the Queried T Levels page")]
        public void WhenINavigateBackToTheNoTLevelsConfirmedPageFromTheQueriedTLevelsPage()
        {
            QueriedTLevelsPage.ClickTLevelsBreadcrumb();
            TLevelJourneyDashboardPage.ClickConfirmedTLevelsLink();
        }


        [When(@"I click the Queried link on the No T Levels confirmed page")]
        public void WhenIClickTheQueriedLinkOnTheNoTLevelsConfirmedPage()
        {
            ConfirmedTLevelsNoneConfirmedPage.ClickICannotFinaATLevelLink();
            ConfirmedTLevelsNoneConfirmedPage.ClickQueriedLink();
        }


        [Then(@"I am navigated to the No T Levels confirmed page")]
        public void ThenIAmNavigatedToTheNoTLevelsConfirmedPage()
        {
            ConfirmedTLevelsNoneConfirmedPage.VerifyNoTLevelsConfiirmedPage();
        }
        
        [Then(@"I should see the Contact Us page")]
        public void ThenIShouldSeeTheContactUsPage()
        {
            ContactUsPage.VerifyContactUsPage();
        }
        
        [Then(@"I am navigated to the Select a TLevel page")]
        public void ThenIAmNavigatedToTheSelectATLevelPage()
        {
            SelectTLevelPage.VerifySelectTLevelPage();
        }

        [Given(@"I set all of the T Levels for NCFE to queried")]
        public void GivenISetAllOfTheTLevelsForNCFEToQueried()
        {
            SqlQueries.SetAllTLevelsToQueried();
        }


    }
}
