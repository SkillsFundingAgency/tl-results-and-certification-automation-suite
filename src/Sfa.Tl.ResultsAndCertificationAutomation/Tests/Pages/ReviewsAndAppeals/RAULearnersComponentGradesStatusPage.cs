using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals
{
    public class RAULearnersComponentGradesStatusPage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "reviews-and-appeals-learner-status");
        private static string pageTitle { get; } = "Learner’s component grades status – Manage T Level results – GOV.UK";
        private static By pageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static string  pageHeader { get; } = "Learner’s component grades status";
        private static By searchAgainBtn { get; } = By.Id("buttonSearchAgain");
        private static By learnerDetailsElement { get; } = By.ClassName("govuk-grid-column-three-quarters");
        private static By homeBreadcrumbElement = By.Id("breadcrumb0");
        private static By reviewsAndAppealsBreadcrumbElement = By.Id("breadcrumb1");
        private static By searchForALearnerBreadcrumbElement = By.Id("breadcrumb2");


        public static void VerifyRAULearnersComponentGradesStatusPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(pageTitle, WebDriver.Title);
            Assert.AreEqual(WebDriver.FindElement(pageHeaderElement).Text, pageHeader); 
        }

        public static void VerifyRAULearnerDetails(string ULN)
        {
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(ULN));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RAAName));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RAADOB));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RAATLevelTitle));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RAAProvider));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RAAUKPRN));
      
        }

        public static void VerifyCoreDetailsOnInitialEntry()
        {
            string ExpectedDate = DateTime.Now.ToString("dd MMMM yyyy");
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains("Summer 2021"));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains("A"));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains("SYSTEM"));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(ExpectedDate));
        }


        public static void ClickSearchAgainBtn()
        {
            ClickButton(searchAgainBtn);
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
    }
}
