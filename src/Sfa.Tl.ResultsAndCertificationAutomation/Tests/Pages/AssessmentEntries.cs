using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class AssessmentEntries : ElementHelper
    {
        public static By AssessmentEntriesLink { get; } = By.LinkText("Assessment entries");
        private static string AssessmentEntriesPageTitle { get; } = "Assessment entries page – Manage T Level results – GOV.UK";
        private static string AssessmentEntriesPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "assessment-entries");
        private static string AssessmentEntriesPageHeader { get; } = "Assessment entries";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");

        public static void VerifyAssessmentEntriesPage()
        {
            Assert.AreEqual(WebDriver.Title, AssessmentEntriesPageTitle);
            Assert.AreEqual(WebDriver.Url, AssessmentEntriesPageUrl);
            Assert.AreEqual(AssessmentEntriesPageHeader, WebDriver.FindElement(PageHeader).Text);
        }
    }
}
