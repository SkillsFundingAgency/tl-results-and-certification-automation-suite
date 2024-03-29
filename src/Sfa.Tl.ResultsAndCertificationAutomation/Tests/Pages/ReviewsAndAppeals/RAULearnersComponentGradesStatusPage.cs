﻿using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

using System;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals
{
    public class RAULearnersComponentGradesStatusPage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "reviews-and-appeals-learner-status");
        private static string pageTitle { get; } = "Learner’s component grade status – Manage T Level results – GOV.UK";
        private static By pageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static string  pageHeader { get; } = "Learner’s component grade status";
        private static By searchAgainBtn { get; } = By.Id("buttonSearchAgain");
        private static By learnerDetailsElement { get; } = By.ClassName("govuk-grid-column-three-quarters");
        private static By homeBreadcrumbElement = By.Id("breadcrumb0");
        private static By reviewsAndAppealsBreadcrumbElement = By.Id("breadcrumb1");
        private static By searchForALearnerBreadcrumbElement = By.Id("breadcrumb2");
        private static By updateLink = By.Id("pathwaygrade");
        private static By successBannerHeaderElement = By.Id("govuk-notification-banner-title");
        private static By successBannerTextElement = By.ClassName("govuk-notification-banner__heading");
        private static By contactUsLink = By.Id("contactusLink");
        private static String appealDatePassedText = "This result is final as the date for appeal has passed. To tell us that the grade is being appealed please";
        private static By raiseARequestLink = By.Id("raiseRequestLink");


        public static void VerifyRAULearnersComponentGradesStatusPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(pageTitle, WebDriver.Title);
            Assert.AreEqual(WebDriver.FindElement(pageHeaderElement).Text, pageHeader); 
        }

        public static void VerifyRAULearnerDetails(string ULN)
        {
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(ULN));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RaaName));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.Raadob));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RaatLevelTitle));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RaaProvider));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.Raaukprn));
      
        }

        public static void VerifyCoreDetailsOnInitialEntry()
        {
            string ExpectedDate = DateTime.Now.ToString("dd MMMM yyyy");
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RaaExamPeriod));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RaaOriginalGrade));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains("SYSTEM"));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(ExpectedDate));

            string CoreCodeHeaderText = "Core (code): " + Constants.RaaCoreTitle + " " + Constants.RaaCoreCode;
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(CoreCodeHeaderText));

        }

        public static void VerifyCoreDetailsStatusBeingAppealed(string ULN)
        {
            string CoreCodeHeaderText = "Core (code): " + Constants.RaaCoreTitle + " " + Constants.RaaCoreCode;
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RaaExamPeriod));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RaaOriginalGrade));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains("BEING APPEALED"));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(CoreCodeHeaderText));

            //Verify the Created By and Created On date from the TqPathwayResult table against the values on the Learner’s component grades status page
            string CreatedBy = SqlQueries.RetrieveResultUpdatedData(ULN);
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(CreatedBy));
            string CreatedOnDate = SqlQueries.RetrieveResultCreatedOnData(ULN);
            DateTime oDate = Convert.ToDateTime(CreatedOnDate);
            string CreatedOnDate1 = oDate.ToString("dd MMMM yyyy");
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(CreatedOnDate1));
        }

        public static void VerifyCoreDetailsStatusFinal(string ULN, string Grade)
        {
            string CoreCodeHeaderText = "Core (code): " + Constants.RaaCoreTitle + " " + Constants.RaaCoreCode;
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RaaExamPeriod));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Grade));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains("FINAL"));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(CoreCodeHeaderText));

            //Verify the Created By and Created On date from the TqPathwayResult table against the values on the Learner’s component grades status page
            string CreatedBy = SqlQueries.RetrieveResultUpdatedData(ULN);
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(CreatedBy));
            string CreatedOnDate = SqlQueries.RetrieveResultCreatedOnData(ULN);
            DateTime oDate = Convert.ToDateTime(CreatedOnDate);
            string CreatedOnDate1 = oDate.ToString("dd MMMM yyyy");
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(CreatedOnDate1));
        }

        public static void VerifySuccessBannerBeingAppealedDisplayed()
        {
            string SuccessBannerText = "Core (code): " + Constants.RaaCoreTitle + " " + Constants.RaaCoreCode + " is being appealed";
            Assert.IsTrue(WebDriver.FindElement(successBannerTextElement).Text.Contains(SuccessBannerText));
            Assert.IsTrue(WebDriver.FindElement(successBannerHeaderElement).Text.Contains("Success"));             
        }

        public static void VerifySuccessBannerFINALStatusDisplayed()
        {
            string SuccessBannerText = "Core (code): " + Constants.RaaCoreTitle + " " + Constants.RaaCoreCode + " grade is final";
            Assert.IsTrue(WebDriver.FindElement(successBannerTextElement).Text.Contains(SuccessBannerText));
            Assert.IsTrue(WebDriver.FindElement(successBannerHeaderElement).Text.Contains("Success"));
        }

        public static void VerifySuccessBannerIsNotDisplayed()
        {
            bool expectedResponse = false;
            Assert.AreEqual(expectedResponse, IsPresent(successBannerHeaderElement));
            Assert.AreEqual(expectedResponse, IsPresent(successBannerTextElement));
        }

        public static void VerifyResultIsFinalBecauseAppealDateHasPassedTextIsDisplayed()
        {
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(appealDatePassedText));            
        }

        public static void VerifyGradeStatusSetToBeingAppealed(string ULN)
        {
            //Verify the TqPathwayResult table record is updated to state the grade is being appealed
            int resultStatus = SqlQueries.RetrieveResultStatus(ULN);
            Assert.AreEqual(3, resultStatus);
        }

        public static void VerifyGradeStatusSetToFinal(string ULN)
        {
            //Verify the TqPathwayResult table record is updated to state the grade is being appealed
            int resultStatus = SqlQueries.RetrieveResultStatus(ULN);
            Assert.AreEqual(4, resultStatus);
        }

        public static void VerifyUpdateByAndDateValues(string ULN)
        {
            //Get current UpdatedBy value from TqPathwayResult table and compare against Updated By value on screen
            string CreatedBy = SqlQueries.RetrieveResultUpdatedData(ULN);
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(CreatedBy));
            string CreatedOnDate = SqlQueries.RetrieveResultCreatedOnData(ULN);
            DateTime oDate = Convert.ToDateTime(CreatedOnDate);
            string CreatedOnDate1 = oDate.ToString("dd MMMM yyyy");
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(CreatedOnDate1));

        }


        public static void ClickSearchAgainBtn()
        {
            ClickButton(searchAgainBtn);
        }

        public static void ClickUpdateLink()
        {
            ClickButton(updateLink);
        }

        public static void ClickHomeBreadcrumb()
        {
            ClickButton(homeBreadcrumbElement);
        }

        public static void ClickReviewsAndAppealsBreadcrumb()
        {
            ClickButton(reviewsAndAppealsBreadcrumbElement);
        }

        public static void ClickSearchForALearnerBreadcrumb()
        {
            ClickButton(searchForALearnerBreadcrumbElement);
        }

        public static void VerifyNoBeingAppeal()
        {
            Assert.IsFalse(WebDriver.FindElement(learnerDetailsElement).Text.Contains("BEING APPEALED"));
        }
        public static void ClickContactUsLink()
        {
            ClickButton(contactUsLink);
        }

        public static void ClickRaiseARequestLink()
        {
            ClickButton(raiseARequestLink);
        }
    }
}
