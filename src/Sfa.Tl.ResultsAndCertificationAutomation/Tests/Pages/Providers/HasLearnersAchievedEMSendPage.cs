using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using System;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers
{
    public class HasLearnersAchievedEMSendPage : ElementHelper
    {
        private static string pageUrl { get; } = "add-learner-record-english-and-maths-achievement-lrs";
        private static string pagetitle { get; } = "Add a new learner T Level record - English and maths achievement page – Manage T Level results – GOV.UK";
        private static string errorPagetitle { get; } = "Error: Add a new learner T Level record - English and maths achievement page – Manage T Level results – GOV.UK";
        private static By MainErrorMessage = By.XPath("//a[@href='#englishandmathslrsstatus']");
        private static By SubErrorMessage = By.ClassName("govuk-error-message");
        private static string pageHeader { get; } = "Has the learner achieved the required minimum standard for English and maths?";
        private static By pageHeadElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private const string pageCaption = "Add a new learner T Level record";
        private static By pageCaptionElement = By.ClassName("govuk-caption-xl");
        private static By radioButtonDeclarationText = By.Id("declarationText");
        //data
        private const string name = "Learner: Db FirstName Db LastName";
        private static By learnerNameElement { get; } = By.Id("uln-hint");

        //links
        public static By backLink = By.Id("backLink");
        public static By submitButton = By.Id("submitButton");

        //Radio Buttons
        private static By radioButtonAchievedMinStdWithSEND { get; } = By.Id("englishandmathslrsstatus");
        private static By radioButtonNotAchievedMinStd { get; } = By.Id("status-not-achieved");
        private static By radioButtonWrongLRSData { get; } = By.Id("status-lrs-data-wrong");

        public static void VerifyHasLearnersAchievedEMSendPage()
        {
            Assert.AreEqual(pagetitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(pageHeader, WebDriver.FindElement(pageHeadElement).Text);
            Assert.AreEqual(pageCaption, WebDriver.FindElement(pageCaptionElement).Text);
            Assert.AreEqual(name, WebDriver.FindElement(learnerNameElement).Text);
            Assert.AreEqual("Submit", WebDriver.FindElement(submitButton).Text);
        }

        public static void ClickSubmitButton()
        {
            ClickElement(submitButton);
        }

        public static void ClickBackLink()
        {
            ClickElement(backLink);
        }

        public static void SelectRadioButton(string RadioButton)
        {
            switch (RadioButton)
            {
                case "Achieved the minimum standard for learners with SEND":
                    ClickElement(radioButtonAchievedMinStdWithSEND);
                    //ClickSubmitButton();
                    break;
                case "Not achieved the minimum standard":
                    ClickElement(radioButtonNotAchievedMinStd);
                    //ClickSubmitButton();
                    break;
                case "The LRS data is wrong":
                    ClickElement(radioButtonWrongLRSData);
                   // ClickSubmitButton();
                    break;
            }
        }

        public static void ClickRadioButton(string RadioButton)
        {
            switch (RadioButton)
            {
                case "Achieved the minimum standard for learners with SEND":
                    ClickElement(radioButtonAchievedMinStdWithSEND);
                    ClickSubmitButton();
                    break;
                case "Not achieved the minimum standard":
                    ClickElement(radioButtonNotAchievedMinStd);
                    ClickSubmitButton();
                    break;
                case "The LRS data is wrong":
                    ClickElement(radioButtonWrongLRSData);
                     ClickSubmitButton();
                    break;
            }
        }

        public static void VerifyRadioButtonsNotSelected()
        {            
                Assert.AreEqual(false, WebDriver.FindElement(radioButtonAchievedMinStdWithSEND).Selected);
                Assert.AreEqual(false, WebDriver.FindElement(radioButtonNotAchievedMinStd).Selected);
                Assert.AreEqual(false, WebDriver.FindElement(radioButtonWrongLRSData).Selected);
        }

        public static void VerifyRadioButtonDeclarationTextDisplayed()
        {
            bool Visible = WebDriver.FindElement(radioButtonDeclarationText).Displayed;
            Console.WriteLine("Displayed = " + Visible);
            Assert.IsTrue(Visible);
        }

        public static void VerifyDeclarationTextDisplayed()
        {
            bool Visible = WebDriver.FindElement(radioButtonDeclarationText).Displayed;
            Console.WriteLine("Displayed = " + Visible);
            Assert.IsTrue(Visible);
        }

        public static void VerifyDeclarationTextNotDisplayed()
        {
            bool Visible = WebDriver.FindElement(radioButtonDeclarationText).Displayed;
            Console.WriteLine("Displayed = " + Visible);
            Assert.IsFalse(Visible);

        }


        public static void ValidateErrorMessage(string ErrorMessage)
        {
            Assert.AreEqual(errorPagetitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.IsTrue(WebDriver.FindElement(MainErrorMessage).Text.Contains(ErrorMessage));
            Assert.IsTrue(WebDriver.FindElement(SubErrorMessage).Text.Contains(ErrorMessage));
        }

    }
}
