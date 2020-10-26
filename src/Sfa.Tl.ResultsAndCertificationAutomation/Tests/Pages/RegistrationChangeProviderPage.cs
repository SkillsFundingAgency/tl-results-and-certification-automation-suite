using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System;
using System.Threading;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    class RegistrationChangeProviderPage : ElementHelper
    {

        //Registration Change Provider page elements 
        private const string ExpectedButtonText = "Withdraw this registration";
        private static string ExpectedChangeProviderPageUrl => string.Concat(StartPage.StartPageUrl, "change-provider");
        private static By PageHeading = By.XPath("//*[@id='main-content']//h1");
        private static By ChangeButton = By.Id("ChangeButton");
        private static string ExpectedChangeButtonText = "Change";
        private static By BackLink = By.Id("backLink");
        private static By ProviderDropdown = By.Id("selectedproviderukprn");
        private static string ChangeProvider = "Barnsley College (10000536)";

        //Registration Change: Provider has not been set up to offer the same core page elements 
        private const string ProviderNotOfferSameCorePageTitle = "Change registration - Provider has not been set up to offer core page – Manage T Level results – GOV.UK";
        private static readonly string ProviderNotOfferSameCoreHeader = "Provider has not been set up to offer the same core";
        private static readonly string ProviderNotOfferSameCoreUrl = string.Concat(StartPage.StartPageUrl, "change-registration-provider-not-offering-core");
        public static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");

        //Change Provider Page Methods:

        public static void VerifyChangeProviderPage()
        {
            Assert.IsTrue((WebDriver.Url).Contains(ExpectedChangeProviderPageUrl));
            Assert.AreEqual(ExpectedChangeButtonText, WebDriver.FindElement(ChangeButton).Text);
        }
             
        public static void ClickChangeButton()
        {
            ClickElement(ChangeButton);
        }

        public static void SelectProviderFromList()
        {
            SelectFromDropDownByText(ProviderDropdown, ChangeProvider);
        }

        public static void SelectProviderFromList(string UpdatedProvider)
        {
            SelectFromDropDownByText(ProviderDropdown, UpdatedProvider);
        }


        //Registration Change: Provider has not been set up to offer the same core page methods 

        public static void VerifyProviderNotOfferSameCorePage()
        {
            Assert.AreEqual(ProviderNotOfferSameCorePageTitle, WebDriver.Title);
            Assert.AreEqual(ProviderNotOfferSameCoreUrl, WebDriver.Url);
            Assert.AreEqual(ProviderNotOfferSameCoreHeader, WebDriver.FindElement(PageHeader).Text);
        }
    }
}
