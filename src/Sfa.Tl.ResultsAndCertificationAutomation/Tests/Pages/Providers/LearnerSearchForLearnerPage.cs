using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class LearnerSearchForLearnerPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "search-learner-record-unique-learner-number");
        public static string PageTitle = "Search for a learner - Enter Unique Learner Number page – Manage T Level results – GOV.UK";
        public static string ErrorPageTitle = "Error: Search for a learner - Enter Unique Learner Number page – Manage T Level results – GOV.UK";
        public static By SearchButton { get; } = By.Id("searchButton");
        public static string ExpectedButtonText = "Search";
        public static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        public static string PageHeaderText = "Search for a learner";
       
        public static By ULNTextField { get; } = By.Id("searchuln");
        private static By UlnHint = By.ClassName("govuk-hint");
        public static string ULNHintText = "ULN must be 10 digits long";

        public static string ExpectedPageText = "You can view and update learner T Level records you’ve already added.";
        private static By PageText = By.XPath("//*[contains(text(),'You can view and update learner T Level records you’ve already added.')]");

        public static string ExpectedPageText2 = "Enter the Unique Learner Number (ULN)";
        private static By PageText2 = By.XPath("//*[contains(text(),'Enter the Unique Learner')]");
        public static By MainErrorMessage = By.ClassName("govuk-error-summary__body");
        public static By SubErrorMessage = By.ClassName("govuk-error-message");
        public static By ManageLearnerRecordsBreadcrumb = By.Id("breadcrumb1");
        public static By HomeBreadcrumb = By.Id("breadcrumb0");

        public static void VerifyLearnerSearchForLearnerPage()
        {
            Assert.AreEqual(PageUrl, WebDriver.Url);
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(PageHeaderText, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(ULNHintText, WebDriver.FindElement(UlnHint).Text);
            Assert.AreEqual(ExpectedPageText, WebDriver.FindElement(PageText).Text);
            Assert.AreEqual(ExpectedPageText2, WebDriver.FindElement(PageText2).Text);
        }
       
        public static void ClickSearch()
        {
            WebDriver.FindElement((SearchButton)).Click();
        }


        public static void VerifyErrorMessage(string ErrorMessage)
        {
            Assert.AreEqual(ErrorPageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.FindElement(MainErrorMessage).Text.Contains(ErrorMessage));
            Assert.IsTrue(WebDriver.FindElement(SubErrorMessage).Text.Contains(ErrorMessage));
        }

        public static void EnterULN(string ULN)
        {
            EnterText(ULNTextField, ULN);
            ClickElement(SearchButton);
        }
        public static void VerifySearchULNFieldPopulated(string uln)
        {
            string ULNInputValue = WebDriver.FindElement(ULNTextField).GetAttribute("value");
            Assert.AreEqual(ULNInputValue, uln);
        }
        public static void ClearSearchField()
        {
            WebDriver.FindElement(ULNTextField).Clear();
        }

        public static void ClickManageLearnerRecordsBreadcrumb()
        {
            ElementHelper.ClickButton(ManageLearnerRecordsBreadcrumb);
        }

        public static void ClickHomeBreadcrumb()
        {
            ElementHelper.ClickButton(HomeBreadcrumb);
        }
    }
}
