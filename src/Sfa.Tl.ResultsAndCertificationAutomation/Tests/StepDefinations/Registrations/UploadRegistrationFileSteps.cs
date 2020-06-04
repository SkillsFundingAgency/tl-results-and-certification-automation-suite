using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class UploadRegistrationFileSteps : RegistrationsPage
    {
        [When(@"I click on Upload Registration file link")]
        public void WhenIClickOnUploadRegistrationFileLink()
        {
            ClickElement(UploadRegistationLink);
        }
        
        [When(@"I upload a file and click on Submit button")]
        public void WhenIUploadAFileAndClickOnSubmitButton()
        {
            Assert.AreEqual(UploadRegistrationUrl, WebDriver.Url);
            Assert.AreEqual(Constants.UploadRegPageTitle, WebDriver.Title);
            Assert.AreEqual(Constants.UploadRegPageHeader, WebDriver.FindElement(PageHeader).Text);
            ElementHelper.UploadFile(ChooseFile, UploadValidFile);
            ClickElement(SubmitFileBtn);
        }
        
        [Then(@"I should see upload successful message")]
        public void ThenIShouldSeeUploadSuccessfulMessage()
        {
            Assert.AreEqual(RegistrationUploadSuccessUrl, WebDriver.Url);
            Assert.AreEqual(Constants.RegistrationUploadSuccessTitle, WebDriver.Title);
            Assert.AreEqual(Constants.RegistrationSuccessHeader, WebDriver.FindElement(PageHeader).Text);
            ClickElement(BacktoRegistrationLink);
        }
        
        [Then(@"I should be navigated back to Registrations Page when i click on Back to registration button")]
        public void ThenIShouldBeNavigatedBackToRegistrationsPageWhenIClickOnBackToRegistrationButton()
        {
            VerifyRegistrationDashboardPage();
        }
    }
}
