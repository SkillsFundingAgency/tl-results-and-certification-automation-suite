using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class LearnerAddLearnerPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "add-learner-record-unique-learner-number");
        public static string PageTitle = "Add a new learner record - Enter Unique Learner Number page – Manage T Level results – GOV.UK";
        public static string ErrorPageTitle = "Error: Add a new learner record - Enter Unique Learner Number page – Manage T Level results – GOV.UK";
        public static By ContinueButton { get; } = By.Id("continueButton");
        public static string ExpectedButtonText = "Continue";
        public static By MainHeader { get; } = By.XPath("//*[@id='main-content']//form/div/span");
        public static string MainHeaderText = "Add a new learner record";
        public static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        public static string PageHeaderText = "Enter the Unique Learner Number (ULN)";
        public static By BackLink { get; } = By.Id("backLink");
        public static By ULNTextField { get; } = By.Id("enteruln");
        private static By UlnHint = By.XPath("uln-number-hint");
        public static string ULNHintText = "ULN must be 10 digits long";
        public static string ExpectedPageText = "You can only add records for learners who have been registered on a T Level programme by an awarding organisation.";
        private static By PageText = By.XPath("//*[contains(text(),'You can only add records for learners')]");
        public static By MainErrorMessage = By.XPath("//*[@id='main-content']//ul/li/a");
        public static By SubErrorMessage = By.XPath("//*[@id='main-content']//span[2]");

        public static void ClickContinue()
        {
            WebDriver.FindElement((ContinueButton)).Click();
        }

        public static void ClickBackLink()
        {
            WebDriver.FindElement((BackLink)).Click();
        }

        public static void VerifyAddANewLearnerRecordPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(MainHeaderText, WebDriver.FindElement(MainHeader).Text);
            Assert.AreEqual(PageHeaderText, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.FindElement(PageText).Text.Contains(ExpectedPageText));
            Assert.IsTrue(WebDriver.FindElement(ContinueButton).Text.Contains(ExpectedButtonText));
        }
        public static void VerifyAddANewLearnerRecordErrorPage()
        {
            Assert.AreEqual(PageUrl, WebDriver.Url);
            Assert.AreEqual(ErrorPageTitle, WebDriver.Title);
        }

        public static void VerifyErrorMessage(string ErrorMessage)
        {
            Assert.IsTrue(WebDriver.FindElement(MainErrorMessage).Text.Contains(ErrorMessage));
            Assert.IsTrue(WebDriver.FindElement(SubErrorMessage).Text.Contains(ErrorMessage));
        }

        public static void EnterULN(string ULN)
        {
            EnterText(ULNTextField, ULN);
            ClickElement(ContinueButton);
        }

        public static void PressContinueButton()
        {
            ClickElement(ContinueButton);
        }

    }
}
