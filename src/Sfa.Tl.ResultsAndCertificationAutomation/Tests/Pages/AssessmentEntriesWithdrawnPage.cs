using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class AssessmentEntriesWithdrawnPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "assessment-entries-learner-withdrawn");
        private const string PageTitle = "Learner withdrawn - Assessment entries – Manage T Level results – GOV.UK";
        private const string WithdrawnText = "This learner's registration has been withdrawn.";
        private const string ExpectedPageHeader = "Learner has been withdrawn";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By TextElement { get; } = By.XPath("//*[@id='main-content']/div/div");

        public static By BackLink { get; } = By.Id("backLink");
        public static By SearchAgainBtn { get; } = By.Id("searchAgainButton");
        public static By BackToHomeBtn { get; } = By.Id("backToHomeButton");



        public static void VerifyAssessmentLearnerWithdrawnPage()
        {
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.IsTrue(WebDriver.FindElement(TextElement).Text.Contains(WithdrawnText));
        }


        public static void VerifyDynamicHeaders(string ULN)
        {
            string ExpectedName = "Db FirstName Db LastName";
            string ExpectedProvider = "Automation Test1";
            string ExpectedDOB = "01 January 2001";
            string ExpectedTLevel = "T Level in Agriculture, Environmental and Animal Care";

            Assert.IsTrue(WebDriver.FindElement(TextElement).Text.Contains(ULN));
            Assert.IsTrue(WebDriver.FindElement(TextElement).Text.Contains(ExpectedName));
            Assert.IsTrue(WebDriver.FindElement(TextElement).Text.Contains(ExpectedDOB));
            Assert.IsTrue(WebDriver.FindElement(TextElement).Text.Contains(ExpectedProvider));
            Assert.IsTrue(WebDriver.FindElement(TextElement).Text.Contains(ExpectedTLevel));
        }

        public static void PressBackToHomeBtn()
        {
            ClickElement(BackToHomeBtn);
        }

        public static void PressSearchAgain()
        {
            ClickElement(SearchAgainBtn);
        }

        public static void PressBackLink()
        {
            ClickElement(BackLink);
        }



    }
}
