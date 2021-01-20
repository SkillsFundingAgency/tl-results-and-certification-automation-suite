using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class ResultsSearchForALearnerPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "results-learner-search");
        private static readonly string PageTitle = "Results - Search for a learner page – Manage T Level results – GOV.UK";
        private static readonly string PageErrorTitle = "Error: Results - Search for a learner page – Manage T Level results – GOV.UK";
        public static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        public static readonly string ExpectedPageHeaderText = "Search for a learner";
        public static By PageTextLine1 { get; } = By.XPath("//*[@id='main-content']//form//p");
        public static readonly string ExpectedPageTextLine1Text = "You can add, view and amend a learner's results.";
        public static By PageTextLine2 { get; } = By.XPath("//label[@for='searchuln']");
        public static readonly string ExpectedPageTextLine2Text = "Enter the Unique Learner Number (ULN)";
        public static By PageTextGreyText { get; } = By.XPath("//*[@id='main-content']//span[1]");
        public static readonly string ExpectedPageTextGreyText = "ULN must be 10 digits long";
        public static By SearchButton { get; } = By.Id("searchButton");
        public static readonly string ExpectedButtonText = "Search";
        public static By SearchBox = By.Id("searchuln");

        public static readonly string NullErrorMsgText = "Enter a ULN";
        public static readonly string InvalidErrorMsgText = "Enter a valid ULN";
        public static By MainErrorMsg { get; } = By.XPath("//*[contains(@href,'searchuln')]");
        public static By SubErrorMsg { get; } = By.XPath("//*[@id='main-content']//div/span[2]");

        public static By HomeBreadcrumb { get; } = By.Id("breadcrumb0");
        public static By ResultsBreadcrumb { get; } = By.Id("breadcrumb1");

        public static new void ClickButton(By locator)
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

        public static void EnterULN(string ULN)
        {
            EnterText(SearchBox, ULN);
            ClickElement(SearchButton);
        }


        public static void VerifyEmptyULNSearchErrorMessage()
        {
            Assert.IsTrue(WebDriver.FindElement(MainErrorMsg).Text.Contains(NullErrorMsgText));
            Assert.IsTrue(WebDriver.FindElement(SubErrorMsg).Text.Contains(NullErrorMsgText));
            Assert.AreEqual(PageErrorTitle, WebDriver.Title);
        }

        public static void VerifyInvalidULNSearchErrorMessage()
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

        public static void VerifySearchFieldIsPrePopulated(string ULN)
        {
            Assert.AreEqual(ULN, WebDriver.FindElement(SearchBox).GetAttribute("value"));

        }

        public static void VerifySearchFieldIsEmpty()
        {
            string NULL = "";
            Assert.AreEqual(NULL, WebDriver.FindElement(SearchBox).GetAttribute("value"));

        }

    }
}
