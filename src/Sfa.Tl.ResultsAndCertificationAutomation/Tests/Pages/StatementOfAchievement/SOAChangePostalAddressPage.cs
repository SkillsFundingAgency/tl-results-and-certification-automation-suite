using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement
{
    public class SOAChangePostalAddressPage : ElementHelper
    {

        private static string PageUrl { get; } = string.Concat(StartPage.StartPageUrl, "request-statement-of-achievement-change-postal-address");
        private static string PageHeader { get; } = "Change your organisation’s postal address";
        private static string PageTitle { get; } = "Request statement of achievement – Change postal address page – Manage T Level results – GOV.UK";
        private static By PageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By PageCaptionElement { get; } = By.ClassName("govuk-caption-xl");
        private static string PageCaption { get; } = "Request statement of achievement";

        private static By BackLink { get; } = By.Id("backLink");
        private static By ChangeAddressBtn = By.Id("changeAddressButton");


        public static void VerifySOAChangeOrganisationsPostalAddressPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(PageHeader, WebDriver.FindElement(PageHeaderElement).Text);
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(PageCaption, WebDriver.FindElement(PageCaptionElement).Text);
            Assert.AreEqual("Change address", WebDriver.FindElement(ChangeAddressBtn).Text);
        }

        public static void ClickChangeAddressBtn()
        {
            ClickElement(ChangeAddressBtn);
        }

        public static void ClickBackLink()
        {
            ClickElement(BackLink);
        }

    }
}
