using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers
{
    public class LearnerRecordPage_ToBeDeleted : ElementHelper
    {
        private static string pageUrl { get; } = "learner-record-page";
        private static string pagetitle { get; } = "Learner T Level record page – Manage T Level results – GOV.UK";

        private static By statusElement = By.XPath("//*[@id='main-content']/div/div/dl[1]/div/dd[1]");

        private static By LearnerDetailsElement = By.XPath("//*[@id='main-content']/div/div/dl[1]");
        //data
        private const string name = "Db FirstName Db LastName";
        private const string dob = "01 January 2001";
        private const string provider = "Barnsley College";
        private const string Tlevel = "T Level in Agriculture, Environmental and Animal Care";
        private const string statusEM = "Achieved minimum standard (Data from the Learning Records Service - LRS)";
        private const string statusEMNonLRS = "Achieved minimum standard";
        private const string statusIP = "Placement completed";
        //links
        private static By emStatusLink = By.Id("englishmathsstatus");
        public static By ipStatusLink = By.Id("industryplacementstatus");
        private static By searchAgainLink = By.Id("searchAgainLink");
        private static By breadCrumb1 = By.Id("breadcrumb1");
        private static By breadCrumb2 = By.Id("breadcrumb2");
        private static By breadCrumb0 = By.Id("breadcrumb0");
        private static By AddMathsLink = By.Id("mathsstatus");
        private static By AddEnglishLink = By.Id("englishstatus");
        private static By AddIpLink = By.Id("industryplacement");
        private static By AddIpFromBanner = By.LinkText("Add industry placement details");
        private static By AddMathsFromBanner = By.LinkText("Add maths level details");
        private static By AddEnglishFromBanner = By.LinkText("Add English level details");
        public static void VerifyLearnerRecordPage()
        {
            Assert.AreEqual(pagetitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            //Assert.AreEqual(pageHeader, WebDriver.FindElement(pageHeadElement).Text);
        }
        public static void VerifyLearnerRecordData(string uln)
        {
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(name));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(dob));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(provider));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Tlevel));
        }
        public static void VerifyEMAndIPStatus()
        {
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(statusEM));
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(statusIP));
        }

        public static void VerifyEMAndIPStatus(string EMStatus, string IPStatus)
        {
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(EMStatus));
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(IPStatus));
        }

        public static void VerifyEMAndIPStatusForNonLRS()
        {
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(statusEMNonLRS));
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(statusIP));
        }
        public static void VerifyLinksOnLearnerRecordPage()
        {
            Assert.AreEqual(true, WebDriver.FindElement(emStatusLink).Displayed);
            Assert.AreEqual(true, WebDriver.FindElement(ipStatusLink).Displayed);
            Assert.AreEqual(true, WebDriver.FindElement(searchAgainLink).Displayed);
        }
        public static void VerifyLinksOnLearnerRecordNonLRSPage()
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
                case "Manage learner T Level records":
                    ClickElement(breadCrumb1);
                    break;
                case "Home":
                    ClickElement(breadCrumb0);
                    break;
            }
        }
        //public static void VerifyHomePage()
        //{
        //    Assert.IsTrue(WebDriver.Url.Contains("home"));
        //    Assert.AreEqual("Home page – Manage T Level results – GOV.UK", WebDriver.Title);
        //}
        public static void NavigateToLearnerRecordPage(string uln)
        {
            ClickLinkByLabel("Manage learner T Level records");
            ClickLinkByLabel("Update a learner T Level record");
            UpdateLearnerSearchPage.Enteruln(uln);
        }
        public static void Clicklink(string name)
        {
            switch (name)
            {
                case "Query":
                    ClickElement(emStatusLink);
                    break;
                case "Update":
                    ClickElement(ipStatusLink);
                    break;
            }
        }
        public static void VerifyEMOrIPStatus(string text)
        {
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(text));
        }

        public static void VerifyEMStatus(string Status)
        {
            Assert.IsTrue(WebDriver.FindElement(statusElement).Text.Contains(Status));
        }




    }
}
