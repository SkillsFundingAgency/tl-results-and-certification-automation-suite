using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostalAddress
{
    public class CancelPage : ElementHelper
    {
       
        private static string CancelPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-postal-address-cancel");
        private static string CancelPageHeader { get; } = "Are you sure you want to cancel adding this address?";
        private static string CancelPageTitle { get; } = "Cancel adding organisation's postal address page – Manage T Level results – GOV.UK";
        private static string CancelErrorPageTitle { get; } = "Error: Cancel adding organisation's postal address page – Manage T Level results – GOV.UK";
        private static string Caption { get; } = "Add address";
        private static By CaptionElement { get; } = By.ClassName("govuk-caption-l");
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By FindAddressBtn { get; } = By.Id("findAddressButton");
        private static By BackLink { get; } = By.Id("backLink");
        private static By ContinueBtn { get; } = By.Id("continueButton");
        private static By YesCancelRadioBtn { get; } = By.Id("canceladdaddress");
        private static By NoRadioBtn { get; } = By.Id("canceladdaddress-no");


        public static void VerifyCancelPage()
        {
            Assert.AreEqual(CancelPageUrl, WebDriver.Url);
            Assert.AreEqual(CancelPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(CancelPageTitle, WebDriver.Title);
            Assert.AreEqual(Caption, WebDriver.FindElement(CaptionElement).Text);
        }

        public static void ClickBackLink()
        {
            ClickElement(BackLink);
        }

        public static void ClickContinueButton()
        {
            ClickElement(ContinueBtn);
        }

        public static void SelectRadioButton(string RadioButton)
        {
            switch (RadioButton)
            {
                case "Yes, cancel":
                    ClickElement(YesCancelRadioBtn);
                    break;
                case "No, do not cancel":
                    ClickElement(NoRadioBtn);
                    break;
            }
        }

        public static void VerifyYesRadioButtonsPopulated()
        {
            Assert.AreEqual(true, WebDriver.FindElement(YesCancelRadioBtn).Selected);
            
        }

    }
}
