using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class QueryATlevelSteps : ManageTLevel
    {
        [When(@"I select Something Wrong anc click continue")]
        public void WhenISelectSomethingWrongAncClickContinue()
        {
            SomethingWrong();
            ClickContinueBtn();
        }
        
        [When(@"Enter text and click continue")]
        public void WhenEnterTextAndClickContinue()
        {
            Assert.IsTrue(WebDriver.Title.Equals(QueryTLevelPageTitle));
            Assert.IsTrue(WebDriver.Url.Contains(QueryTlevel));
            Assert.IsTrue(WebDriver.FindElement(PageTitle).Text.Contains("Query T Level details"));
            QueryTlevelText();
        }
        
        [Then(@"I should see Tlevel queried message")]
        public void ThenIShouldSeeTlevelQueriedMessage()
        {
            Assert.IsTrue(WebDriver.Title.Equals(TlevelConfirmantionPageTitle));
            Assert.IsTrue(WebDriver.FindElement(PageTitle).Text.Contains(TlevelQueryMsg));
            Assert.IsTrue(WebDriver.FindElement(PageContent).Text.Contains(Constants.TlevelTitleAgricluture));
        }
    }
}
