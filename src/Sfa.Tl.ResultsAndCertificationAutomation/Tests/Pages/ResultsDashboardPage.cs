using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class ResultsDashboardPage : ElementHelper
    {
        private static string ResultsDashoardUrl { get; } = string.Concat(StartPage.StartPageUrl, "results");
        private static By ResultsLink { get; } = By.LinkText("Results");
        private static By BreadCrumb0 { get; } = By.Id("breadcrumb0");
        private static By BreadCrumb1 { get; } = By.Id("breadcrumb1");
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static string ResultsDashboardPageTitle { get; } = "Results page – Manage T Level results – GOV.UK";
        public static By UploadResultLink { get; } = By.LinkText("Upload results file");
        public static By SearchLearnerLink { get; } = By.LinkText("Search for a learner");
        // Upload results page
        private static string UploadResultsUrl { get; } = string.Concat(StartPage.StartPageUrl, "upload-results-file");
        private static string UploadResultsPageTitle { get; } = "Upload results file page – Manage T Level results – GOV.UK";
        private static string UploadResultsErrorPageTitle { get; } = "Error: Upload results file page – Manage T Level results – GOV.UK";

        public static void VerifyResultsDashboardPage()
        {
            Assert.AreEqual(ResultsDashoardUrl, WebDriver.Url);
            Assert.AreEqual(ResultsDashboardPageTitle, WebDriver.Title);
            Assert.AreEqual("Results", WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyLinksInResultsPage()
        {
            Assert.IsTrue(WebDriver.FindElement(UploadResultLink).Displayed);
            Assert.IsTrue(WebDriver.FindElement(SearchLearnerLink).Displayed);
        }
        public static void ClickResultsLink()
        {
            WebDriver.FindElement(ResultsLink).Click();
        }
        public static void ClickHomeBreadcrumb()
        {
            WebDriver.FindElement(BreadCrumb0).Click();
        }
        public static void VerifyUploadResultsPage()
        {
            Assert.AreEqual(UploadResultsUrl, WebDriver.Url);
            Assert.AreEqual(UploadResultsPageTitle, WebDriver.Title);
            Assert.AreEqual("Upload results file", WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyUploadResultsErrorPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(UploadResultsUrl));
            Assert.AreEqual(UploadResultsErrorPageTitle, WebDriver.Title);
        }
    }
}
