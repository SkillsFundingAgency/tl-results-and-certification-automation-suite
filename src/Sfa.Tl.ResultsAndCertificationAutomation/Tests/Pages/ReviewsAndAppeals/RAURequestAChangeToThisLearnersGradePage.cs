using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

using System;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals
{
    public class RAURequestAChangeToThisLearnersGradePage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "request-grade-change");
        private static string pageTitle { get; } = "Request grade change – Manage T Level results – GOV.UK";
        private static By pageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");  

        private static string  pageHeader { get; } = "Request a change to this learner’s grade";
        private static By pageSubHeaderElement { get; } = By.XPath("//*[@id='main-content']//h2");
        private static string subPageHeader { get; } = "Please tell us what you need to change and why";
        private static By sendBtn { get; } = By.Id("sendButton");
        private static By cancelLink { get; } = By.Id("cancelLink");
        private static By textEntryField = By.Id("changerequestdata");

        private static By learnerDetailsElement { get; } = By.XPath("//*[@id='main-content']//form");
        private static By backLink = By.Id("backLink");
       
        private static By mainErrorMesg = By.ClassName("govuk-error-summary__body");
        private static By subErrorMesg = By.ClassName("govuk-error-message");

        public static void VerifyRAURequestAChangeToThisLearnersGradePage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(pageTitle, WebDriver.Title);
            Assert.AreEqual(WebDriver.FindElement(pageHeaderElement).Text, pageHeader);
            Assert.AreEqual(WebDriver.FindElement(pageSubHeaderElement).Text, subPageHeader);
        }

        public static void VerifyLearnerDetails(string ULN)
        {
            string CoreCode = Constants.RaaCoreTitle + " " + Constants.RaaCoreCode;
           
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RaaName));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(ULN));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.Raadob));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(CoreCode));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RaaExamPeriod));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RaaOriginalGrade));           
        }

        
        public static void ClickBackLink()
        {
            ClickButton(backLink);
        }

       
        public static void ClickSendBtn()
        {
            ClickButton(sendBtn);
        }

        public static void ClickCancelLink()
        {
            ClickButton(cancelLink);
        }

        public static void VerifyErrorMessage(string ErrorMsg)
        {
            Assert.IsTrue(WebDriver.FindElement(mainErrorMesg).Text.Contains(ErrorMsg));
            Assert.IsTrue(WebDriver.FindElement(subErrorMesg).Text.Contains(ErrorMsg));
        }



    }
}
