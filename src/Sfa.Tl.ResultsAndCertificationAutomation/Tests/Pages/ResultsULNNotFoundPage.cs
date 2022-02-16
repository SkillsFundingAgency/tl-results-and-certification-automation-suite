using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class ResultsUlnNotFoundPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "results-uln-not-found");
        private const string PageTitle = "ULN not found - Results – Manage T Level results – GOV.UK";

        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");

        private static By BackToSearchButton { get; } = By.Id("searchAgainButton");
        private const string ExpectedButtonText = "Search again";
        private static By BackLink  { get; } = By.Id("backLink");
        private static By BackHome { get; } = By.Id("backToHomeButton");

        private new static void ClickButton(By locator)
        {
            WebDriver.FindElement((locator)).Click();
        }
        public static void VerifyResultsUlnNotFoundPage(string uln)
        {
            var expectedHeaderText =  uln + " not found";

            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(expectedHeaderText, WebDriver.FindElement(PageHeader).Text);
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
