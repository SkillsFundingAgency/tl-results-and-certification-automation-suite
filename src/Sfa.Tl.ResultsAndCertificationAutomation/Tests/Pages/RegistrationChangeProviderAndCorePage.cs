using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System;
using System.Threading;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    class RegistrationChangeProviderAndCorePage : ElementHelper
    {


        
        private static string ExpectedChangeProviderAndCorePageUrl => string.Concat(StartPage.StartPageUrl, "change-registration-provider-and-core-need-to-withdraw");
        private static By PageHeading = By.XPath("//*[@id='main-content']//h1");
        private static string ExpectedPageHeading = "Change provider and core";
        private static By WithdrawThisRegistrationButton = By.Id("withdrawRegistrationButton");
        private const string ExpectedButtonText = "Withdraw this registration";
        private const string ChangeProviderCorePageTitle = "Change registration - Change provider and core need to withdraw message page – Manage T Level results – GOV.UK";


        public static void VerifyChangeProviderAndCorePage()
        {
            Assert.IsTrue((WebDriver.Url).Contains(ExpectedChangeProviderAndCorePageUrl));
            Assert.AreEqual(ExpectedButtonText, WebDriver.FindElement(WithdrawThisRegistrationButton).Text);
            Assert.AreEqual(ExpectedPageHeading, WebDriver.FindElement(PageHeading).Text);
        }

        public static void VerifyChangeProviderCore()
        {
            Assert.AreEqual(ChangeProviderCorePageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedChangeProviderAndCorePageUrl, WebDriver.Url);
            Assert.AreEqual(ExpectedPageHeading, WebDriver.FindElement(PageHeading).Text);
            Assert.AreEqual(ExpectedButtonText, WebDriver.FindElement(WithdrawThisRegistrationButton).Text);
        }

        public static void ClickWithdrawButton()
        {
            ClickElement(WithdrawThisRegistrationButton);
        }

        
    }
}
