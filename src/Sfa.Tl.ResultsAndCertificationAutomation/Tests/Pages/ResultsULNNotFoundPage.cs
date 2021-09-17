using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class ResultsULNNotFoundPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "search-for-learner-results-ULN-not-found");
        private static readonly string PageTitle = "ULN cannot be found – Results – Manage T Level results – GOV.UK";
        
        public static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        
        public static By BackToSearchButton { get; } = By.Id("searchAgainButton");
        public static readonly string ExpectedButtonText = "Search again";
        public static By BackLink  { get; } = By.Id("backLink");
        public static By BackHome { get; } = By.Id("backToHomeButton");

        public static new void ClickButton(By locator)
        {
            WebDriver.FindElement((locator)).Click();
        }
        public static void VerifyResultsULNNotFoundPage(string ULN)
        {
            string ExpectedHeaderText = "Unique learner number (ULN) " + ULN + " not found";

            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedHeaderText, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.FindElement(BackToSearchButton).Text.Contains(ExpectedButtonText));
        }   

        public static void ClickBackLink()
        {
            WebDriver.FindElement((BackLink)).Click();
        }

        public static void ClickBackToSearchButton()
        {
            WebDriver.FindElement((BackToSearchButton)).Click();
        }
        public static void VerifyBackToHome()
        {
            ClickButton(By.Id("searchButton"));
            ClickButton(BackHome);
            TlevelDashboardPage.VerifyDashboardpage();
        }

    }
}
