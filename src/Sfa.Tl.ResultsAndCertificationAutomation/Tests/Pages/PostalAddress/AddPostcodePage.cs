using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostalAddress
{
    public class AddPostcodePage : ElementHelper
    {
        private static string AddOrgPostalAddressPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-postal-address-postcode");
        private static string AddOrgPostalAddressPageHeader { get; } = "What is your organisation's postal address?";
        private static string ManageOrgPostalAddressPageTitle { get; } = "Add your organisation's postal address page – Manage T Level results – GOV.UK";
        private static string ManageOrgPostalAddressErrorPageTitle { get; } = "Error: Add your organisation's postal address page – Manage T Level results – GOV.UK";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By MainErrorMessage { get; } = By.XPath("//a[@href ='#postcode']");
        private static By SubErrorMessage { get; } = By.XPath("//*[@class='govuk-error-message']");
        private static By FindAddressBtn { get; } = By.Id("findAddressButton");
        private static By BackLink { get; } = By.Id("backLink");
        private static By PostCodeTextField { get; } = By.Id("postcode");

        public static void VerifyAddPostalAddressPage()
        {
            Assert.AreEqual(AddOrgPostalAddressPageUrl, WebDriver.Url);
            Assert.AreEqual(AddOrgPostalAddressPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(ManageOrgPostalAddressPageTitle, WebDriver.Title);
        }

        public static void ClickFindAddressBtn()
        {
            ClickElement(FindAddressBtn);
        }

        public static void ValidateErrorMessage(string ErrorMessage)
        {
            Assert.AreEqual(ManageOrgPostalAddressErrorPageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.FindElement(MainErrorMessage).Text.Contains(ErrorMessage));
            Assert.IsTrue(WebDriver.FindElement(SubErrorMessage).Text.Contains(ErrorMessage));

        }

        public static void EnterPostcode(string PostCode)
        {
            WebDriver.FindElement(PostCodeTextField).Clear();
            WebDriver.FindElement(PostCodeTextField).SendKeys(PostCode);
            ClickElement(FindAddressBtn);
        }


    }
}
