using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement
{
    public class SOANotAvailableYetPage : ElementHelper
    {
       
        private static string SOANotAvailablePageUrl { get; } = string.Concat(StartPage.StartPageUrl, "statements-of-achievement-not-available");
        private static string SOANotAvailablePageHeader { get; } = "Statements of achievement are not yet available";
        private static string SOANotAvailablePageTitle { get; } = "Statements of achievement not available page – Manage T Level results – GOV.UK";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By BackToHomeBtn { get; } = By.Id("backButton");
        private static By BackLink { get; } = By.Id("backLink");
        private static string PageText = "It is too early to request a statement of achievement. Printing will be available from 10 August 2021.";
        private static By PageTextElement { get; } = By.ClassName("govuk-body govuk-!-margin-top-3");



        public static void VerifySOANotAvailableYetPage()
        {
            Assert.AreEqual(SOANotAvailablePageUrl, WebDriver.Url);
            Assert.AreEqual(SOANotAvailablePageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(SOANotAvailablePageTitle, WebDriver.Title);
        }

        public static void ClickBackLink()
        {
            ClickElement(BackLink);
        }

        public static void ClickBackToHomeButton()
        {
            ClickElement(BackToHomeBtn);
        }


    }
}
