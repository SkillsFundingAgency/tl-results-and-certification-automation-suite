using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.TLevelReview
{
    public class ReviewTLevelDetailsConfirmedPage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "review-more-tlevels");
        private static string pageTitle { get; } = "T Level Confirmed – Manage T Level results – GOV.UK";
        private static string pageHeader { get; } = "T Level details confirmed";
        private static readonly By pageHeaderElement = By.XPath("//*[@id='main-content']//h1");
        private static By pageSubheaderElement = By.ClassName("govuk-panel__body");
        private static By backToHomeButton { get; } = By.Id("backToHomeButton");
        private static By reviewAnotherTLevelButton { get; } = By.Id("reviewAnotherTlevelButton");

        public static void VerifyReviewTLevelDetailsPage()
        {          
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(WebDriver.Title, pageTitle);
            Assert.AreEqual(WebDriver.FindElement(pageHeaderElement).Text, pageHeader);
        }
        public static void VerifyTLevelNameDisplayed(string TLevel)
        {
            Assert.AreEqual(WebDriver.FindElement(pageSubheaderElement).Text, TLevel);
        }

        public static void ClickBackToHomeBtn()
        {
            ClickElement(backToHomeButton);
        }
        public static void ClickReviewAnotherTLevelBtn()
        {
            ClickElement(reviewAnotherTLevelButton);
        }
    }
}
