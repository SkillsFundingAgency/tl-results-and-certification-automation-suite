using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1540_ChangeProviderAndCoreBackLinkSteps : RegistrationsSearchPage
    {
        [Then(@"I should be navigated back to select Provider page")]
        public void ThenIShouldBeNavigatedBackToSelectProviderPage()
        {
            Assert.AreEqual(ChangeProviderPageTitle, WebDriver.Title);
            Assert.AreEqual(ChangeProviderPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(ChangeProviderUrl));
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
