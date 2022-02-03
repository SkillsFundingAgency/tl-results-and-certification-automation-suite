using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class ResultsSearchForALearnerPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "results-search-uln");
        private const string PageTitle = "Search ULN - Results – Manage T Level results – GOV.UK";
        private const string PageErrorTitle = "Error: Search ULN - Results – Manage T Level results – GOV.UK";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private const string ExpectedPageHeaderText = "Search for a learner";
        private static By PageTextLine1 { get; } = By.XPath("//*[@id='main-content']//form//p");
        private const string ExpectedPageTextLine1Text = "You can add, view and amend a learner's results.";
        private static By PageTextLine2 { get; } = By.XPath("//label[@for='searchuln']");
        private const string ExpectedPageTextLine2Text = "Enter the Unique Learner Number (ULN)";
        private static By PageTextGreyText { get; } = By.XPath("//*[@id='main-content']//span[1]");
        private const string ExpectedPageTextGreyText = "ULN must be 10 digits long";
        private static By SearchButton { get; } = By.Id("searchButton");
        private const string ExpectedButtonText = "Search";
        private static readonly By SearchBox = By.Id("searchuln");

        private const string NullErrorMsgText = "Enter a ULN";
        private const string InvalidErrorMsgText = "Enter a valid ULN";
        private static By MainErrorMsg { get; } = By.XPath("//*[contains(@href,'searchuln')]");
        private static By SubErrorMsg { get; } = By.XPath("//*[@id='main-content']//div/span[2]");

        private static By HomeBreadcrumb { get; } = By.Id("breadcrumb0");
        private static By ResultsBreadcrumb { get; } = By.Id("breadcrumb1");

        public new static void ClickButton(By locator)
        {
            WebDriver.FindElement((locator)).Click();
        }
        public static void VerifyResultsSearchLearnerPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedPageHeaderText, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(ExpectedPageTextLine1Text, WebDriver.FindElement(PageTextLine1).Text);
            Assert.AreEqual(ExpectedPageTextLine2Text, WebDriver.FindElement(PageTextLine2).Text);
            Assert.AreEqual(ExpectedPageTextGreyText, WebDriver.FindElement(PageTextGreyText).Text);
            Assert.IsTrue(WebDriver.FindElement(SearchButton).Text.Contains(ExpectedButtonText));
        }

        public static void EnterUln(string uln)
        {
            EnterText(SearchBox, uln);
            ClickElement(SearchButton);
        }


        public static void VerifyEmptyUlnSearchErrorMessage()
        {
            Assert.IsTrue(WebDriver.FindElement(MainErrorMsg).Text.Contains(NullErrorMsgText));
            Assert.IsTrue(WebDriver.FindElement(SubErrorMsg).Text.Contains(NullErrorMsgText));
            Assert.AreEqual(PageErrorTitle, WebDriver.Title);
        }

        public static void VerifyInvalidUlnSearchErrorMessage()
        {
            Assert.IsTrue(WebDriver.FindElement(MainErrorMsg).Text.Contains(InvalidErrorMsgText));
            Assert.IsTrue(WebDriver.FindElement(SubErrorMsg).Text.Contains(InvalidErrorMsgText));
            Assert.AreEqual(PageErrorTitle, WebDriver.Title);
        }

        public static void ClickHomeBreadcrumb()
        {
            WebDriver.FindElement((HomeBreadcrumb)).Click();
        }

        public static void ClickResultsBreadcrumb()
        {
            WebDriver.FindElement((ResultsBreadcrumb)).Click();
        }

        public static void VerifySearchFieldIsPrePopulated(string uln)
        {
            Assert.AreEqual(uln, WebDriver.FindElement(SearchBox).GetAttribute("value"));

        }

        public static void VerifySearchFieldIsEmpty()
        {
            Assert.AreEqual("", WebDriver.FindElement(SearchBox).GetAttribute("value"));
        }

    }
}
