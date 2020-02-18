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
            PageHelper.WaitForUrl(DashboardUrl);
            WebDriver.Manage().Window.Size = new Size(633, 738);
            SignoutFromMenu();
            PageHelper.WaitForUrl(StartPageUrl);
        }
    }
}
