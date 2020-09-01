using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationChangeSpecialismBackLinkSteps : RegistrationsManualPage
    {
        [When(@"I click back link on Has decide specialism page")]
        public void WhenIClickBackLinkOnHasDecideSpecialismPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(SpecialismDecidePageUrl));
            Assert.AreEqual(Constants.SpecialismDecideTitle, WebDriver.Title);
            Assert.AreEqual(SpecialismDecideHeader, WebDriver.FindElement(PageHeader).Text);
            ClickBackLink();
        }
    }
}
