using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals
{
    public class ReviewAndAppealsStartPage : ElementHelper
    {
        private static string PageUrl { get; } = string.Concat(StartPage.StartPageUrl, "appeals");
        private static string PageTitle { get; } = "Appeal after deadline request sent – Manage T Level results – GOV.UK";
        private static string PageHeader { get; } = "Appeals";
        private static readonly By PageHeaderElement = By.XPath("//*[@id='main-content']//h1");
        private static string SubPageHeader { get; } = "Before you start";
        private static readonly By SubPageHeaderElement = By.XPath("//*[@id='main-content']//h2");
        private static By ContinueBtn { get; } = By.Id("continueButton");
        private static By HomeBreadcrumb { get; } = By.Id("breadcrumb0");
        private static By ReviewsAndAppealsLink { get; } = By.LinkText("Appeals");
        public static void VerifyReviewAndAppealsStartPage()
        {
            Assert.AreEqual(PageUrl, WebDriver.Url);
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(PageHeader, WebDriver.FindElement(PageHeaderElement).Text);
            Assert.AreEqual(SubPageHeader, WebDriver.FindElement(SubPageHeaderElement).Text);
        }

        protected static void ClickHomeBreadcrumb()
        {
            ClickElement(HomeBreadcrumb);
            TlevelDashboardPage.VerifyDashboardpage();
        }
        public static void PressContinueBtn() => ClickButton(ContinueBtn);
        public static void ClickAppealsLink() => ClickElement(ReviewsAndAppealsLink);
    }
}
