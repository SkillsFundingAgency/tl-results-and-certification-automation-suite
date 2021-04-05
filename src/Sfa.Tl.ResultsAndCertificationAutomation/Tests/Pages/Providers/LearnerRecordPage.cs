using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers
{
    public class LearnerRecordPage : ElementHelper
    {
        private static string pageUrl { get; } = "learner-record-page";
        private static string pagetitle { get; } = "Learner T Level record page – Manage T Level results – GOV.UK";
        private static string pageHeader { get; } = "Learner T Level record";
        private static By pageHeadElement { get; } = By.XPath("//*[@id='main-content']//h1");
        //data
        private const string name = "Name: Db FirstName Db LastName";
        private const string dob = "Date of birth: 01/01/2001";
        private const string provider = "Provider (UKPRN): Barnsley College (10000536)";
        private const string core = "T Level core: Agriculture, Environmental and Animal Care (77777777)";
        private const string statusEM = "Achieved minimum standard (data from Learning Records Service - LRS)";
        private const string statusIP = "Placement completed";
        //links
        private static By emStatusLink = By.Id("englishmathsstatus");
        private static By ipStatusLink = By.Id("industryplacementstatus");
        private static By searchAgainLink = By.Id("searchAgainLink");
        private static By breadCrumb1 = By.Id("breadcrumb1");
        private static By breadCrumb2 = By.Id("breadcrumb2");
        private static By breadCrumb0 = By.Id("breadcrumb0");
        public static void VerifyLearnerRecordPage()
        {
            Assert.AreEqual(pagetitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(pageHeader, WebDriver.FindElement(pageHeadElement).Text);
        }
        public static void VerifyLearnerRecordData(string uln)
        {
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains("ULN: " + uln + ""));
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(name));
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(dob));
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(provider));
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(core));
        }
        public static void VerifyEMAndIPStatus()
        {
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(statusEM));
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(statusIP));
        }
        public static void VerifyLinksOnLearnerRecordPage()
        {
            Assert.AreEqual(true, WebDriver.FindElement(emStatusLink).Displayed);
            Assert.AreEqual(true, WebDriver.FindElement(ipStatusLink).Displayed);
            Assert.AreEqual(true, WebDriver.FindElement(searchAgainLink).Displayed);
        }
        public static void ClickBreadCrumb(string name)
        {
            switch (name)
            {
                case "Search for a learner":
                    ClickElement(breadCrumb2);
                    break;
                case "Manage learner records":
                    ClickElement(breadCrumb1);
                    break;
                case "Home":
                    ClickElement(breadCrumb0);
                    break;
            }
        }
        public static void VerifyHomePage()
        {
            Assert.IsTrue(WebDriver.Url.Contains("home"));
            Assert.AreEqual("Home page – Manage T Level results – GOV.UK", WebDriver.Title);
        }
    }
}
