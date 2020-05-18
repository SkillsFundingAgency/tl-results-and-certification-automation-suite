using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ProviderJourney
{
    [Binding]
    public class ErrorPageTitleSelectProviderTlevelSteps : ProviderPage
    {
        [Given(@"i am on Select Provider Tlevel page")]
        public void GivenIAmOnSelectProviderTlevelPage()
        {
            ClickProviderLink();
            DeleteTlevelFromDB();
            FindProvider();
        }
        
        [When(@"i click on Submit button")]
        public void WhenIClickOnSubmitButton()
        {
            Submit();
        }
        
        [Then(@"I should see Error: Select provider’s T Levels page - Manage T Level results - GOV\.UK in page title")]
        public void ThenIShouldSeeErrorSelectProviderSTLevelsPage_ManageTLevelResults_GOV_UKInPageTitle()
        {
            Assert.AreEqual(Constants.ErrorSelectProviderTlevel, WebDriver.Title);
            Assert.AreEqual(SelectProviderUrl, WebDriver.Url);
        }
    }
}
