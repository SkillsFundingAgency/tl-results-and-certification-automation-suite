using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System;
using System.Threading;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    class RegistrationChangeCorePage : ElementHelper
    {


        private const string ExpectedButtonText = "Withdraw this registration";
        private static string ExpectedChangeNamePageUrl => string.Concat(StartPage.StartPageUrl, "change-core");
        private static By PageHeading = By.XPath("//*[@id='main-content']//h1");
        private static By WithdrawButton = By.Id("WithdrawButton");
        private static By BackLink = By.Id("backLink");
        private static string ExpectedChangeProviderAndCorePageUrl => string.Concat(StartPage.StartPageUrl, "change-core-and-provider");
        private static By ChangeCorePageHeading = By.XPath("//*[@id='main-content']//h1");
        private static string ExpectedPageHeading = "Do you also want to change the core?";
        private static By ContinueButton = By.Id("continueButton");
        private static string ExpectedContinueButtonText = "Continue";
        private static By ChangeCoreBackLink = By.Id("backLink");
        private static By YesRadioButton = By.Id("canchangecore");
        private static By NoRadioButton = By.Id("tl-change-core-no");

        public static void VerifyChangeCorePageDetails()
        {
            Assert.IsTrue((WebDriver.Url).Contains(ExpectedChangeNamePageUrl));
            Assert.AreEqual(ExpectedButtonText, WebDriver.FindElement(WithdrawButton).Text);
        }

        public static void ClickBackLink()
        {
            ClickElement(BackLink);
        }

        public static void ClickWithdrawButton()
        {
            ClickElement(WithdrawButton);
        }

        public static string CapturePageURL()
        {
            return WebDriver.Url;
        }

        public static void AssertPageNotFoundPageDisplayed()
        {
            Assert.IsTrue(WebDriver.Title.Contains(Constants.PageNotFoundPageTitle));
        }


        public static void VerifyAreYouSureChangeCorePage()
        {
            Assert.IsTrue((WebDriver.Url).Contains(ExpectedChangeProviderAndCorePageUrl));
            Assert.AreEqual(ExpectedContinueButtonText, WebDriver.FindElement(ContinueButton).Text);
            Assert.AreEqual(ExpectedPageHeading, WebDriver.FindElement(ChangeCorePageHeading).Text);
        }

        public static void ClickContinueButton_AreYouSureChangeCorePage()
        {
            ClickElement(ContinueButton);
        }

        public static void ClickYesRadioButton_AreYouSureChangeCorePage()
        {
            ClickElement(YesRadioButton);
        }


    }
}
