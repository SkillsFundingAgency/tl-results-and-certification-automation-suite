using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewJourney
{
    [Binding]
    public class JourneyImprovements_TLevels_TLevelDashboardSteps
    {
        [Given(@"I click on the TLevels link on the homepage")]
        public void GivenIClickOnTheTLevelsLinkOnTheHomepage()
        {
            TlevelDashboardPage.ClickTLevelsLinks();
        }
        
        [Then(@"I should see the TLevels dashboard page")]
        public void ThenIShouldSeeThreTLevelsDashboardPage()
        {
            TLevelJourneyDashboardPage.VerifyTLevelsDashboardPage();
        }

        [When(@"I click the Home breadcrumb on the TLevel Dashboard")]
        public void WhenIClickTheHomeBreadcrumbOnTheTLevelDashboard()
        {
            TLevelJourneyDashboardPage.ClickHomeBreadcrumb();
        }

    }
}
