using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using System;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostalAddress
{
    public class AddPostcodePage : ElementHelper
    {
        //Add postcode
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
        //Select postcode
        private static string SelectPostalAddressPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-postal-address-select");
        private static string SelectPostalAddresPageTitle { get; } = "Add your organisation's postal address - Select your organisation's address page – Manage T Level results – GOV.UK";
        private static By SelectAddress { get; } = By.Id("selectedaddressuprn");
        private static By Department { get; } = By.Id("departmentname");
        private static By ChangeLink { get; } = By.LinkText("Change");
        private static By CantFindAddressLink { get; } = By.XPath("//*[contains(text(),'find my organisation')]");
        private static By ContinueBtn { get; } = By.Id("continueButton");

        public static void VerifyAddPostalAddressPage()
        {
            Assert.AreEqual(AddOrgPostalAddressPageUrl, WebDriver.Url);
            Assert.AreEqual(AddOrgPostalAddressPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(ManageOrgPostalAddressPageTitle, WebDriver.Title);
        }
        public static void VerifyChangeAddPostalAddressPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(AddOrgPostalAddressPageUrl));
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
        public static void VerifySelectAddressPage()
        {
            Assert.AreEqual(SelectPostalAddressPageUrl, WebDriver.Url);
            Assert.AreEqual(AddOrgPostalAddressPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(SelectPostalAddresPageTitle, WebDriver.Title);
        }
        public string GetPostcodeFieldValue()
        {
            var value = WebDriver.FindElement(PostCodeTextField).GetAttribute("value");
            return value;
        }
        public static void ClickCantFindAddressLink()
        {
            ClickElement(CantFindAddressLink);
        }
        public static void VerifyAddressCount()
        {
            var address = WebDriver.FindElement(SelectAddress);
            var addressCount = new SelectElement(address);
            var addressCountText = addressCount.SelectedOption.Text;
            Assert.AreEqual("2 addresses found", addressCountText);
        }

        public static void SelectAddressFromDropdown()
        {
            var address = WebDriver.FindElement(SelectAddress);
            SelectElement address1 = new SelectElement(address);
            address1.SelectByIndex(1);
            ClickElement(ContinueBtn);
        }

        public static void VerifyPostcodeFieldIsEmpty()
        {
         Assert.AreEqual("", WebDriver.FindElement(PostCodeTextField).GetAttribute("value"));
        }
    }
}
