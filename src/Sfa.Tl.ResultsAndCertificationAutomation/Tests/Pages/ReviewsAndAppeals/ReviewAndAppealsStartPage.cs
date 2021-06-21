using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals
{
    public class ReviewAndAppealsStartPage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "reviews-and-appeals");
        private static string pageTitle { get; } = "Reviews and appeals – Manage T Level results – GOV.UK";
        private static string pageHeader { get; } = "Reviews and appeals";
        private static readonly By pageHeaderElement = By.XPath("//*[@id='main-content']//h1");
        private static By continueBtn { get; } = By.Id("continueButton");
        private static By homeBreadcrumb { get; } = By.Id("breadcrumb0");
        private static By reviewsAndAppealsLink { get; } = By.LinkText("Reviews and appeals");
        public static void VerifyReviewAndAppealsStartPage()
        {
            Assert.AreEqual(pageUrl, WebDriver.Url);
            Assert.AreEqual(pageTitle, WebDriver.Title);
            Assert.AreEqual(pageHeader, WebDriver.FindElement(pageHeaderElement).Text);
        }
        public static void ClickHomeBreadcrumb()
        {
            ClickElement(homeBreadcrumb);
            Assert.IsTrue(WebDriver.Url.Contains("home"));
            Assert.IsTrue(WebDriver.Title.Contains("Home page – Manage T Level results – GOV.UK"));
        }
        public static void PressContinueBtn() => ClickButton(continueBtn);
        public static void ClickAppealsLink() => ClickElement(reviewsAndAppealsLink);
    }
}
