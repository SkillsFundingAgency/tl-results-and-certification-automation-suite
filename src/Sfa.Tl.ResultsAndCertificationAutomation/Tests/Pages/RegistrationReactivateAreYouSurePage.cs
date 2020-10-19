using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using System;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class RegistrationReactivateAreYouSurePage : ElementHelper
    {
        private static readonly string ExpectedPageUrl = string.Concat(StartPage.StartPageUrl, "reactivate-registration-same-course");
        //private const string ExpectedPageTitle = "Cannot select same core page – Manage T Level results – GOV.UK";
        private static readonly string ExpectedPageHeader = "Are you sure you want to reactivate the registration with the same course?";
        
        private static By BackLink { get; } = By.Id("backLink");
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        
        public static By SubmitButton { get; } = By.Id("submitButton");
        private static readonly string ExpectedButtonText = "Submit";

        private static By YesRadioButton { get; } = By.Id("canrejoin");

        public static void VerifyRegReactivateChangeCorePageDetails()
        {
            Assert.IsTrue((WebDriver.Url).Contains(ExpectedPageUrl));
            Assert.AreEqual(ExpectedPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(ExpectedButtonText, WebDriver.FindElement(SubmitButton).Text);
        }

        public static void ClickBackLink()
        {
            ClickElement(BackLink);
        }

        public static void ClickYesRadioButton()
        {
            ClickElement(YesRadioButton);
        }

        public static void ClickSubmitButton()
        {
            ClickElement(SubmitButton);
        }











    }
}
