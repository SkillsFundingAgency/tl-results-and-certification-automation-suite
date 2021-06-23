using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals
{
    public class ReviewsAndAppealsSearchLearner : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "reviews-and-appeals-search-learner");
        private static string pageTitle { get; } = "Search for a learner – Manage T Level results – GOV.UK";
        private static string pageHeader { get; } = "Search for a learner";
        private static readonly By pageHeaderElement = By.XPath("//*[@id='main-content']//h1");
        private static string pageErrorTitle { get; } = "Error: Search for a learner – Manage T Level results – GOV.UK";
        private static By searchUln { get; } = By.Id("searchuln");
        private static By searchBtn { get; } = By.Id("searchButton");
        private static By reviewsBreadcrumb { get; } = By.Id("breadcrumb1");
        private static By homeBreadcrumb { get; } = By.Id("breadcrumb0");
        public static void VerifySearchLearnerPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(pageTitle, WebDriver.Title);
            Assert.AreEqual(pageHeader, WebDriver.FindElement(pageHeaderElement).Text);
        }

        public static void VerifySearchLearnerErrorPage()
        {
            Assert.AreEqual(pageErrorTitle, WebDriver.Title);
        }
        public static void ClickReviewsBreadcrumb()
        {
            ClickElement(reviewsBreadcrumb);
            ReviewAndAppealsStartPage.VerifyReviewAndAppealsStartPage();
        }
        public static void ClickSearchBtn() => ClickButton(searchBtn);
        public static void EnterUln(string text) => EnterText(searchUln, text);
    }
}
