using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ProviderJourney
{
    [Binding]
    public class ErrorPageTitleAddTlevelPageSteps : ProviderPage
    {
        [Given(@"I am on Add Tlevels page")]
        public void GivenIAmOnAddTlevelsPage()
        {
            ClickProviderLink();
            DeleteTlevelFromDB();
            FindProvider();
            SelectTlevel(Legal);
            Submit();
            ManageTlevels();
            ClickElement(AddAnotherTlevelBtn);
        }
        
        [Then(@"I should see Error: Add T Levels page - Manage T Level results - GOV\.UK in the page title")]
        public void ThenIShouldSeeErrorAddTLevelsPage_ManageTLevelResults_GOV_UKInThePageTitle()
        {
            Assert.AreEqual(Constants.ErrorAddTlevel, WebDriver.Title);
            Assert.AreEqual(AddAdditionalTlevelUrl, WebDriver.Url);
        }
    }
}
