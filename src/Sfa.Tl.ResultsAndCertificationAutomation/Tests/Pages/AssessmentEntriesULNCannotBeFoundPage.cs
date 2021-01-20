using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class AssessmentEntriesULNCannotBeFoundPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "search-for-learner-ULN-not-found");
        private const string URLNotFoundPageTitle = "Assessment entries - ULN cannot be found page – Manage T Level results – GOV.UK";
       
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        public static By BackToSearchBtn { get; } = By.Id("backButton");
        public static By SearchField { get; } = By.Id("searchuln");
        public static By MainErrorMessageInvalidULN = By.XPath("//*[@id='main-content']//ul/li/a");
        public static By SubErrorMessage = By.XPath("//*[@id='main-content']//div/span[2]");
        public static By MainErrorMessage = By.XPath("//*[@id='main-content']//ul/li/a");
        public static By SubErrorMessageMissingULN = By.XPath("//*[@id='main-content']//div/span[2]");
        public static By HomeBreadcrumb { get; } = By.Id("breadcrumb0");
        public static By AssessMentEntriesBreadcrumb { get; } = By.Id("breadcrumb1");
        private static By BackLink = By.Id("backLink");
        private static By SubHeader = By.XPath("//*[@id='main-content']/div/div/div/p");
        private static By Bullet1 = By.XPath("//*[@id='main-content']//ul/li[1]");
        private static By Bullet2 = By.XPath("//*[@id='main-content']//ul/li[2]");
        private static string ExpectedSubHeaderText = "If you think that the ULN should exist it may be that it:";
        private static string ExpectedBullet1Text = "is registered with another awarding organisation";
        private static string ExpectedBullet2Text = "is not registered with us";

        public static void VerifyAssessmentEntriesULNNotFoundPage()
        {
            Assert.AreEqual(URLNotFoundPageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(ExpectedSubHeaderText, WebDriver.FindElement(SubHeader).Text);
            Assert.AreEqual(ExpectedBullet1Text, WebDriver.FindElement(Bullet1).Text);
            Assert.AreEqual(ExpectedBullet2Text, WebDriver.FindElement(Bullet2).Text);
        }

        public static void PressBackToSearch()
        {
            ClickElement(BackToSearchBtn);
        }

        public static void PressHomeBreadcrumb()
        {
            ClickElement(HomeBreadcrumb);
        }

        public static void PressBackLink()
        {
            ClickElement(BackLink);
        }

        public static void PressAssessmentEntriesBreadcrumb()
        {
            ClickElement(AssessMentEntriesBreadcrumb);
        }

        public static void VerifyPageText(string ULN)
        {
            string MainHeader = "ULN (" + ULN + ") cannot be found";
            Assert.AreEqual(MainHeader, WebDriver.FindElement(PageHeader).Text);
        }


    }
}
