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

        //Change Registration: Change Core Page Elements:
        private const string ExpectedButtonText = "Withdraw this registration";
        public static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By WithdrawButton = By.Id("WithdrawButton");
        private static By BackLink = By.Id("backLink");
        public const string ChangeCorePageTitle = "Change core page – Manage T Level results – GOV.UK";
        public static readonly string ChangeCorePageUrl = string.Concat(StartPage.StartPageUrl, "change-core");
        public static readonly string ChangeCorePageHeader = "Change core";

        //Change Registration: "Do you also want to change the core?" Page Elements:
        private static string ExpectedChangeProviderAndCorePageUrl => string.Concat(StartPage.StartPageUrl, "change-core-and-provider");
        private static By ChangeCorePageHeading = By.XPath("//*[@id='main-content']//h1");
        private static string ExpectedPageHeading = "Do you also want to change the core?";
        private static string DoYouWantToChangeCorePageTitle = "Change registration - Do you also want to change the core page – Manage T Level results – GOV.UK";
        private static By ContinueButton = By.Id("continueButton");
        private static string ExpectedContinueButtonText = "Continue";
        private static By ChangeCoreBackLink = By.Id("backLink");
        private static By YesRadioButton = By.Id("canchangecore");
        private static By NoRadioButton = By.Id("tl-change-core-no");


        //Change Registration: Change Core Page METHODS
        public static void VerifyChangeCorePageDetails()
        {
            Assert.AreEqual(ExpectedButtonText, WebDriver.FindElement(WithdrawButton).Text);
            Assert.AreEqual(ChangeCorePageTitle, WebDriver.Title);
            Assert.AreEqual(ChangeCorePageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(ChangeCorePageUrl));
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



        //Change Registration: "Do you also want to change the core?" Page METHODS

        //public static void VerifyAreYouSureChangeCorePage()
        //{
        //    Assert.IsTrue((WebDriver.Url).Contains(ExpectedChangeProviderAndCorePageUrl));
        //    Assert.AreEqual(ExpectedContinueButtonText, WebDriver.FindElement(ContinueButton).Text);
        //    Assert.AreEqual(ExpectedPageHeading, WebDriver.FindElement(ChangeCorePageHeading).Text);
        //}

        public static void VerifyDoYouWantChangeCorePage()
        {
            Assert.AreEqual(DoYouWantToChangeCorePageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedPageHeading, WebDriver.FindElement(ChangeCorePageHeading).Text);
            Assert.IsTrue(WebDriver.Url.Contains(ExpectedChangeProviderAndCorePageUrl));
            Assert.AreEqual(ExpectedContinueButtonText, WebDriver.FindElement(ContinueButton).Text);
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
