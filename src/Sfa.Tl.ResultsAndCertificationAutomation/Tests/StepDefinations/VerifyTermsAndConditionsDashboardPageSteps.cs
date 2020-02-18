using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class VerifyTermsAndConditionsDashboardPageSteps : StartPage
    {
        [When(@"click on Terms And Conditions link in Dahsboard page")]
        public void WhenClickOnTermsAndConditionsLinkInDahsboardPage()
        {
            PageHelper.WaitForUrl(TlevelDashboardPage.DashboardUrl);
            WebDriver.FindElement(TCLink).Click();
        }
    }
}
