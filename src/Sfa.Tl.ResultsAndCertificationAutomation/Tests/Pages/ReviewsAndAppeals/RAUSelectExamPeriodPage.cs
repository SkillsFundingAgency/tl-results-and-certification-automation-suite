using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

using System;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals
{
    public class RAUSelectExamPeriodPage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "select-exam-period");
        private static string pageTitle { get; } = "Select exam period – Manage T Level results – GOV.UK";
        private static By pageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");  

        private static string  pageHeader { get; } = "Select exam period";
        private static By pageSubHeaderElement { get; } = By.XPath("//*[@id='main-content']//h2");
        private static string subPageHeader { get; } = "Which exam period is the component in?";
        private static By submitBtn { get; } = By.Id("submitButton");
        private static By learnerDetailsElement { get; } = By.XPath("//*[@id='main-content']//form");
        private static By RadioButtonElement = By.ClassName("govuk-radios");
        private static By backLink = By.Id("backLink");
        private static By autumn2021RadioBtn = By.Id("selectedassessmentid");
        private static By summer2021RadioBtn = By.Id("selectedassessmentid-1");
        private static By mainErrorMesg = By.ClassName("govuk-error-summary__body");
        private static By subErrorMesg = By.ClassName("govuk-error-message");


        public static void VerifyRAUSelectExamPeriodPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(pageTitle, WebDriver.Title);
            Assert.AreEqual(WebDriver.FindElement(pageHeaderElement).Text, pageHeader); 
        }

        public static void VerifyRAULearnerDetails(string ULN)
        {
           
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RAAName));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(ULN));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RAADOB));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RAAProvider));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RAATLevelTitle));
     
        }

        public static void VerifyExamPeriodDetails()
        {
            Assert.IsTrue(WebDriver.FindElement(RadioButtonElement).Text.Contains("Autumn 2021"));
            Assert.IsTrue(WebDriver.FindElement(RadioButtonElement).Text.Contains("Summer 2021"));
            Assert.AreEqual(subPageHeader, WebDriver.FindElement(pageSubHeaderElement).Text);
        }

       
        public static void ClickBackLink()
        {
            ClickButton(backLink);
        }

        public static void ClickAutumn2021RadioBtn()
        {
            ClickButton(autumn2021RadioBtn);
        }

        public static void ClickSummer2021RadioBtn()
        {
            ClickButton(summer2021RadioBtn);
        }

        public static void ClickSubmitBtn()
        {
            ClickButton(submitBtn);
        }

        public static void VerifyErrorMessage(string ErrorMsg)
        {
            Assert.IsTrue(WebDriver.FindElement(mainErrorMesg).Text.Contains(ErrorMsg));
            Assert.IsTrue(WebDriver.FindElement(subErrorMesg).Text.Contains(ErrorMsg));
        }

        public static void VerifyRadioButtonsNotPrepopulated()
        {
            Assert.AreEqual(false, WebDriver.FindElement(autumn2021RadioBtn).Selected);
            Assert.AreEqual(false, WebDriver.FindElement(summer2021RadioBtn).Selected);
        }

    }
}
