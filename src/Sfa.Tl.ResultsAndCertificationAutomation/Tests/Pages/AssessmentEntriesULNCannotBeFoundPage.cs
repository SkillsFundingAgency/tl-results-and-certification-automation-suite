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

        public static void VerifyAssessmentEntriesULNNotFoundPage()
        {
            Assert.AreEqual(URLNotFoundPageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
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
