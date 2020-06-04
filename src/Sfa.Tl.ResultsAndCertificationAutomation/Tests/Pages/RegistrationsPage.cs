using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class RegistrationsPage : ElementHelper
    {
        public static By RegistrationLink = By.XPath("//a[contains(text(),'Registrations')]");
        public static string RestrationUrl => string.Concat(StartPage.StartPageUrl, "registrations");
        public static By UploadRegistationLink = By.XPath("//a[contains(text(),'Upload registrations')]");
        public static string UploadRegistrationUrl => string.Concat(StartPage.StartPageUrl, "upload-registrations-file");
        public static By SearchRegistrationLink = By.XPath("//a[contains(text(),'Search for a registration')]");
        public static By AddRegistrationLink = By.XPath("//a[contains(text(),'Add a new registration')]");
        public static By PageHeader = By.TagName("h1");
        //upload Registrations
        public static By ChooseFile = By.Id("file");
        public static By SubmitFileBtn = By.XPath("//button[contains(text(),'Submit')]");
        public static By BacktoRegistrationLink = By.XPath("//a[contains(text(),'Back to registrations')]");
        public static string RegistrationUploadSuccessUrl => string.Concat(StartPage.StartPageUrl, "registrations-upload-successful");
        public static string UploadValidFile = "RegistrationsValidData.csv";

        public static void ClickRegLink()
        {
            ClickElement(RegistrationLink);
        }

        public static void VerifyRegistrationDashboardPage()
        {
            Assert.AreEqual(RestrationUrl, WebDriver.Url);
            Assert.AreEqual(Constants.RegistrationsPageTitle, WebDriver.Title);
            Assert.AreEqual(Constants.RegistationPageHeader, WebDriver.FindElement(PageHeader).Text);
        }
    }
}
