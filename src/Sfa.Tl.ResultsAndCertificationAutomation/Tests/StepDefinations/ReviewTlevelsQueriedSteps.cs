using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class ReviewTlevelsQueriedSteps : ManageTLevel
    {
        [When(@"select Something wrong and click continue")]
        public void WhenSelectSomethingWrongAndClickContinue()
        {
            SomethingWrong();
            ClickContinueBtn();
        }
        
        [When(@"I enter text and submit")]
        public void WhenIEnterTextAndSubmit()
        {
            QueryTlevelText();
        }
        
        [Then(@"I should see Tlevel Queried message")]
        public void ThenIShouldSeeTlevelQueriedMessage()
        {
            Assert.IsTrue(WebDriver.FindElement(PageTitle).Text.Contains(TlevelQueryMsg));
        }
    }
}
