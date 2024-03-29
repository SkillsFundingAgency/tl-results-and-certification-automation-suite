﻿using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.TLevelReview
{
    public class ConfirmedTLevelsNoneConfirmedPage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "no-confirmed-tlevels");
        private static string pageTitle { get; } = "No confirmed T Levels – Manage T Level results – GOV.UK";
        private static string pageHeader { get; } = "You have not confirmed any T Levels";
        private static readonly By pageHeaderElement = By.XPath("//*[@id='main-content']//h1");

        private static By homeBreadcrumb { get; } = By.Id("breadcrumb0");
        private static By tLevelsBreadcrumb { get; } = By.Id("breadcrumb1");
        private static By backToTLevelsButton { get; } = By.Id("buttonTlevels");        
        private static By contactUsLink = By.Id("contactusLink");
        private static By reviewink = By.Id("reviewLink");
        private static By queriedLink = By.Id("queriedLink");
        private static By iCannotFindATLevelLink = By.XPath("//*[contains(text(),'I cannot find a T Level')]");
       
        public static void VerifyNoTLevelsConfiirmedPage()
        {          
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(WebDriver.Title, pageTitle);
            Assert.AreEqual(WebDriver.FindElement(pageHeaderElement).Text, pageHeader);
        }

        public static void ClickHomeBreadcrumb()
        {
            ClickElement(homeBreadcrumb);
        }

        public static void ClickTLevelsBreadcrumb()
        {
            ClickElement(tLevelsBreadcrumb);
        }
        public static void ClickBackToTLevelsBtn()
        {
            ClickElement(backToTLevelsButton);
        }

        public static void ClickReviewLink()
        {
            ClickElement(reviewink);
        }

        public static void ClickContactUsLink()
        {
            ClickElement(contactUsLink);
        }

        public static void ClickQueriedLink()
        {
            ClickElement(queriedLink);
        }
        public static void ClickICannotFinaATLevelLink()
        {
            ClickElement(iCannotFindATLevelLink);
        }
    }
}
