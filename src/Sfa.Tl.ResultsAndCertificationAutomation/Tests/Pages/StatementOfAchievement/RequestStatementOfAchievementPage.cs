using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement
{
    public class RequestStatementOfAchievementPage : ElementHelper
    {
       
        private static string PageUrl { get; } = string.Concat(StartPage.StartPageUrl, "request-statement-of-achievement");
        private static string PageHeader { get; } = "Request statement of achievement";
        private static string PageTitle { get; } = "Request statement of achievement page – Manage T Level results – GOV.UK";
        private static By PageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By ContinueBtn { get; } = By.Id("continueButton");
        private static By BackLink { get; } = By.Id("backLink");
        
       
        public static void VerifyRequestStatementOfAchievementPage()
        {
            Assert.AreEqual(PageUrl, WebDriver.Url);
            Assert.AreEqual(PageHeader, WebDriver.FindElement(PageHeaderElement).Text);
            Assert.AreEqual(PageTitle, WebDriver.Title);
        }

        public static void ClickBackLink()
        {
            ClickElement(BackLink);
        }

        public static void ClickContinueButton()
        {
            ClickElement(ContinueBtn);
        }


    }
}
