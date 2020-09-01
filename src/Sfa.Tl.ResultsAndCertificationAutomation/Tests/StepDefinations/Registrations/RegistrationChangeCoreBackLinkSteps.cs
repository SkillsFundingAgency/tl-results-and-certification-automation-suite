using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationChangeCoreBackLinkSteps : RegistrationsManualPage
    {
        [Given(@"I click on Core change link")]
        public void GivenIClickOnCoreChangeLink()
        {
            ClickChangeCoreLink();
            Assert.IsTrue(WebDriver.Url.Contains(CorePageUrl));
            Assert.AreEqual(Constants.SelectCoreTitle, WebDriver.Title);
            Assert.AreEqual(CoreHeader, WebDriver.FindElement(PageHeader).Text);
        }
    }
}
