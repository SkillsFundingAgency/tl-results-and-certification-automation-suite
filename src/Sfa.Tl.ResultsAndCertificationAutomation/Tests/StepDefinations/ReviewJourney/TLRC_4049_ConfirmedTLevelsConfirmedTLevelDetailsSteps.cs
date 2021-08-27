using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.TLevelReview;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewJourney
{
    [Binding]
    public class TLRC_4049JourneyImprovements_ConfirmedTLevels_ConfirmedTLevelDetailsSteps
    {
        [When(@"I click on the View link for the ""(.*)"" Tlevel")]
        public void WhenIClickOnTheViewLinkForTheTlevel(string TLevel)
        {
            ConfirmedTLevelsPage.ClickTLevelLink(TLevel);
        }

        [Then(@"the details for the confirmed T Level ""(.*)"" are displayed")]
        public void ThenTheDetailsForTheConfirmedTLevelAreDisplayed(string TLevel)
        {
            ConfirmedTLevelsDetailsPage.VerifyTLevelDetails(TLevel);
        }

        [When(@"I click the back link on the confirmed T Level details page")]
        public void WhenIClickTheBackLinkOnTheConfirmedTLevelDetailsPage()
        {
            ConfirmedTLevelsDetailsPage.ClickBackLink();
        }

        [When(@"I click the Back to confirmed T Levels button")]
        public void WhenIClickTheBackToConfirmedTLevelsButton()
        {
            ConfirmedTLevelsDetailsPage.ClickBackToConfirmedTLevelsBtn();
        }

        [When(@"I click the Raise a query link on the Confirmed T Level details page")]
        public void WhenIClickTheRaiseAQueryLinlOnTheConfirmedTLevelDetailsPage()
        {
            ConfirmedTLevelsDetailsPage.ClickRaiseAQueryLink();
        }

        [When(@"I When I click on the View link for the ""(.*)"" Tlevel")]
        public void WhenIWhenIClickOnTheViewLinkForTheTlevel(string TLevel)
        {
            ConfirmedTLevelsPage.ClickTLevelLink(TLevel);
        }



    }
}
