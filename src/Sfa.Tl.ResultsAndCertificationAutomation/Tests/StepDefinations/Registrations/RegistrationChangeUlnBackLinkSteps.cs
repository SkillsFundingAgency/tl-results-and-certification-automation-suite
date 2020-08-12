using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationChangeUlnBackLinkSteps : RegistrationsManualPage
    {
        [Given(@"I have created registration")]
        public void GivenIHaveCreatedRegistration()
        {
            CreateRegistrationWithSpecialism("9900000070", "FirstName1", "LastName1", "01", "02", "2010");
        }
        
        [Given(@"I am on Check and Submit page")]
        public void GivenIAmOnCheckAndSubmitPage()
        {
            VerifyRegistrationSummaryPage();
        }
        
        [Given(@"I click on Uln change link")]
        public void GivenIClickOnUlnChangeLink()
        {
            ClickChangeUlnLink();
            Assert.IsTrue(WebDriver.Url.Contains(UlnUrl));
            Assert.AreEqual(Constants.UlnPageTitle, WebDriver.Title);
            Assert.AreEqual(UlnPageHeader, WebDriver.FindElement(PageHeader).Text);

        }
        
        [Then(@"I should navigate back to Check and Submit page")]
        public void ThenIShouldNavigateBackToCheckAndSubmitPage()
        {
            VerifyRegistrationSummaryPage();
        }
    }
}
