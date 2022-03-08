using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using System.Threading;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.DataExport
{
    public class DataExportResultsPage : ElementHelper
    {
        private static string NoResultsPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "results-no-records-found");
        private static string NoResultsPageHeader { get; } = "No records found";
        private static string NoResultsPageTitle { get; } = "No records found - Results – Manage T Level results – GOV.UK";
        private static By PageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static string DownloadResultsPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "results-download-data");
        private static string DownloadResultsPageHeader { get; } = "Download results data";
        private static string DownloadResultsPageTitle { get; } = "Download data - Results – Manage T Level results – GOV.UK";
        private static By BackToHomeBtn { get; } = By.Id("backToHomeButton");
        private static By AddResultsBtn { get; } = By.Id("backToAddResults");
        private static By DownloadcoreResultsLink { get; } = By.XPath("//a[contains(text(),'Core results data')]");
        private static By DownloadSpecilismResultsLink { get; } = By.XPath("//a[contains(text(),'Specialism results data')]");
        protected static readonly string CoreResultsDownloadFile = string.Concat("Data\\", "4896_DownloadedCoreResultsData.csv");
        protected static readonly string SpecialismResultsDownloadFile = string.Concat("Data\\", "5130_DownloadedSpecialismResultsData.csv");

        protected static void VerifyNoResultsRecordPage()
        {
            Assert.AreEqual(NoResultsPageUrl, WebDriver.Url);
            Assert.AreEqual(NoResultsPageHeader, WebDriver.FindElement(PageHeaderElement).Text);
            Assert.AreEqual(NoResultsPageTitle, WebDriver.Title);
        }

        protected static void VerifyDownloadResultsPage()
        {
            Assert.AreEqual(DownloadResultsPageUrl, WebDriver.Url);
            Assert.AreEqual(DownloadResultsPageHeader, WebDriver.FindElement(PageHeaderElement).Text);
            Assert.AreEqual(DownloadResultsPageTitle, WebDriver.Title);
        }
        public static void BackToHome()
        {
            ClickButton(BackToHomeBtn);
            TlevelDashboardPage.VerifyDashboardpage();
        }

        protected static void AddResults()
        {
            ClickButton(AddResultsBtn);
            ResultsDashboardPage.VerifyResultsDashboardPage();
        }

        protected static void DownloadCoreResults()
        {
            ClickElement(DownloadcoreResultsLink);
            Thread.Sleep(5000);
        }

        protected static void DownloadSpecialismResults()
        {
            ClickElement(DownloadSpecilismResultsLink);
            Thread.Sleep(5000);
        }

        protected static void VerifyCoreSpecialismDownloadLinksPresent()
        {
            bool coreLinkIsPresent = IsPresent(DownloadcoreResultsLink);
            Assert.AreEqual(true, coreLinkIsPresent);
            bool specialismLinkIsPresent = IsPresent(DownloadcoreResultsLink);
            Assert.AreEqual(true, specialismLinkIsPresent);
        }

        protected static void VerifyOnlySpecialismDownloadLinksPresent()
        {
            bool coreLinkIsPresent = IsPresent(DownloadcoreResultsLink);
            Assert.AreEqual(false, coreLinkIsPresent);
            bool specialismLinkIsPresent = IsPresent(DownloadSpecilismResultsLink);
            Assert.AreEqual(true, specialismLinkIsPresent);
        }

    }
}
