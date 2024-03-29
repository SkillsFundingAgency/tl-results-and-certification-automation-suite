﻿using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class AssessmentEntriesAddSpecialismAssessmentEntryPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "assessment-entry-add-specialism");
        private const string PageTitle = "Add specialism(s) - Assessment entry – Manage T Level results – GOV.UK";
        private const string ErrorPageTitle = "Error: Add specialism(s) - Assessment entry – Manage T Level results – GOV.UK";
        private const string ExpectedPageHeader = "Add occupational specialism(s) assessment entry to ";
        private const string ExpectedSubPageHeader = "Is this learner entering an assessment for ";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By SubHeader { get; } = By.XPath("//*[contains(text(),'Is this learner entering an assessment for')]");
        private static By YesRadioButton { get; } = By.XPath("//*[contains(text(),'Yes, add entry to')]");
        private static By NoRadioButton { get; } = By.XPath("//*[contains(text(),'No, do not add entry to')]");
        private static By SubmitButton { get; } = By.Id("submitButton");
        private static By BackLink { get; } = By.Id("backLink");
        private const string ExpectedSubmitButtonText = "Submit";
        private const string ExpectedYesRadioText = "Yes, add entry to ";
        private const string ExpectedNoRadioText = "No, do not add entry to ";

        private const string NoRadioSelectedErrorMessage = "Select whether the learner is entering an assessment";
        private static readonly By MainNoRadioButtonSelectedError = By.XPath("//*[@id='addSpecialismAssessmentForm']/div[1]/div");
        private static readonly By SubNoRadioButtonSelectedError = By.XPath("//*[@id='main-content']//div[2]//span");
        private static By LearnerDetailsElement { get; } = By.Id("addSpecialismAssessmentForm");
        private static By SuccessBanner { get; } = By.XPath("//*[@class='govuk-notification-banner govuk-notification-banner--success']//h2");

        public static void VerifyAddSpecialismAssessmentEntryPage(string Specialisms)
        {
            var currentAssessmentSeries = SqlQueries.GetSpecialismAssessmentSeries();
            var expectedPageHeader1 = ExpectedPageHeader + currentAssessmentSeries.ToLower();
            var expectedSubPageHeader1 = ExpectedSubPageHeader + Specialisms +" in " + currentAssessmentSeries.ToLower() + "?";
            var expectedYesRadioText1 = ExpectedYesRadioText + currentAssessmentSeries.ToLower();
            var expectedNoRadioText1 = ExpectedNoRadioText + currentAssessmentSeries.ToLower();
         

            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(expectedPageHeader1, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(ExpectedSubmitButtonText, WebDriver.FindElement(SubmitButton).Text);
            Assert.AreEqual(expectedYesRadioText1, WebDriver.FindElement(YesRadioButton).Text);
            Assert.AreEqual(expectedNoRadioText1, WebDriver.FindElement(NoRadioButton).Text);
            Assert.AreEqual(expectedSubPageHeader1, WebDriver.FindElement(SubHeader).Text);
        }

        public static void VerifyLearnerDetails(string uln)
        {
            const string expectedName = "4714 Name 1 Name 2";
            const string expectedProvider = "Barnsley College";
            const string expectedDob = "10 January 2006";
            const string expectedTLevel = "T Level in Building Services Engineering for Construction";
            const string expectedUkprn = "10000536";

            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(uln));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(expectedName));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(expectedDob));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(expectedProvider));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(expectedUkprn));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(expectedTLevel));
        }

        public static void VerifyRadioButtonsNotPrepopulated()
        {
            Assert.AreEqual(false, WebDriver.FindElement(YesRadioButton).Selected);
            Assert.AreEqual(false, WebDriver.FindElement(NoRadioButton).Selected);
        }

        public static void PressSubmitButton()
        {
            ClickElement(SubmitButton);
        }

        public static void PressYesRadioButton()
        {
            ClickElement(YesRadioButton);
            ClickElement(SubmitButton);
        }

        public static void PressNoRadioButton()
        {
            ClickElement(NoRadioButton);
            ClickElement(SubmitButton);
        }

        public static void PressBackLink()
        {
            ClickElement(BackLink);
        }

        public static void VerifyNoRadioButtonSelectedError()
        {
            Assert.IsTrue(WebDriver.FindElement(MainNoRadioButtonSelectedError).Text.Contains(NoRadioSelectedErrorMessage));
            Assert.IsTrue(WebDriver.FindElement(SubNoRadioButtonSelectedError).Text.Contains(NoRadioSelectedErrorMessage));
            Assert.AreEqual(ErrorPageTitle, WebDriver.Title);
        }

        public static void VerifySuccessBanner()
        {
            Assert.AreEqual("Success",WebDriver.FindElement(SuccessBanner).Text);
        }
    }
}
