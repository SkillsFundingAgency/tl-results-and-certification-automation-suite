using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class AssessmentEntriesPage : ElementHelper
    {
        //Urls
        private static string AssessmentEntriesPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "assessment-entries");
        private static string AssessmentEntriesUploadPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "upload-assessment-entries-file");
        private static string AssessmentUploadUnsuccessPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "assessment-entries-upload-unsuccessful");
        //Page Titles
        private static string AssessmentEntriesPageTitle { get; } = "Assessment entries page – Manage T Level results – GOV.UK";
        private static string AssessmentEntriesUploadPageTitle { get; } = "Upload assessment entries file page – Manage T Level results – GOV.UK";
        private static string AssessmentUploadUnsucccessTitle { get; } = "Assessment entries upload unsuccessful page – Manage T Level results – GOV.UK";
        private static string AssessmentEntriesUploadPageErrorTitle { get; } = "Error: Upload assessment entries file page – Manage T Level results – GOV.UK";
        //Page Headers
        private static string AssessmentEntriesPageHeader { get; } = "Assessment entries";
        private static string AssessmentEntriesUploadPageHeader { get; } = "Upload assessment entries file";
        private static string AssessmentUploadUnsuccessPageHeader { get; } = "Assessment entries upload unsuccessful";

        // Objects
        public static By AssessmentEntriesLink { get; } = By.LinkText("Assessment entries");
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        public static By UploadAssessmentEntryLink { get; } = By.LinkText("Upload assessment entries file");
        private static By SearchForLearnerLink { get; } = By.LinkText("Search for a learner");
        public static By AssessmentFileUploadError { get; } = By.XPath("//a[@href='#file']");
        //Upload files
        public static string AssessmentStage1InvalidFile = "AssessmentEntryStage1InvalidFileType.xslx";
        public static string AssessmentStage1MaxRows = "AssessmentEntryStage1MaxNoOfRows.csv";
        public static string AssessmentUploadStage2Errors = string.Concat("Data\\", "AssessmentStage2ErrorReport.csv");
        public static string AssessmentUploadStage2InvalidHeaderErrors = string.Concat("Data\\", "AssessmentStage2InvalidHeaderError.csv");
        public static string AssessmentUploadStage2NoDataErrors = string.Concat("Data\\", "AssessmentStage2NoDataError.csv");
        public static string AssessmentUploadStage3Errors = string.Concat("Data\\", "AssessmentStage3Errors.csv");
        public static string AssessmentUploadStage3WithdrawnRegError = string.Concat("Data\\", "AssessmentStage3WithdrawnRegError.csv");

        public static void VerifyAssessmentEntriesPage()
        {
            Assert.AreEqual(AssessmentEntriesPageTitle, WebDriver.Title);
            Assert.AreEqual(AssessmentEntriesPageUrl, WebDriver.Url);
            Assert.AreEqual(AssessmentEntriesPageHeader, WebDriver.FindElement(PageHeader).Text);
        }

        public static void CheckLinksOnAssessmentEntriesPage()
        {
            Assert.IsTrue(IsPresent(UploadAssessmentEntryLink));
            Assert.IsTrue(IsPresent(SearchForLearnerLink));
        }

        public static void VerifyAssessmentEntriesUploadPage()
        {
            Assert.AreEqual(AssessmentEntriesUploadPageUrl, WebDriver.Url);
            Assert.AreEqual(AssessmentEntriesUploadPageTitle, WebDriver.Title);
            Assert.AreEqual(AssessmentEntriesUploadPageHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyAssessmentEntriesUploadErrorPage()
        {
            Assert.AreEqual(AssessmentEntriesUploadPageUrl, WebDriver.Url);
            Assert.AreEqual(AssessmentEntriesUploadPageErrorTitle, WebDriver.Title);
            Assert.AreEqual(AssessmentEntriesUploadPageHeader, WebDriver.FindElement(PageHeader).Text);
        }

        public static void VerifyAssessmentUploadUnsuccessPage()
        {
            Assert.AreEqual(AssessmentUploadUnsuccessPageUrl, WebDriver.Url);
            Assert.AreEqual(AssessmentUploadUnsucccessTitle, WebDriver.Title);
            Assert.AreEqual(AssessmentUploadUnsuccessPageHeader, WebDriver.FindElement(PageHeader).Text);
        }
    }
}
