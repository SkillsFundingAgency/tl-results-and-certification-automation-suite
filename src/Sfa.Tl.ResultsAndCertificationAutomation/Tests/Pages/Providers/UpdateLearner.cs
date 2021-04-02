using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers
{
    public class UpdateLearner : ElementHelper
    {
        private static string searchLearnerUrl { get; } = "search-learner-record-unique-learner-number";
        private static string searchLearnerTitle { get; } = "Search for a learner - Enter Unique Learner Number page – Manage T Level results – GOV.UK";
        private static string searchLearnerHeader { get; } = "Search for a learner";
        private static By pageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By searchLearner { get; } = By.Id("searchuln");
        private static By searchBtn { get; } = By.Id("searchButton");
        private static By continueBtn { get; } = By.Id("continueButton");
        public static By backLink { get; } = By.Id("backLink");
        // Uln not found or added page
        private static string searchLearnerNotAddedUrl { get; } = "search-learner-record-ULN-not-added";
        private static string searchLearnerNotAddedTitle { get; } = "Search for a learner - ULN not added page – Manage T Level results – GOV.UK";

        public static void VerifySearchLearnerPage()
        {
            Assert.AreEqual(searchLearnerTitle, WebDriver.Title);
            Assert.AreEqual(searchLearnerHeader, WebDriver.FindElement(pageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(searchLearnerUrl));
        }
        public static void UlnNotAddedPage(string uln)
        {
            Assert.AreEqual(searchLearnerNotAddedTitle, WebDriver.Title);
            Assert.AreEqual("ULN ("+ uln +") has not been added", WebDriver.FindElement(pageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(searchLearnerNotAddedUrl));
            PageHelper.FindElementIfExists(continueBtn);
        }
        public static void Enteruln(string uln)
        {
            ClearText(searchLearner);
            EnterText(searchLearner, uln);
            ClickButton(searchBtn);
        }
        public static void IsUlnExists(string uln)
        {
            string actualValue = WebDriver.FindElement(searchLearner).GetAttribute("value");
            PageHelper.VerifyText(actualValue, uln);
        }
    }
}
