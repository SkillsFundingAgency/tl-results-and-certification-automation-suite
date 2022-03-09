using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using System.Threading;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.DataExport
{
    public class DataExportAssessmentsPage : ElementHelper
    {
        private static string noResultsPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "assessments-no-records-found");
        private static string noResultsPageHeader { get; } = "No records found";
        private static string noResultsPageTitle { get; } = "No records found - Assessments – Manage T Level results – GOV.UK";
        private static By pageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static string downloadAssessmentsPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "assessments-download-data");
        private static string downloadAssessmentsPageHeader { get; } = "Download assessments data";
        private static string downloadAssessmentsPageTitle { get; } = "Download data - Assessments – Manage T Level results – GOV.UK";
        private static By backToHomeBtn { get; } = By.Id("backToHomeButton");
        private static By addAssessmentsBtn { get; } = By.Id("backToAddAssessments");
        private static By downloadCoreAssessmentsLink { get; } = By.XPath("//a[contains(text(),'Core assessments data')]");
        private static By downloadSpecialismAssessmentsLink { get; } = By.XPath("//a[contains(text(),'Specialism assessments data')]");
        private static By manageTlevelLink { get; } = By.XPath("//a[contains(text(),'Manage T Level results')]");
        public static string CoreAssessmentDownloadFile = string.Concat("Data\\", "4895_DownloadedCoreAssessmentsData.csv");
        public static string SpecialismAssessmentDownloadFile = string.Concat("Data\\", "4895_DownloadedSpecialismAssessmentsData.csv");
        public static void VerifyNoAssessmentsRecordPage()
        {
            Assert.AreEqual(noResultsPageUrl, WebDriver.Url);
            Assert.AreEqual(noResultsPageHeader, WebDriver.FindElement(pageHeaderElement).Text);
            Assert.AreEqual(noResultsPageTitle, WebDriver.Title);
        }
        public static void VerifyDownloadAssessmentPage()
        {
            Assert.AreEqual(downloadAssessmentsPageUrl, WebDriver.Url);
            Assert.AreEqual(downloadAssessmentsPageHeader, WebDriver.FindElement(pageHeaderElement).Text);
            Assert.AreEqual(downloadAssessmentsPageTitle, WebDriver.Title);
        }
        public static void BackToHome()
        {
            ClickButton(backToHomeBtn);
            TlevelDashboardPage.VerifyDashboardpage();
        }
        public static void AddAssessments()
        {
            ClickButton(addAssessmentsBtn);
            AssessmentEntriesPage.VerifyAssessmentEntriesPage();
        }
        public static void ClickBanner()
        {
            ClickElement(manageTlevelLink);
        }
        public static void DownloadCoreAssessmentFile()
        {
            ClickElement(downloadCoreAssessmentsLink);
            Thread.Sleep(5000);
        }
        public static void DownloadSpecialismAssessmentFile()
        {
            ClickElement(downloadSpecialismAssessmentsLink);
            Thread.Sleep(5000);
        }
    }
}
