using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals
{
    public class RAUlnNotFoundPage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "reviews-and-appeals-uln-not-found");
        private static string pageTitle { get; } = "ULN not found – Manage T Level results – GOV.UK";
        private static By pageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By backLink { get; } = By.Id("backLink");
        private static By searchAgainBtn { get; } = By.Id("buttonSearchAgain");
        private static By backToHomeBtn { get; } = By.Id("buttonBackToHome");
        public static void VerifyUlnNotFoundPage(string uln)
        {
            Assert.AreEqual(pageUrl, WebDriver.Url);
            Assert.AreEqual(pageTitle, WebDriver.Title);
            Assert.AreEqual("Unique Learner Number (ULN) " + uln + " not found", WebDriver.FindElement(pageHeaderElement).Text);
        }
        public static void VerifyBackLink(string uln)
        {
            ClickElement(backLink);
            Assert.AreEqual(uln, WebDriver.FindElement(By.Id("searchuln")).GetAttribute("value"));
        }
        public static void VerifySearchAgainBtn()
        {
            ClickButton(searchAgainBtn);
            ReviewsAndAppealsSearchLearner.VerifySearchLearnerPage();
        }
        public static void ClickbackToHomeBtn() => ClickButton(backToHomeBtn);
    }
}
