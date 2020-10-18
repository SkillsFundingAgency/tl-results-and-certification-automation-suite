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


        private const string ExpectedButtonText = "Withdraw this registration";
        private static string ExpectedChangeProviderPageUrl => string.Concat(StartPage.StartPageUrl, "change-provider");
        private static By PageHeading = By.XPath("//*[@id='main-content']//h1");
        private static By ChangeButton = By.Id("ChangeButton");
        private static string ExpectedChangeButtonText = "Change";
        private static By BackLink = By.Id("backLink");
        private static By ProviderDropdown = By.Id("selectedproviderukprn");
        private static string ChangeProvider = "Barnsley College (10000536)";

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


    }
}
