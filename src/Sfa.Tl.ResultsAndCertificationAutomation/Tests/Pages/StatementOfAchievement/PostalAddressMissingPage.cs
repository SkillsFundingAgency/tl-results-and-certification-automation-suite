using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement
{
    public class PostalAddressMissing : ElementHelper
    {
        private static string missingPostalAddressPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "postal-address-missing");
        private static string missingPostalAddressPageHeader { get; } = "Tell us your organisation’s postal address";
        private static string missingPostalAddressPageTitle { get; } = "Postal address missing page – Manage T Level results – GOV.UK";
        private static By pageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By addAddressBtn { get; } = By.Id("addAddressButton");
        private static By backLink { get; } = By.Id("backLink");
        private static By backToHomeLink { get; } = By.Id("backLink");
        
        public static void VerifyMissingAddressPage()
        {
            Assert.AreEqual(missingPostalAddressPageUrl, WebDriver.Url);
            Assert.AreEqual(missingPostalAddressPageHeader, WebDriver.FindElement(pageHeaderElement).Text);
            Assert.AreEqual(missingPostalAddressPageTitle, WebDriver.Title);
        }
        public static void ClickBackToHomeLink()
        {
            ClickElement(backToHomeLink);
        }

        public static void ClickBackLink()
        {
            ClickElement(backLink);
        }

        public static void ClickAddAddressBtn()
        {
            ClickElement(addAddressBtn);
        }
    }
}
