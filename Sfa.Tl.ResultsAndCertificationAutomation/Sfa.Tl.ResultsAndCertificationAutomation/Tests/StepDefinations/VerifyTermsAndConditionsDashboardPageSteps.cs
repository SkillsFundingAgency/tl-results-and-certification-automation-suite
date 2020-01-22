using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System.Threading;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class VerifyTermsAndConditionsDashboardPageSteps : StartPage
    {
        [When(@"click on Terms And Conditions link in Dahsboard page")]
        public void WhenClickOnTermsAndConditionsLinkInDahsboardPage()
        {
            WebDriver.FindElement(TCLink).Click();
            Thread.Sleep(2000);
        }
    }
}
