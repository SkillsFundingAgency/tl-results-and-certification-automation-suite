using TechTalk.SpecFlow;
using System.Drawing;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class SignOutFromMenuSteps : Pages.TlevelDashboardPage
    {
        [When(@"I click on Signout from Menu")]
        public void WhenIClickOnSignoutFromMenu()
        {
            WebDriver.Manage().Window.Size = new Size(633, 738);
            PageHelper.WaitForPageLoad(WebDriver, 2);
            SignoutFromMenu();
            PageHelper.WaitForPageLoad(WebDriver, 2);
        }
    }
}
