using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using System.Threading;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.DataExport
{
    public class DataExportRegistrationsPage : ElementHelper
    {
        private static string noResultsPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "registrations-no-records-found");
        private static string noResultsPageHeader { get; } = "No records found";
        private static string noResultsPageTitle { get; } = "No records found - Registrations – Manage T Level results – GOV.UK";
        private static By pageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static string downloadRegistrationsPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "registrations-download-data");
        private static string downloadRegistrationsPageHeader { get; } = "Download registrations data";
        private static string downloadRegistrationsPageTitle { get; } = "Download data - Registrations – Manage T Level results – GOV.UK";
        private static By backToHomeBtn { get; } = By.Id("backToHomeButton");
        private static By backHomeBtn { get; } = By.Id("homeButton");
        private static By registrationLink { get; } = By.Id("registrationsLink");
        private static By addRegistrationBtn { get; } = By.Id("backToAddRegistrations");
        private static By downloadRegistrationLink { get; } = By.XPath("//a[contains(text(),'Registrations data')]");
        private static By downloadLink { get; } = By.PartialLinkText("Registrations data");
        public static string RegistrationsDownloadFile = string.Concat("Data\\", "4866_DownloadedRegistrations.csv");
        public static void VerifyNoRegistrationRecordsPage()
        {
            Assert.AreEqual(noResultsPageUrl, WebDriver.Url);
            Assert.AreEqual(noResultsPageHeader, WebDriver.FindElement(pageHeaderElement).Text);
            Assert.AreEqual(noResultsPageTitle, WebDriver.Title);
        }
        public static void VerifyDownloadRegistrationsPage()
        {
            Assert.AreEqual(downloadRegistrationsPageUrl, WebDriver.Url);
            Assert.AreEqual(downloadRegistrationsPageHeader, WebDriver.FindElement(pageHeaderElement).Text);
            Assert.AreEqual(downloadRegistrationsPageTitle, WebDriver.Title);
        }
        public static void BackToHome()
        {
            ClickButton(backToHomeBtn);
            TlevelDashboardPage.VerifyDashboardpage();
        }
        public static void AddRegistration()
        {   ClickButton(addRegistrationBtn);
            RegistrationsPage.VerifyRegistrationDashboardPage();
        }
        public static void NavigateToRegistrationPage()
        {
            ClickButton(backHomeBtn);
            ClickElement(registrationLink);
        }
        public static void DownloadRegistrationFile()
        {
            ClickElement(downloadRegistrationLink);
            Thread.Sleep(5000);
        }
    }
}
