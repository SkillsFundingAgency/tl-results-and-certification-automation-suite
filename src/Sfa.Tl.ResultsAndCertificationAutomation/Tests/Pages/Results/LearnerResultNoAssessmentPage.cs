using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Results
{
    public class LearnerResultNoAssessmentPage : ElementHelper
    {
        private static string pageUrl { get; } = "no-assessment-entries";
        private static string pageTitle { get; } = "No registered assessments – Manage T Level results – GOV.UK";
        private static By pageHeadElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By pageContent { get; } = By.XPath("//*[@id='main-content']");
        private static string pageHeader = "Learner does not have any registered assessments";
        private static string pageInlineText = "This learner does not have any assessments registered in this system. Please contact a registrations editor in your organisation if you need to amend this.";

        public static void VerifyLearnerNoAssessmentPage()
        {
            Assert.AreEqual(pageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(pageHeader, WebDriver.FindElement(pageHeadElement).Text);
            Assert.IsTrue(WebDriver.FindElement(pageContent).Text.Contains(pageInlineText));
        }
    }
}
