using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers
{
    public class QueryEnglishAndMathsStatusPage: ElementHelper
    {
        private static string pageUrl { get; } = "query-english-and-maths-status";
        private static string pagetitle { get; } = "Query English and maths status page – Manage T Level results – GOV.UK";
        private static string pageHeader { get; } = "Query a learner’s English and maths status";
        private static By pageHeadElement { get; } = By.XPath("//*[@id='main-content']//h1");
        //data
        private const string name = "Learner: Db FirstName Db LastName";
        //links
        private static By backToLearnerBtn = By.Id("backButton");
        private static By backLink = By.Id("backLink");
        public static void VerifyQueryEnglishAndMathsStatusPage()
        {
            Assert.AreEqual(pagetitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(pageHeader, WebDriver.FindElement(pageHeadElement).Text);
        }
        public static void VerifyLearnerRecordData()
        {
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(name));
        }
        public static void ClickBackLink()
        {
            ClickElement(backLink);
        }
        public static void ClickBackToLearnerBtn()
        {
            ClickElement(backToLearnerBtn);
        }
    }
}
