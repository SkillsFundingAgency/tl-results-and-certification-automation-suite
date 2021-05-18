using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using System;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostalAddress
{
    public class CheckAndSubmit : ElementHelper
    {
       
        private static string CheckAndSubmitPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-postal-address-check-and-submit");
        private static string CheckAndSubmitPageHeader { get; } = "Check and submit";
        private static string CheckAndSubmitPageTitle { get; } = "Add your organisation's postal address - What is your organisation's postal address page – Manage T Level results – GOV.UK";
        private static string CheckAndSubmitErrorPageTitle { get; } = "Error: Add your organisation's postal address - What is your organisation's postal address page – Manage T Level results – GOV.UK";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By FindAddressBtn { get; } = By.Id("findAddressButton");
        private static By BackLink { get; } = By.Id("backLink");
        private static By CancelBtn { get; } = By.Id("cancelLink");
        private static By SubmitBtn { get; } = By.Id("submitButton");
        private static By ChangeAddressLink { get; } = By.Id("department");
        private static By  AddressElement { get; } = By.XPath("//*[@id='main-content']//form//dl");

        public static void VerifyCheckAndSubmitPage()
        {
            Assert.AreEqual(CheckAndSubmitPageUrl, WebDriver.Url);
            Assert.AreEqual(CheckAndSubmitPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(CheckAndSubmitPageTitle, WebDriver.Title);
        }

        public static void VerifyAddressDisplayed(string Department, string Organisation, string Address1, string Address2, string Town, string Postcode)
        {
            Console.WriteLine(WebDriver.FindElement(AddressElement).Text);
            Assert.IsTrue(WebDriver.FindElement(AddressElement).Text.Contains(Department));
            Assert.IsTrue(WebDriver.FindElement(AddressElement).Text.Contains(Organisation));
            Assert.IsTrue(WebDriver.FindElement(AddressElement).Text.Contains(Address1));
            Assert.IsTrue(WebDriver.FindElement(AddressElement).Text.Contains(Address2));
            Assert.IsTrue(WebDriver.FindElement(AddressElement).Text.Contains(Town));
            Assert.IsTrue(WebDriver.FindElement(AddressElement).Text.Contains(Postcode));
        }

        public static void ClickSubmitBtn()
        {
            ClickElement(SubmitBtn);
        }

        public static void ClickChangeAddressLink()
        {
            ClickElement(ChangeAddressLink);
        }

        public static void ClickCancelLink()
        {
            ClickElement(CancelBtn);
        }

        public static void ClickBackLink()
        {
            ClickElement(BackLink);
        }

    }
}
