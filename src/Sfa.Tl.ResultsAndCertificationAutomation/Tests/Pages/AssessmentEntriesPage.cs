using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class AssessmentEntriesPage : ElementHelper
    {
        public static By AssessmentEntriesLink { get; } = By.LinkText("Assessment entries");
        private static string AssessmentEntriesPageTitle { get; } = "Assessment entries page – Manage T Level results – GOV.UK";
        private static string AssessmentEntriesPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "assessment-entries");
        private static string AssessmentEntriesPageHeader { get; } = "Assessment entries";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By UploadAssessmentEntryLink { get; } = By.LinkText("Upload assessment entries file");
        private static By SearchForLearnerLink { get; } = By.LinkText("Search for a learner");

        public static void VerifyAssessmentEntriesPage()
        {
            Assert.AreEqual(WebDriver.Title, AssessmentEntriesPageTitle);
            Assert.AreEqual(WebDriver.Url, AssessmentEntriesPageUrl);
            Assert.AreEqual(AssessmentEntriesPageHeader, WebDriver.FindElement(PageHeader).Text);
        }

        public static void CheckLinksOnAssessmentEntriesPage()
        {
            Assert.IsTrue(IsPresent(UploadAssessmentEntryLink));
            Assert.IsTrue(IsPresent(SearchForLearnerLink));
        }
    }
}
