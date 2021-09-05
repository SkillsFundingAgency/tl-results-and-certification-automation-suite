using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class RegistrationsPage : ElementHelper
    {
        private static readonly By RegistrationLink = By.XPath("//a[contains(text(),'Registrations')]");
        private static string RestrationUrl => string.Concat(StartPage.StartPageUrl, "registrations");
        public static By UploadRegistationLink = By.XPath("//a[contains(text(),'Upload multiple registrations')]");
        private static string UploadRegistrationUrl => string.Concat(StartPage.StartPageUrl, "upload-registrations-file");
        public static By SearchRegistrationLink = By.XPath("//a[contains(text(),'Search for a registration')]");
        public static By AddRegistrationLink = By.XPath("//a[contains(text(),'Add a new registration')]");
        private static readonly By PageHeader = By.XPath("//*[@id='main-content']//h1");
        //upload Registrations
        public static By ChooseFile = By.Id("file");
        public static By SubmitFileBtn = By.XPath("//button[contains(text(),'Submit')]");
        public static By BacktoRegistrationLink = By.XPath("//a[contains(text(),'Back to registrations')]");
        private static string RegistrationUploadSuccessUrl => string.Concat(StartPage.StartPageUrl, "upload-registrations-file-success");
        private static string RegistrationUploadUnSuccessUrl => string.Concat(StartPage.StartPageUrl, "registrations-upload-unsuccessful");
        public static string UploadValidFile = "RegistrationsValidData.csv";
        public static string UploadValidFileSingle = "RegistrationsValidDataSingle.csv";
        public static string UploadValidUpdatedFile = "RegistrationsUpdateValidData.csv";
        public static string UploadStage2File = "RegistrationsInvalidDataStage2.csv";
        public static string Stage2Errors = string.Concat("Data\\", "Stage2Validations.csv");
        public static By DownloadErrorLink = By.XPath("//a[contains(text(),'Download error report')]");
        public static string UploadStage3File = "RegistrationsInvalidDataStage3.csv";
        public static string Stage3Errors = string.Concat("Data\\", "Stage3ValidationErrors.csv");
        public static string UploadStage4File = "RegistrationsInvalidDataStage4.csv";
        public static string Stage4Errors = string.Concat("Data\\", "Stage4ValidationErrors.csv");
        public static string Stage4WithdrawnErrorFile = string.Concat("Data\\", "RegistrationStage4ErrorForWithdrawn.csv");
        public static By manageIndividualRegistrationsLink { get; } = By.XPath("//*[contains (text(),'manage individual registrations')]");
        public static By uploadAnotherMultipleRegistrationsFileLink { get; } = By.XPath("//*[contains (text(),'upload another multiple registrations file')]");
        public static By assessmentPeriodsLink { get; } = By.XPath("//*[contains (text(),'assessment periods')]");
        public static By BackToHomeBtn { get; } = By.Id("homeButton");
        public static By uploadAnotherFileBtn = By.Id("uploadAnotherButton");

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
        public static void VerifyRegistrationUploadPage()
        {
            Assert.AreEqual(UploadRegistrationUrl, WebDriver.Url);
            Assert.AreEqual(Constants.UploadRegPageTitle, WebDriver.Title);
            Assert.AreEqual(Constants.UploadRegPageHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyRegistrationUploadErrorPage()
        {
            //Assert.AreEqual(UploadRegistrationUrl, WebDriver.Url);
            Assert.IsTrue(WebDriver.Url.Contains(UploadRegistrationUrl));
            Assert.AreEqual(Constants.UploadRegPageErrorTitle, WebDriver.Title);
            Assert.AreEqual(Constants.UploadRegPageHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyRegistrationSuccessPage()
        {
            Assert.AreEqual(RegistrationUploadSuccessUrl, WebDriver.Url);
            Assert.AreEqual(Constants.RegistrationUploadSuccessTitle, WebDriver.Title);
            Assert.AreEqual(Constants.RegistrationSuccessHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyRegistrationUnSuccessPage()
        {
            Assert.AreEqual(RegistrationUploadUnSuccessUrl, WebDriver.Url);
            Assert.AreEqual(Constants.RegistrationUploadUnSuccessTitle, WebDriver.Title);
            Assert.AreEqual(Constants.RegistrationUnSuccessHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public static void ClickBacktoHomeBtn()
        {
            ClickElement(BackToHomeBtn);
        }

        public static void ClickUploadAnotherFileBtn()
        {
            ClickElement(uploadAnotherFileBtn);
        }
        public static void ClickAssessmentPeriodsLink()
        {
            ClickElement(assessmentPeriodsLink);
        }
        public static void ClickUploadAnotherFileLink()
        {
            ClickElement(uploadAnotherMultipleRegistrationsFileLink);
        }
        public static void ClickManageIndividualRegistrationsLink()
        {
            ClickElement(manageIndividualRegistrationsLink);
        }
    }
}
