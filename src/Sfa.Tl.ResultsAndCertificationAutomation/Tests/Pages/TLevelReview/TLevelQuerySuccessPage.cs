using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.TLevelReview
{
    public class TLevelQuerySuccessPage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "tlevel-query-sent");
        private static string pageTitle { get; } = "T Level query sent – Manage T Level results – GOV.UK";
        private static string pageHeader { get; } = "T Level details queried";
        private static readonly By pageHeaderElement = By.XPath("//*[@id='main-content']//h1");
        private static readonly By SuccessElement = By.ClassName("govuk-panel__body");
        private static readonly By backToTLevelsBtn = By.Id("tlevelsButton");
        private static readonly By backToHomeBtn = By.Id("homeButton");


        public static void VerifyQueryTLevelsSuccessPage()
        {          
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(WebDriver.Title, pageTitle);
            Assert.AreEqual(WebDriver.FindElement(pageHeaderElement).Text, pageHeader);
            Assert.AreEqual(WebDriver.FindElement(backToTLevelsBtn).Text, "Back to T Levels");
            Assert.AreEqual(WebDriver.FindElement(backToHomeBtn).Text, "Back to home");
        }

        public static void VerifyTLevelQueriedDetails(string TLevel)
        {
           Assert.IsTrue(WebDriver.FindElement(SuccessElement).Text.Contains(TLevel));
        }

        public static void ClickBackToHomeBtn()
        {
            ClickElement(backToHomeBtn);
        }

        public static void ClickBackToTLevelsBtn()
        {
            ClickElement(backToTLevelsBtn);
        }

    }
}
