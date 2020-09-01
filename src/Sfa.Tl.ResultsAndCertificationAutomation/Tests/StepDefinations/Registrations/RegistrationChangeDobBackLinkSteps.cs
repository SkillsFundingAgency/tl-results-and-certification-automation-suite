using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationChangeDobBackLinkSteps : RegistrationsManualPage
    {
        [Given(@"I click on DOB change link")]
        public void GivenIClickOnDOBChangeLink()
        {
            ClickChangeDobLink();
            Assert.IsTrue(WebDriver.Url.Contains(DobPageUrl));
            Assert.AreEqual(Constants.DobPageTitle, WebDriver.Title);
            Assert.AreEqual(DobPageHeader, WebDriver.FindElement(PageHeader).Text);
        }
    }
}
