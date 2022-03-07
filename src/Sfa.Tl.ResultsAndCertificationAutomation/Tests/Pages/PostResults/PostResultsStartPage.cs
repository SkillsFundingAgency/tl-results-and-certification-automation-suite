using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults
{
    public class PostResultsStartPage : ElementHelper
    {
        private static string PageUrl { get; } = string.Concat(StartPage.StartPageUrl, "post-results-reviews-appeals-and-grade-changes");
        private static string PageTitle { get; } = "Post-results reviews, appeals and grade changes – Manage T Level results – GOV.UK";
        private static string PageHeader { get; } = "Post-results reviews, appeals and grade changes";
        private static readonly By PageHeaderElement = By.XPath("//*[@id='main-content']//h1");
        private static By ContinueBtn { get; } = By.Id("continueButton");
        private static By HomeBreadcrumb { get; } = By.Id("breadcrumb0");

        protected static void VerifyReviewAndAppealsStartPage()
        {
            Assert.AreEqual(PageUrl, WebDriver.Url);
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(PageHeader, WebDriver.FindElement(PageHeaderElement).Text);
        }

        protected static void ClickHomeBreadcrumb()
        {
            ClickElement(HomeBreadcrumb);
            TlevelDashboardPage.VerifyDashboardpage();
        }
        public static void PressContinueBtn() => ClickButton(ContinueBtn);
    }
}
