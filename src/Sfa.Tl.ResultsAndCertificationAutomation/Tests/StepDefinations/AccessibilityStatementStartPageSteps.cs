using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System.Linq;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class AccessibilityStatementStartPageSteps : TlevelDashboardPage
    {
        [Given(@"Tlevel start page")]
        public void GivenTlevelStartPage()
        {
            WebDriver.Navigate().GoToUrl(StartPageUrl);
        }
        
        [When(@"I click on Accessibility statement link")]
        public void WhenIClickOnAccessibilityStatementLink()
        {
            PageHelper.ClickElement(AccesslibilityLink);
        }
        
        [Then(@"I should see Accessibility stement details in new tab in the browser")]
        public void ThenIShouldSeeAccessibilityStementDetailsInNewTabInTheBrowser()
        {
            WebDriver.SwitchTo().Window(WebDriver.WindowHandles.Last());
            Assert.AreEqual(Constants.AccessibilityUrl, WebDriver.Url);
        }
    }
}
