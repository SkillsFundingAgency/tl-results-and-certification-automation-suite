using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostalAddress
{
    public class NoAddressFoundPage : ElementHelper
    {
       
        private static string PageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-postal-address-no-addresses-found");
        private static string PageTitle { get; } = "Add your organisation's postal address - No addresses found page – Manage T Level results – GOV.UK";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By TryANotherPostcodeBtn { get; } = By.Id("tryAnotherButton");
        private static By BackLink { get; } = By.Id("backLink");
        private static By AddAddressManuallyLink { get; } = By.XPath("//a[@href='/add-address-manually/true']");
       


        public static void VerifyNoAddressessFoundPage(string postcode)
        {
            string ExpectedPageHeader = "No addresses found for " + postcode;
            Assert.AreEqual(PageUrl, WebDriver.Url);
            Assert.AreEqual(ExpectedPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(PageTitle, WebDriver.Title);
        }

        public static void ClickBackLink()
        {
            ClickElement(BackLink);
        }

        public static void ClickAddAdressManuallyLink()
        {
            ClickElement(AddAddressManuallyLink);
        }
        public static void ClickTryAnotherPostcodeBtn()
        {
            ClickElement(TryANotherPostcodeBtn);
        }

    }
}
