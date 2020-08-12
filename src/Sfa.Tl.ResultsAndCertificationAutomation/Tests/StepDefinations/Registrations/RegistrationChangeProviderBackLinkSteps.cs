using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationChangeProviderBackLinkSteps : RegistrationsManualPage
    {
        [Given(@"I click on Provider change link")]
        public void GivenIClickOnProviderChangeLink()
        {
            ClickChangePoviderLink();
            Assert.IsTrue(WebDriver.Url.Contains(ProviderPageUrl));
            Assert.AreEqual(Constants.SelectProviderTitle, WebDriver.Title);
            Assert.AreEqual(ProviderHeader, WebDriver.FindElement(PageHeader).Text);
        }
    }
}
