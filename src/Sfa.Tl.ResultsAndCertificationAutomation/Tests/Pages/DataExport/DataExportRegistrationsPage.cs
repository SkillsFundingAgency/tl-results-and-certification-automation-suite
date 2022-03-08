using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using System.Threading;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.DataExport
{
    public class DataExportRegistrationsPage : ElementHelper
    {
        private static string NoResultsPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "registrations-no-records-found");
        private static string NoResultsPageHeader { get; } = "No records found";
        private static string NoResultsPageTitle { get; } = "No records found - Registrations – Manage T Level results – GOV.UK";
        private static By PageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static string DownloadRegistrationsPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "registrations-download-data");
        private static string DownloadRegistrationsPageHeader { get; } = "Download registrations data";
        private static string DownloadRegistrationsPageTitle { get; } = "Download data - Registrations – Manage T Level results – GOV.UK";
        private static By BackToHomeBtn { get; } = By.Id("backToHomeButton");
        private static By BackHomeBtn { get; } = By.Id("homeButton");
        private static By RegistrationLink { get; } = By.Id("registrationsLink");
        private static By AddRegistrationBtn { get; } = By.Id("backToAddRegistrations");
        private static By DownloadRegistrationLink { get; } = By.XPath("//a[contains(text(),'Registrations data')]");
        protected static readonly string RegistrationsDownloadFile = string.Concat("Data\\", "4866_DownloadedRegistrations.csv");

        protected static void VerifyNoRegistrationRecordsPage()
        {
            Assert.AreEqual(NoResultsPageUrl, WebDriver.Url);
            Assert.AreEqual(NoResultsPageHeader, WebDriver.FindElement(PageHeaderElement).Text);
            Assert.AreEqual(NoResultsPageTitle, WebDriver.Title);
        }

        protected static void VerifyDownloadRegistrationsPage()
        {
            Assert.AreEqual(DownloadRegistrationsPageUrl, WebDriver.Url);
            Assert.AreEqual(DownloadRegistrationsPageHeader, WebDriver.FindElement(PageHeaderElement).Text);
            Assert.AreEqual(DownloadRegistrationsPageTitle, WebDriver.Title);
        }
        public static void BackToHome()
        {
            ClickButton(BackToHomeBtn);
            TlevelDashboardPage.VerifyDashboardpage();
        }

        protected static void AddRegistration()
        {   ClickButton(AddRegistrationBtn);
            RegistrationsPage.VerifyRegistrationDashboardPage();
        }

        protected static void NavigateToRegistrationPage()
        {
            ClickButton(BackHomeBtn);
            ClickElement(RegistrationLink);
        }

        protected static void DownloadRegistrationFile()
        {
            ClickElement(DownloadRegistrationLink);
            Thread.Sleep(5000);
        }
    }
}
