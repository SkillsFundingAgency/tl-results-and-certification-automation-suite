using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals
{
    public class RAUExceptionsStartPage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "appeal-grade-after-deadline");
        private static string pageTitle { get; } = "Appeal a grade after the deadline – Manage T Level results – GOV.UK";
        private static string pageHeader { get; } = "Appeal a grade after the deadline";
        private static readonly By pageHeaderElement = By.XPath("//*[@id='main-content']//h1");
        private static By continueBtn { get; } = By.Id("continueButton");
        private static By backLink { get; } = By.Id("backLink");



        public static void VerifyExceptionsStartPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(pageTitle, WebDriver.Title);
            Assert.AreEqual(pageHeader, WebDriver.FindElement(pageHeaderElement).Text);
        }
        public static void ClickBackLink()
        {
            ClickElement(backLink);    
        }
        public static void ClickContinueBtn()
        {
            ClickElement(continueBtn);
        }
    }
}
