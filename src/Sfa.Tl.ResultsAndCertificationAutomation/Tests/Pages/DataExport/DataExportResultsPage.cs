using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using System.Threading;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.DataExport
{
    public class DataExportResultsPage : ElementHelper
    {
        private static string noResultsPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "results-no-records-found");
        private static string noResultsPageHeader { get; } = "No records found";
        private static string noResultsPageTitle { get; } = "No records found - Results – Manage T Level results – GOV.UK";
        private static By pageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static string downloadResultsPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "results-download-data");
        private static string downloadResultsPageHeader { get; } = "Download results data";
        private static string downloadResultsPageTitle { get; } = "Download data - Results – Manage T Level results – GOV.UK";
        private static By backToHomeBtn { get; } = By.Id("backToHomeButton");
        private static By addResultsBtn { get; } = By.Id("backToAddResults");
        private static By downloadcoreResultsLink { get; } = By.XPath("//a[contains(text(),'Core results data')]");
        private static By downloadSpecilismResultsLink { get; } = By.XPath("//a[contains(text(),'Specialism results data')]");
        public static string CoreResultsDownloadFile = string.Concat("Data\\", "4896_DownloadedCoreResultsData.csv");
        public static string SpecialismResultsDownloadFile = string.Concat("Data\\", "5130_DownloadedSpecialismResultsData.csv");
        public static void VerifyNoResultsRecordPage()
        {
            Assert.AreEqual(noResultsPageUrl, WebDriver.Url);
            Assert.AreEqual(noResultsPageHeader, WebDriver.FindElement(pageHeaderElement).Text);
            Assert.AreEqual(noResultsPageTitle, WebDriver.Title);
        }
        public static void VerifyDownloadResultsPage()
        {
            Assert.AreEqual(downloadResultsPageUrl, WebDriver.Url);
            Assert.AreEqual(downloadResultsPageHeader, WebDriver.FindElement(pageHeaderElement).Text);
            Assert.AreEqual(downloadResultsPageTitle, WebDriver.Title);
        }
        public static void BackToHome()
        {
            ClickButton(backToHomeBtn);
            TlevelDashboardPage.VerifyDashboardpage();
        }
        public static void AddResults()
        {
            ClickButton(addResultsBtn);
            ResultsDashboardPage.VerifyResultsDashboardPage();
        }
        public static void DownloadCoreResults()
        {
            ClickElement(downloadcoreResultsLink);
            Thread.Sleep(5000);
        }
        public static void DownloadSpecialismResults()
        {
            ClickElement(downloadSpecilismResultsLink);
            Thread.Sleep(5000);
        }

        public static void VerifyCoreSpecialismDownloadLinksPresent()
        {
            bool coreLinkIsPresent = IsPresent(downloadcoreResultsLink);
            Assert.AreEqual(true, coreLinkIsPresent);
            bool specialismLinkIsPresent = IsPresent(downloadcoreResultsLink);
            Assert.AreEqual(true, specialismLinkIsPresent);
        }

        public static void VerifyOnlySpecialismDownloadLinksPresent()
        {
            bool coreLinkIsPresent = IsPresent(downloadcoreResultsLink);
            Assert.AreEqual(false, coreLinkIsPresent);
            bool specialismLinkIsPresent = IsPresent(downloadSpecilismResultsLink);
            Assert.AreEqual(true, specialismLinkIsPresent);
        }

    }
}
