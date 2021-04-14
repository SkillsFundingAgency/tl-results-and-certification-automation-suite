using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers
{
    public class UpdateIPSuccessPage : ElementHelper
    {
        private static string pageUrl { get; } = "industry-placement-updated-confirmation";
        private static string pagetitle { get; } = "Industry placement updated confirmation page – Manage T Level results – GOV.UK";
        private static string pageHeader { get; } = "Industry placement status updated successfully";
        private static By pageHeadElement { get; } = By.XPath("//*[@id='main-content']//h1");
        //data
        private const string name = "Db FirstName Db LastName";
        //links
        public static By backToLearnerRecordBtn = By.Id("backToLearnerTLevelRecordButton");
        public static By backToManageLearnerLink = By.Id("backToManageLearnerRecordsLink");
        
        public static void VerifyUpdateIPSuccessPage()
        {
            Assert.AreEqual(pagetitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(pageHeader, WebDriver.FindElement(pageHeadElement).Text);
        }
        public static void VerifyUpdateIPSuccessData(string uln)
        {
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains("ULN: " + uln + ""));
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(name));
        }
    }
}
