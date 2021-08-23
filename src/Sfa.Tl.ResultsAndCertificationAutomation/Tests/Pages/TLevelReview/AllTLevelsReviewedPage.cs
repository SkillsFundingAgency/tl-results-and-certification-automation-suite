using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.TLevelReview
{
    public class AllTLevelsReviewedPage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "all-tlevels-reviewed");
        private static string pageTitle { get; } = "All T Levels reviewed – Manage T Level results – GOV.UK";
        private static string pageHeader { get; } = "You have reviewed all of your T Levels";
        private static readonly By pageHeaderElement = By.XPath("//*[@id='main-content']//h1");

        private static By homeBreadcrumb { get; } = By.Id("breadcrumb0");
        private static By tLevelsBreadcrumb { get; } = By.Id("breadcrumb1");
        private static By backToTLevelsButton { get; } = By.Id("backToTlevelButton");
        private static By backToHomeButton { get; } = By.Id("backToHome");
        private static By confirmedTLevelLink { get; } = By.Id("linkConfirmedTlevels");
        private static By registerLink { get; } = By.Id("linkRegister");
        private static By addTLevelsLink { get; } = By.Id("linkAddTlevel");

        public static void VerifyAllTLevelsReviewedPage()
        {          
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(WebDriver.Title, pageTitle);
            Assert.AreEqual(WebDriver.FindElement(pageHeaderElement).Text, pageHeader);
        }

        public static void ClickHomeBreadcrumb()
        {
            ClickElement(homeBreadcrumb);
        }

        public static void ClickTLevelsBreadcrumb()
        {
            ClickElement(tLevelsBreadcrumb);
        }
        public static void ClickBackToTLevelsBtn()
        {
            ClickElement(backToTLevelsButton);
        }

        public static void ClickConfirmTLevelsLink()
        {
            ClickElement(confirmedTLevelLink);
        }
        public static void ClickRegisterLink()
        {
            ClickElement(registerLink);
        }

        public static void ClickAddTLevelsLink()
        {
            ClickElement(addTLevelsLink);
        }

        public static void ClickBackToHomeBtn()
        {
            ClickElement(backToHomeButton);
        }
    }
}
