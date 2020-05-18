using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ProviderJourney
{
    [Binding]
    public class ErrorPageTitleRemoveTlevelSteps : ProviderPage
    {
        [Given(@"I am on Are you sure you want to remove Tlevel Page")]
        public void GivenIAmOnAreYouSureYouWantToRemoveTlevelPage()
        {
            ClickProviderLink();
            DeleteTlevelFromDB();
            FindProvider();
            SelectTlevel(Legal);
            Submit();
            ManageTlevels();
            ClickRemoveTlevel();
        }
        
        [Then(@"I should see Error: Are You Sure You want to Remove This T Level page - Manage T Level results - GOV\.UK in the page title")]
        public void ThenIShouldSeeErrorAreYouSureYouWantToRemoveThisTLevelPage_ManageTLevelResults_GOV_UKInThePageTitle()
        {
            Assert.AreEqual(Constants.ErrorAreYouSureRemove, WebDriver.Title);
            Assert.AreEqual(RemoveTlvelUrl, WebDriver.Url);
        }
    }
}
