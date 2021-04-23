using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using System;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers
{
    public class EMDataSubmittedSuccessPage : ElementHelper
    {
        private static string pageUrl { get; } = "add-learner-record-english-and-maths-data-confirmation";
        private static string pagetitle { get; } = "Add a new learner T Level record - English and maths data submitted confirmation page – Manage T Level results – GOV.UK";
        private static string pageHeader { get; } = "English and maths data submitted successfully";
        private static By pageHeadElement { get; } = By.XPath("//*[@id='main-content']//h1");

        //data
        private const string name = "Db FirstName Db LastName";
        
        private static By learnerNameULNElement { get; } = By.ClassName("govuk-panel__body");

        //links
        public static By backToLearnerRecordsLink = By.Id("backToManageLearnerRecordsLink");
        public static By addAnotherLearnerButton = By.Id("addAnotherLearnerRecordButton");



        public static void VerifyEMDataSubmittedSuccessPage(string ULN)
        {
            Assert.AreEqual(pagetitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(pageHeader, WebDriver.FindElement(pageHeadElement).Text);
            Assert.IsTrue(WebDriver.FindElement(learnerNameULNElement).Text.Contains(name));
            Assert.IsTrue(WebDriver.FindElement(learnerNameULNElement).Text.Contains(ULN));
        }

        public static void ClickAddAnotherLearnerButton()
        {
            ClickElement(addAnotherLearnerButton);
        }

        public static void ClickBackToLEarnerRecordsLink()
        {
            ClickElement(backToLearnerRecordsLink);
        }
      
    }
}
