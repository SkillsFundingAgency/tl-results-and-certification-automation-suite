using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class RequestSOA_SearchForALearnerPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "request-statement-of-achievement-unique-learner-number");
        public static string PageTitle = "Search for a learner - Enter Unique Learner Number page – Manage T Level results – GOV.UK";
        public static string ErrorPageTitle = "Error: Search for a learner - Enter Unique Learner Number page – Manage T Level results – GOV.UK";
        public static By SearchButton { get; } = By.Id("searchButton");
        public static string ExpectedButtonText = "Search";
        public static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        public static string PageHeaderText = "Search for a learner";

        public static By ULNTextField { get; } = By.Id("searchuln");
        private static By UlnHint = By.ClassName("govuk-hint");
        public static string ULNHintText = "ULN must be 10 digits long";

        public static string ExpectedPageText = "Enter the Unique Learner Number (ULN) for a learner who has withdrawn from their T Level course.";
        private static By PageText = By.XPath("//*[contains(text(),'Enter the Unique Learner Number')]");

        public static By MainErrorMessage = By.XPath("//*[@id='main-content']//ul/li/a");
        public static By SubErrorMessage = By.XPath("//*[@id='main-content']//span[2]");

        public static By RequestStatementOfAchievementBreadcrumb { get; } = By.Id("breadcrumb1");
        public static By HomeBreadcrumb { get; } = By.Id("breadcrumb0");



        public static void VerifySearchForALearnerPage()
        {
            Assert.AreEqual(PageUrl, WebDriver.Url);
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(PageHeaderText, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(ULNHintText, WebDriver.FindElement(UlnHint).Text);
            Assert.AreEqual(ExpectedPageText, WebDriver.FindElement(PageText).Text);
        }

        public static void ClickSearch()
        {
            WebDriver.FindElement((SearchButton)).Click();
        }

        public static void ClickHomeBreadcrumb()
        {
            WebDriver.FindElement((HomeBreadcrumb)).Click();
        }


        public static void ClickRequestStatementOfAchievementBreadcrumb()
        {
            WebDriver.FindElement((RequestStatementOfAchievementBreadcrumb)).Click();
        }


        public static void VerifySeachUlnField(string uln)
        {
            Assert.AreEqual(uln, WebDriver.FindElement(ULNTextField).GetAttribute("value"));
        }


        public static void VerifyErrorMessage(string ErrorMessage)
        {
            Assert.AreEqual(ErrorPageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.FindElement(MainErrorMessage).Text.Contains(ErrorMessage));
            Assert.IsTrue(WebDriver.FindElement(SubErrorMessage).Text.Contains(ErrorMessage));
        }

        public static void EnterULN(string ULN)
        {
            WebDriver.FindElement(ULNTextField).Clear();
            EnterText(ULNTextField, ULN);
            ClickElement(SearchButton);
        }

    }
}
