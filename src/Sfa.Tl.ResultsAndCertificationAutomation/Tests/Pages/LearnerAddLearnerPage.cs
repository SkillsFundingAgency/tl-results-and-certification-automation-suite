using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class CommonUlnDbSteps : ElementHelper
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
        public static By BackToSearchBtn { get; } = By.Id("backButton");
        public static By ULNTextField { get; } = By.Id("enteruln");
        public static string ULNHintText = "ULN must be 10 digits long";
        public static string ExpectedPageText = "You can only add records for learners who have been registered on a T Level programme by an awarding organisation.";
        private static By PageText = By.XPath("//*[contains(text(),'You can only add records for learners')]");
        public static By MainErrorMessage = By.XPath("//*[@id='main-content']//ul/li/a");
        public static By SubErrorMessage = By.XPath("//*[@id='main-content']//span[2]");
        // Uln not found page
        private static string UlnNotRegisteredUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-learner-record-ULN-not-registered");
        private static string UlnNotRegisteredTitle { get; } = "Add a new learner record - ULN not registered page – Manage T Level results – GOV.UK";
        private static string UlnAlreadyAddedUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-learner-record-ULN-already-added");
        private static string UlnAlreadyAddedTitle { get; } = "Add a new learner record - ULN already added page – Manage T Level results – GOV.UK";

        public static void VerifyUlnNotRegisteredPage(string uln)
        {
            string ExpectedPageHeading = "ULN ("+uln+") has not been registered by the awarding organisation";
            Assert.AreEqual(UlnNotRegisteredUrl, WebDriver.Url);
            Assert.AreEqual(UlnNotRegisteredTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedPageHeading, WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyUlnAlreadyAddedPage(string uln)
        {
            string ExpectedPageHeading = "ULN (" + uln + ") has already been added";
            Assert.AreEqual(ExpectedPageHeading, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(UlnAlreadyAddedUrl));
            Assert.AreEqual(UlnAlreadyAddedTitle, WebDriver.Title);
        }
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

        public static void VerifySeachUlnField(string uln)
        {
            Assert.AreEqual(uln, WebDriver.FindElement(ULNTextField).GetAttribute("value"));
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
