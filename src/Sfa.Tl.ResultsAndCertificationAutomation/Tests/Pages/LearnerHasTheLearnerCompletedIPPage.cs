using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Model;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class LearnerHasTheLearnerCompletedIPPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "has-learner-completed-industry-placement");
        public static string PageTitle = "Add a new learner T Level record - Industry placement status page – Manage T Level results – GOV.UK";
        public static string ErrorPageTitle = "Error: Add a new learner T Level record - Industry placement status page – Manage T Level results – GOV.UK";
        public static By ContinueButton { get; } = By.Id("continueButton");
        public static string ExpectedButtonText = "Continue";
        public static By MainHeader { get; } = By.XPath("//*[@id='main-content']//form/div/span");
        public static string MainHeaderText = "Add a new learner T Level record";
        public static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        public static string PageHeaderText = "Has the learner completed their industry placement?";

        public static By LearnerText = By.XPath("//*[@id='uln-hint']");
        public static By BackLink { get; } = By.Id("backLink");

        public static By RadioButtonYesCompleted { get; } = By.Id("industryplacementstatus");
        public static By RadioButtonYesSpecialConsideration { get; } = By.Id("tl-industry-placement-status-wsp");
        public static By RadioButtonNo { get; } = By.Id("tl-industry-placement-status-not-comp");
        public static By RadioButtonYesCompletedLabel { get; } = By.XPath("//*[@id='main-content']//div[1]/label");
        public static By RadioButtonYesSpecialConsiderationLabel { get; } = By.XPath("//*[@id='main-content']//div[2]/label");
        public static By RadioButtonNoLabel { get; } = By.XPath("//*[@id='main-content']//div[3]/label");

         public static By MainErrorMessage = By.XPath("//*[@id='main-content']//ul/li/a");
         public static By SubErrorMessage = By.XPath("//*[@id='main-content']//div[2]//div/span");
         public static By WhatAreSpecialConsiderationsLink = By.XPath("//*[@id='main-content']//summary/span");
         public static string ExpectedSpecialConsiderationsLinkText = "What are special considerations?";

        public static void VerifyLearnerHasTheLearnerCompletedIPPage(string uln)
        {
            string ExpectedLearnerHeading = "Learner: Db FirstName Db LastName";
            Assert.AreEqual(ExpectedLearnerHeading, WebDriver.FindElement(LearnerText).Text);
            Assert.AreEqual(PageUrl, WebDriver.Url);
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(MainHeaderText, WebDriver.FindElement(MainHeader).Text);
            Assert.AreEqual(PageHeaderText, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual("Yes, completed", WebDriver.FindElement(RadioButtonYesCompletedLabel).Text);
            Assert.AreEqual("Yes, completed with special consideration", WebDriver.FindElement(RadioButtonYesSpecialConsiderationLabel).Text);
            Assert.AreEqual("No, still to be completed", WebDriver.FindElement(RadioButtonNoLabel).Text);
            Assert.AreEqual(ExpectedSpecialConsiderationsLinkText, WebDriver.FindElement(WhatAreSpecialConsiderationsLink).Text);
        }
        public static void VerifyChangeHasTheLearnerCompletedIPPage()
        {
            string ExpectedLearnerHeading = "Learner: Db FirstName Db LastName";
            Assert.AreEqual(ExpectedLearnerHeading, WebDriver.FindElement(LearnerText).Text);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(MainHeaderText, WebDriver.FindElement(MainHeader).Text);
            Assert.AreEqual(PageHeaderText, WebDriver.FindElement(PageHeader).Text);
        }

        public static void ClickContinue()
        {
            WebDriver.FindElement((ContinueButton)).Click();
        }

        public static void ClickBackLink()
        {
            WebDriver.FindElement((BackLink)).Click();
        }


        public static void VerifyAddANewLearnerRecordErrorPage()
        {
            Assert.AreEqual(PageUrl, WebDriver.Url);
            Assert.AreEqual(ErrorPageTitle, WebDriver.Title);
        }

        public static void VerifyErrorMessage(string ErrorMessage)
        {
            Assert.AreEqual(ErrorPageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.FindElement(MainErrorMessage).Text.Contains(ErrorMessage));
            Assert.IsTrue(WebDriver.FindElement(SubErrorMessage).Text.Contains(ErrorMessage));
        }

        public static void VerifyRadioButtonsNotSelected()
        {
            Assert.AreEqual(false, WebDriver.FindElement(RadioButtonYesCompleted).Selected);
            Assert.AreEqual(false, WebDriver.FindElement(RadioButtonYesSpecialConsideration).Selected);
            Assert.AreEqual(false, WebDriver.FindElement(RadioButtonNo).Selected);
        }

        public static void ClickYesCompletedRadio()
        {
            ClickElement(RadioButtonYesCompleted);
        }
        public static void ClickIpStatus()
        {
            ClickElement(RadioButtonYesCompleted);
        }

        public static void ClickYesCompletedSpecialRadio()
        {
            WebDriver.FindElement((RadioButtonYesSpecialConsideration)).Click();
        }

        public static void ClickNoRadio()
        {
            WebDriver.FindElement((RadioButtonNo)).Click();
        }

        public static void ClickRadioButton(string RadioButton)
        {
            switch (RadioButton)
            {
                case "Yes, completed":
                    ClickYesCompletedRadio();
                    break;
                case "Yes, completed with special consideration":
                    ClickYesCompletedSpecialRadio();
                    break;
                case "No, still to be completed":
                    ClickNoRadio();
                    break;
               
            }
            ClickContinue();
        }

        public static IndustryPlacementStatus GetIpStatusByLabel(string text)
        {
            switch (text)
            {
                case "Yes, completed":
                    return IndustryPlacementStatus.Completed;
                case "Yes, completed with special consideration":
                    return IndustryPlacementStatus.CompletedWithSpecialConsideration;
                case "No, still to be completed":
                    return IndustryPlacementStatus.NotCompleted;
            }
            return IndustryPlacementStatus.NotSpecified;
        }
        public static void ClickEMRadioButton(string RadioButton)
        {
            switch (RadioButton)
            {
                case "Achieved the minimum standard":
                    ClickYesCompletedRadio();
                    break;
                case "Achieved the minimum standard with SEND adjustments":
                    ClickYesCompletedSpecialRadio();
                    break;
                case "Not achieved the minimum standard":
                    ClickNoRadio();
                    break;

            }
            ClickContinue();
        }
        public static EnglishAndMathsStatus GetEMStatusByLabel(string text)
        {
            switch (text)
            {
                case "Achieved the minimum standard":
                    return EnglishAndMathsStatus.Achieved;
                case "Achieved the minimum standard with SEND adjustments":
                    return EnglishAndMathsStatus.AchievedWithSend;
                case "Not achieved the minimum standard":
                    return EnglishAndMathsStatus.NotAchieved;
            }
            return EnglishAndMathsStatus.NotSpecified;
        }

    }
}
