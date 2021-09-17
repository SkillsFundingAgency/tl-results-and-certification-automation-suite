using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals
{
    public class ReviewAndAppealsStartPage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "appeals");
        private static string pageTitle { get; } = "Appeal after deadline request sent – Manage T Level results – GOV.UK";
        private static string pageHeader { get; } = "Appeals";
        private static readonly By pageHeaderElement = By.XPath("//*[@id='main-content']//h1");
        private static string subPageHeader { get; } = "Before you start";
        private static readonly By subPageHeaderElement = By.XPath("//*[@id='main-content']//h2");
        private static By continueBtn { get; } = By.Id("continueButton");
        private static By homeBreadcrumb { get; } = By.Id("breadcrumb0");
        private static By reviewsAndAppealsLink { get; } = By.LinkText("Appeals");
        public static void VerifyReviewAndAppealsStartPage()
        {
            Assert.AreEqual(pageUrl, WebDriver.Url);
            Assert.AreEqual(pageTitle, WebDriver.Title);
            Assert.AreEqual(pageHeader, WebDriver.FindElement(pageHeaderElement).Text);
            Assert.AreEqual(subPageHeader, WebDriver.FindElement(subPageHeaderElement).Text);
        }
        public static void ClickHomeBreadcrumb()
        {
            ClickElement(homeBreadcrumb);
            TlevelDashboardPage.VerifyDashboardpage();
        }
        public static void PressContinueBtn() => ClickButton(continueBtn);
        public static void ClickAppealsLink() => ClickElement(reviewsAndAppealsLink);
    }
}
