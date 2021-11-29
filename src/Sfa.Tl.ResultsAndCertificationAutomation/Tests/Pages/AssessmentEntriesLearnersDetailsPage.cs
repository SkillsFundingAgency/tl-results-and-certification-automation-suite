﻿using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class AssessmentEntriesLearnersDetailsPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "assessment-entry-learner-details");
        private const string PageTitle = "Learner details - Assessment entries – Manage T Level results – GOV.UK";
        private const string ExpectedPageHeader = "Learner's assessment entries";
        private const string ExpectedSubPageHeader = "Learner's details";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By SubHeader { get; } = By.XPath("//*[@id='main-content']/div/div/h2");

        private static By LearnerDetailsElement { get; } = By.XPath("//*[@id='main-content']/div/div/dl");
        private static By CoreSpecialismTextElement { get; } = By.Id("add-entries");

        private static By SearchAgainButton { get; } = By.Id("searchAgainButton");

        private static By AddAnOccupationalSpecialismLink { get; } = By.LinkText("Add an occupational specialism to this learner's record");
        private static By AddCoreAssessmentSeriesLink { get; } = By.XPath("//*[@id='add-entries']/p[2]/a");
        
        private static By HomeBreadcrumb { get; } = By.Id("breadcrumb0");
        private static By AssessmentsBreadcrumb { get; } = By.Id("breadcrumb1");
        private static By SearchForALearnerBreadcrumb { get; } = By.Id("breadcrumb2");

        public static void VerifyAssessmentEntriesDetailsPage()
        {
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.IsTrue(WebDriver.FindElement(SubHeader).Text.Contains(ExpectedSubPageHeader));
        }

        public static void VerifyLearnerDetails(string ULN)
        {
            string ExpectedName = "4714 Name 1 Name 2";
            string ExpectedProvider = "Barnsley College";
            string ExpectedDOB = "10 January 2006";
            string ExpectedTLevel = "T Level in Building Services Engineering for Construction";
            string ExpectedUKPRN = "10000536";

            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(ULN));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(ExpectedName));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(ExpectedDOB));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(ExpectedProvider));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(ExpectedUKPRN));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(ExpectedTLevel));
        }

        public static void VerifyCoreDetailsText(string CoreText)
        {
            Assert.IsTrue(WebDriver.FindElement(CoreSpecialismTextElement).Text.Contains(CoreText));
        }

        public static void VerifyCoreNoAssessSeriesAddedText()
        {
            string CurrentAssessmentSeries = SqlQueries.GetAssessmentSeries();
            string ExpectedNoAssessmentSeriedAddedText = "No assessment entries have yet been recorded for " + CurrentAssessmentSeries.ToLower();
            Assert.IsTrue(WebDriver.FindElement(CoreSpecialismTextElement).Text.Contains(ExpectedNoAssessmentSeriedAddedText));
        }

        public static void VerifySpecialismNoAssessSeriesAddedText()
        {
            string CurrentSpecialismAssessmentSeries = SqlQueries.GetSpecialismAssessmentSeries();
            string ExpectedNoSpecialismAssessmentSeriedAddedText = "No assessment entries have yet been recorded for " + CurrentSpecialismAssessmentSeries.ToLower();
            Assert.IsTrue(WebDriver.FindElement(CoreSpecialismTextElement).Text.Contains(ExpectedNoSpecialismAssessmentSeriedAddedText));
        }

        public static void VerifyAddRemoveCoreLinkText(string LinkText)
        {
            Assert.IsTrue(WebDriver.FindElement(CoreSpecialismTextElement).Text.Contains(LinkText));
        }
             

        public static void VerifySpecialismDetailsText(string SpecialismText)
        {
            Assert.IsTrue(WebDriver.FindElement(CoreSpecialismTextElement).Text.Contains(SpecialismText));
        }


        public static void PressSearchAgainButton()
        {
            ClickElement(SearchAgainButton);
        }

        public static void PressAddOccupationalSpecialismLink()
        {
            ClickElement(AddAnOccupationalSpecialismLink);
        }

        public static void PressHomeBreadcrumb()
        {
            ClickElement(HomeBreadcrumb);
        }
        public static void PressAssessmentsBreadcrumb()
        {
            ClickElement(AssessmentsBreadcrumb);
        }
        public static void PressSearchForALearnerBreadcrumb()
        {
            ClickElement(SearchForALearnerBreadcrumb);
        }

        public static void VerifyAddOccupationalSpecialismLinkText()
        {
            Assert.IsTrue(WebDriver.FindElement(AddAnOccupationalSpecialismLink).Text.Contains("Add an occupational specialism to this learner's record"));
        }

        public static void PressAddACoreAssessmentSeries()
        {
            ClickElement(AddCoreAssessmentSeriesLink);
        }
    }
}
