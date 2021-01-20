using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class ResultsULNNotFoundPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "search-for-learner-results-ULN-not-found");
        private static readonly string PageTitle = "Results - ULN cannot be found page – Manage T Level results – GOV.UK";
        
        public static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        
        public static By PageTextLine1 { get; } = By.XPath("//*[@id='main-content']/div/div/div/p");
        public static readonly string ExpectedPageText = "If you think that the ULN should exist it may be that it:";
        public static By Bullet1 { get; } = By.XPath("//*[@id='main-content']//ul/li[1]");
        public static readonly string ExpectedBullet1Text = "is registered with another awarding organisation";
        public static By Bullet2 { get; } = By.XPath("//*[@id='main-content']//ul/li[2]");
        public static readonly string ExpectedBullet2Text = "is not registered with us";

        public static By BackToSearchButton { get; } = By.Id("backButton");
        public static readonly string ExpectedButtonText = "Back to search";
        public static By BackLink    { get; } = By.Id("backLink");

        public static new void ClickButton(By locator)
        {
            WebDriver.FindElement((locator)).Click();
        }
        public static void VerifyResultsULNNotFoundPage(string ULN)
        {
            string ExpectedHeaderText = "ULN (" + ULN + ") cannot be found";

            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedHeaderText, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(ExpectedPageText, WebDriver.FindElement(PageTextLine1).Text);
            Assert.AreEqual(ExpectedBullet1Text, WebDriver.FindElement(Bullet1).Text);
            Assert.AreEqual(ExpectedBullet2Text, WebDriver.FindElement(Bullet2).Text);
            Assert.IsTrue(WebDriver.FindElement(BackToSearchButton).Text.Contains(ExpectedButtonText));
        }   

        public static void ClickBackLink()
        {
            WebDriver.FindElement((BackLink)).Click();
        }

        public static void ClickBackToSearchButton()
        {
            WebDriver.FindElement((BackToSearchButton)).Click();
        }


    }
}
