using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.TLevelReview;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewJourney
{
    [Binding]
    public class TLRC_4012JourneyImprovements_ReviewTLevels_QueryTLevelSteps
    {
        [When(@"I select the No radio button and press Submit on the Review T Level details page")]
        public void WhenISelectTheNoRadioButtonAndPressSubmitOnTheReviewTLevelDetailsPage()
        {
            ReviewTLevelDetailsPage.ClickNoRadioBtn();
            ReviewTLevelDetailsPage.ClickContinueBtn();
        }
        
        [When(@"I select Submit on the Query T Level Details page")]
        public void WhenISelectSubmitOnTheQueryTLevelDetailsPage()
        {
            QueryTLevelPageDetailsPage.ClickSubmitBtn();
        }
        
        [Then(@"I am shown the Query T Level Details page")]
        public void ThenIAmShownTheQueryTLevelDetailsPage()
        {
            QueryTLevelPageDetailsPage.VerifyQueryTLevelDetailsPage();
        }
        
        [Then(@"when I press the Back link on the Query T Level Details page")]
        public void ThenWhenIPressTheBackLinkOnTheQueryTLevelDetailsPage()
        {
            QueryTLevelPageDetailsPage.ClickBackLink();
        }
        
        [Then(@"I am shown an error stating ""(.*)"" on the Query T Level Details page")]
        public void ThenIAmShownAnErrorStatingOnTheQueryTLevelDetailsPage(string ErrorMessage)
        {
            QueryTLevelPageDetailsPage.VerifyErrorMessage(ErrorMessage);
        }

        [Then(@"the Query T Level Details page will display details for the T Level ""(.*)""")]
        public void ThenTheQueryTLevelDetailsPageWillDisplayDetailsForTheTLevel(string TLevel)
        {
            QueryTLevelPageDetailsPage.VerifyTLevelDetails(TLevel);
        }

    }
}
