using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Results
{
    public class LearnerResultNoAssessmentPage : ElementHelper
    {
        private static string PageUrl { get; } = "no-assessment-entries";
        private static string PageTitle { get; } = "No registered assessments – Manage T Level results – GOV.UK";
        private static By PageHeadElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By PageContent { get; } = By.XPath("//*[@id='main-content']");
        private const string PageHeader = "Learner does not have any registered assessments";
        private const string PageInlineText = "This learner does not have any assessments registered in this system. Please contact a registrations editor in your organisation if you need to amend this.";

        protected static void VerifyLearnerNoAssessmentPage()
        {
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(PageHeader, WebDriver.FindElement(PageHeadElement).Text);
            Assert.IsTrue(WebDriver.FindElement(PageContent).Text.Contains(PageInlineText));
        }
    }
}
