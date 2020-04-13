using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
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
            QueryTlevelText();
        }
        
        [Then(@"I should see Tlevel queried message")]
        public void ThenIShouldSeeTlevelQueriedMessage()
        {
            Assert.IsTrue(WebDriver.FindElement(PageTitle).Text.Contains(TlevelQueryMsg));
        }
    }
}
