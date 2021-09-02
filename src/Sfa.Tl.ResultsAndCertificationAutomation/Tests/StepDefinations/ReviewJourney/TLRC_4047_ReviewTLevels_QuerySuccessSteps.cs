using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.TLevelReview;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewJourney
{
    [Binding]
    public class TLRC_4047JourneyImprovements_ReviewTLevels_QuerySuccessSteps
    {
        [When(@"I enter a value for what is wrong with the T Level and press Submit")]
        public void WhenIEnterAValueForWhatIsWrongWithTheTLevelAndPressSubmit()
        {
            ReviewTLevelsQueryDetailsPage.EnterWhatIsWrongWithThisTLevelText("Test");
        }
        
        [When(@"I press the Back to T Levels button on the T Levels details Queried Success page")]
        public void WhenIPressTheBackToTLevelsButtonOnTheTLevelsDetailsQueriedSuccessPage()
        {
            TLevelQuerySuccessPage.ClickBackToTLevelsBtn();
        }
        
        [Then(@"I am shown the T Levels details Queried Success page")]
        public void ThenIAmShownTheTLevelsDetailsQueriedSuccessPage()
        {
            TLevelQuerySuccessPage.VerifyQueryTLevelsSuccessPage();
        }

        [Then(@"the T Levels details Queried Success page will list the T Level ""(.*)""")]
        public void ThenTheTLevelsDetailsQueriedSuccessPageWillListTheTLevel(string TLevel)
        {
            TLevelQuerySuccessPage.VerifyTLevelQueriedDetails(TLevel);
        }

        [When(@"I press the Back to home button on the T Levels details Queried Success page")]
        public void WhenIPressTheBackToHomeButtonOnTheTLevelsDetailsQueriedSuccessPage()
        {
            TLevelQuerySuccessPage.ClickBackToHomeBtn();
        }


    }
}
