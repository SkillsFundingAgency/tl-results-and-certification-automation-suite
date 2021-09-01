using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.TLevelReview;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewJourney
{
    [Binding]
    public class TLRC_4051_QueriedTLevels_QueriedTLevelDetailsSteps
    {
        [When(@"I click on the View link for the ""(.*)"" Tlevel on the Queried T Levels page")]
        public void WhenIClickOnTheViewLinkForTheTlevelOnTheQueriedTLevelsPage(string TLevel)
        {
            QueriedTLevelsPage.ClickTLevelLink(TLevel);
        }
        
        [When(@"I click the back link on the Queried T Level details page")]
        public void WhenIClickTheBackLinkOnTheQueriedTLevelDetailsPage()
        {
            QueriedTLevelsDetailsPage.ClickBackLink();
        }
               
        [When(@"I click the Back to queried T Levels button")]
        public void WhenIClickTheBackToQueriedTLevelsButton()
        {
            QueriedTLevelsDetailsPage.ClickBackToQueriedTLevelsBtn();
        }
        
        [Then(@"the details for the queried T Level ""(.*)"" are displayed")]
        public void ThenTheDetailsForTheQueriedTLevelAreDisplayed(string TLevels)
        {
            QueriedTLevelsDetailsPage.VerifyQueriedTLevelDetailsPage();
            QueriedTLevelsDetailsPage.VerifyTLevelDetails(TLevels);
        }
    }
}
