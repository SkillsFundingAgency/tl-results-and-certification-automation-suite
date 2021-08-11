using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Results
{
    public class LearnerWithdrawnPage : ElementHelper
    {
        private static string pageUrl { get; } = "learners-results-withdrawn-learner";
        private static string pageTitle { get; } = "Learner withdrawn – Manage T Level results – GOV.UK";
        private static By pageHeadElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By pageContent { get; } = By.XPath("//*[@id='main-content']");
        private static string pageHeader = "Learner has been withdrawn by the exam board";
        private static string pageInlineText = "This learner’s registration has been withdrawn. You cannot change or add a result. Please speak to your organisation’s registrations editor to change this learner’s status.";
        private static By backLink { get; } = By.Id("backLink");
        private static By searchAgainBtn { get; } = By.Id("searchAgainButton");
        private static By backHomeBtn { get; } = By.Id("backToHomeButton");
        private static By SearchBtn { get; } = By.Id("searchButton");

        public static void VerifyLearnerWithdrawnPage()
        {
            Assert.AreEqual(pageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(pageHeader, WebDriver.FindElement(pageHeadElement).Text);
            Assert.IsTrue(WebDriver.FindElement(pageContent).Text.Contains(pageInlineText));
        }
        public static void VerifyBackLink(string uln)
        {
            ClickElement(backLink);
            ResultsSearchForALearnerPage.VerifyResultsSearchLearnerPage();
            ResultsSearchForALearnerPage.VerifySearchFieldIsPrePopulated(uln);
        }
        public static void VerifyBackToHome()
        {
            ClickButton(backHomeBtn);
            TlevelDashboardPage.VerifyDashboardpage();
        }
        public static void VerifySearchAgain()
        {
            ClickButton(searchAgainBtn);
            ResultsSearchForALearnerPage.VerifyResultsSearchLearnerPage();
            ResultsSearchForALearnerPage.VerifySearchFieldIsEmpty();
        }
        public static void ClickSearchBtn()
        {
            ClickButton(SearchBtn);
        }
    }
}
