using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class ProviderRemoveTlevelSteps : ProviderPage
    {
        [Given(@"Click on View Provider already been setup link")]
        public void GivenClickOnViewProviderAlreadyBeenSetupLink()
        {
            AddTlevel();
        }
        
        [Given(@"Click on View")]
        public void GivenClickOnView()
        {
            ManageTlevels();
            Assert.IsTrue(WebDriver.Title.Equals(ProviderTLevelPageTitle));
        }
        
        [Given(@"Click on Remove")]
        public void GivenClickOnRemove()
        {
            ClickRemoveTlevel();
            Assert.IsTrue(WebDriver.Title.Equals(RemoveTLevelPageTitle));
        }
        
        [When(@"I select Yes, Remove Tlevel and click on Submit")]
        public void WhenISelectYesRemoveTlevelAndClickOnSubmit()
        {
            ClickElement(RemoveTlevelYes);
            Submit();
        }
        
        [Then(@"I should see Tlevel Removed Successfully message")]
        public void ThenIShouldSeeTlevelRemovedSuccessfullyMessage()
        {
            Assert.IsTrue(WebDriver.FindElement(PageHeader).Text.Contains(TlevelRemoved));
            Assert.IsTrue(WebDriver.Title.Equals(TLevelRemovedPageTitle));
            Assert.IsTrue(WebDriver.FindElement(PageContent).Text.Contains(Constants.TlevelTitleAgricluture));
        }
    }
}
