using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals
{
    public class NoRegisteredAssessmentSeriesPage: ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "reviews-and-appeals-no-assessment-entry");
        private static string pageTitle { get; } = "No assessment entry – Manage T Level results – GOV.UK";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static readonly string ExpectedPageHeaderText = "Learner does not have any registered assessments";
        private static By searchAgainBtn { get; } = By.Id("searchAgainButton");
        private static By backToHomeBtn { get; } = By.Id("backToHomeButton");
        private static By backLink { get; } = By.Id("backLink");
        private static By searchUln { get; } = By.Id("searchuln");
        private static By searchBtn { get; } = By.Id("searchButton");
        public static void VerifyNoAssessmentPage()
        {
            Assert.AreEqual(pageUrl, WebDriver.Url);
            Assert.AreEqual(pageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedPageHeaderText, WebDriver.FindElement(PageHeader).Text);
        }
        public static void PressStartAgainBtn()
        {
            ClickButton(searchAgainBtn);
        }

        public static void PressBackToHomeBtn()
        {
            ClickButton(backToHomeBtn);
        }

        public static void PressSearchBtn()
        {
            ClickButton(searchBtn);
        }

        public static void VerifyBackLink(string uln)
        {
            ClickElement(backLink);
            Assert.IsTrue(WebDriver.Url.Contains("reviews-and-appeals-search-learner"));
            Assert.AreEqual("Search for a learner – Manage T Level results – GOV.UK", WebDriver.Title);
            Assert.AreEqual(uln, WebDriver.FindElement(searchUln).GetAttribute("value"));
        }
    }
}
