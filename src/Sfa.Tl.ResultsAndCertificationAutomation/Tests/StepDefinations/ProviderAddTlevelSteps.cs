using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class ProviderAddTlevelSteps : ProviderPage
    {
        [Given(@"I serch the Provider from Find Provider Page")]
        public void GivenISerchTheProviderFromFindProviderPage()
        {
            DeleteTlevelFromDB();
            ClickProviderLink();
            FindProvider();
        }
        
        [When(@"I select the TLevel")]
        public void WhenISelectTheTLevel()
        {
            SelectTlevel(Agriculture);
        }
        
        [When(@"click on continue button")]
        public void WhenClickOnContinueButton()
        {
            Submit();
        }
        
        [Then(@"TLevel should be added to the Provide")]
        public void ThenTLevelShouldBeAddedToTheProvide()
        {
            SubmitTlevelInProvider();
            Assert.IsTrue(WebDriver.Title.Equals(TlevelAddedSuccessPageTitle));
            Assert.IsTrue(WebDriver.FindElement(PageContent).Text.Contains(Constants.TlevelTitleAgricluture));
            DeleteTlevelFromDB();
        }
    }
}
