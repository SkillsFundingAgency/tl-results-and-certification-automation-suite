using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostalAddress
{
    public class AddAddressManually : ElementHelper
    {
        private static string AddAddressManuallyPageUrl { get; }= string.Concat(StartPage.StartPageUrl, "add-postal-address-manual");
        private static string AddAddressManuallyPageTitle { get; } = "Add your organisation's postal address - What is your organisation's postal address page – Manage T Level results – GOV.UK";
        private static string AddAddressManuallyPageHeader { get; } = "What is your organisation's postal address?";
        private static string AddAddressManuallyErrorPageTitle { get; } = "Error: Add your organisation's postal address - What is your organisation's postal address page – Manage T Level results – GOV.UK";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By Department { get; } = By.Id("department");
        private static By Address1 { get; } = By.Id("addressline1");
        private static By Address2 { get; } = By.Id("addressline2");
        private static By CityOrTown { get; } = By.Id("town");
        private static By Postcode { get; } = By.Id("postcode");
        private static By ContinueBtn { get; } = By.Id("continueButton");
        public static void VerifyAddAddressManuallyPage()
        {
            Assert.AreEqual(AddAddressManuallyPageUrl, WebDriver.Url);
            Assert.AreEqual(AddAddressManuallyPageTitle, WebDriver.Title);
            Assert.AreEqual(AddAddressManuallyPageHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyAddAddressManuallyErrorPage()
        {
            Assert.AreEqual(AddAddressManuallyErrorPageTitle, WebDriver.Title);
        }
    }
}
