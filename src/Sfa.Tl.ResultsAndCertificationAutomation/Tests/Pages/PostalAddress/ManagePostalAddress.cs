using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostalAddress
{
    public class ManagePostalAddress : ElementHelper
    {
        private static string ManageOrgPostalAddressPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "manage-postal-address");
        private static string ManageOrgPostalAddressPageHeader { get; } = "Manage your organisation’s postal address";
        private static string ManageOrgPostalAddressPageTitle { get; } = "Manage your organisation's postal address page – Manage T Level results – GOV.UK";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By AddAddressBtn { get; } = By.Id("addAddressButton");
        private static By HomeBreadCrumb { get; } = By.Id("breadcrumb0");
        //Search post code page
        private static string SearchPostalAddressPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-postal-address-postcode");
        private static string SearchPostalAddressPageHeader { get; } = "What is your organisation's postal address?";
        private static string SearchPostalAddressPageTitle { get; } = "Add your organisation's postal address page – Manage T Level results – GOV.UK";
        private static By FindAddressBtn { get; } = By.Id("findAddressButton");
        private static By EnterPostCode { get; } = By.Id("postcode");
        public static void ClickBackLink() => WebDriver.FindElement(By.Id("backLink")).Click();

        public static void VerifyManageOrgPostalAddressPage()
        {
            Assert.AreEqual(ManageOrgPostalAddressPageUrl, WebDriver.Url);
            Assert.AreEqual(ManageOrgPostalAddressPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(ManageOrgPostalAddressPageTitle, WebDriver.Title);
        }
        public static void ClickHomeBreadCrumb()
        {
            ClickElement(HomeBreadCrumb);
        }
        public static void VerifySearchPostalAddressPage()
        {
            Assert.AreEqual(SearchPostalAddressPageUrl, WebDriver.Url);
            Assert.AreEqual(SearchPostalAddressPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(SearchPostalAddressPageTitle, WebDriver.Title);
        }
        public static void VerifySearchPostalAddressBackPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(SearchPostalAddressPageUrl));
            Assert.AreEqual(SearchPostalAddressPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(SearchPostalAddressPageTitle, WebDriver.Title);
        }
        public static void ClickBtnByName(string btnName)
        {
            switch(btnName)
            {
                case "Add address":
                    ClickButton(AddAddressBtn);
                    break;
                case "Find address":
                    ClickButton(FindAddressBtn);
                    break;
            }
        }
    }
}
