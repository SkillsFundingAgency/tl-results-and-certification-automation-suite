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
    }
}
