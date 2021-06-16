using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement
{
    public class SOAConfirmationPage : ElementHelper
    {
        private static string PageUrl { get; } = string.Concat(StartPage.StartPageUrl, "request-statement-of-achievement-confirmation");
        private static string PageHeader { get; } = "Statement of achievement requested successfully";
        private static string PageTitle { get; } = "Statement of achievement requested confirmation page – Manage T Level results – GOV.UK";
        private static By pageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By backToHomeBtn{ get; } = By.Id("backToHomeButton");
        private static By TextAreaElement = By.XPath("//*[@id='main-content']/div/div/div[1]");
        
        public static void VerifyRequestSOAConfirmationPage(string URL, string Name)
        {
            Assert.AreEqual(PageUrl, WebDriver.Url);
            Assert.AreEqual(PageHeader, WebDriver.FindElement(pageHeaderElement).Text);
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.FindElement(TextAreaElement).Text.Contains(Name));
            Assert.IsTrue(WebDriver.FindElement(TextAreaElement).Text.Contains(URL));
        }
        public static void ClickBackToHomeBtn()
        {
            ClickElement(backToHomeBtn);
        }

    }
}
