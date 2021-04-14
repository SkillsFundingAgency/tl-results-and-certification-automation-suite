using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class LearnerManageLearnerRecordsPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "manage-learner-records");
        public static string PageTitle = "Manage learner records page – Manage T Level results – GOV.UK";
        public static By AddLearnerRecordsLink { get; } = By.LinkText("Add a new learner record");

        public static By UpdateALearnerRecordLink = By.XPath("//*[contains(text(),'Update a learner record')]");
        
        public static By HomeBreadcrumb = By.Id("breadcrumb0");
        public static string ExpectedHomeBreadcrumbText = "Home";
        public static By ManageLearnerRecordsBreadcumb = By.Id("breadcrumb1");
        public static string ExpectedManageLearnerRecordBreadcumbText = "Manage learner records";
        public static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        public static string PageHeaderText = "Manage learner records";
        public static By PageSubHeader { get; } = By.XPath("//*[@id='main-content']/div[1]/div/p");
        public static string PageSubHeaderText = "Add or update records for learners who have been registered on a T Level programme by the awarding organisation.";


        public static void ClickAddANewLearnerRecordLink()
        {
            WebDriver.FindElement((AddLearnerRecordsLink)).Click();
        }

        public static void ClickHomeLink()
        {
            WebDriver.FindElement((HomeBreadcrumb)).Click();
        }

        public static void VerifyManageLearnerRecordsPage()
        {
            Assert.AreEqual(PageUrl, WebDriver.Url);
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(PageHeaderText, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(PageSubHeaderText, WebDriver.FindElement(PageSubHeader).Text);
            Assert.AreEqual(ExpectedHomeBreadcrumbText, WebDriver.FindElement(HomeBreadcrumb).Text);
            Assert.AreEqual(ExpectedManageLearnerRecordBreadcumbText, WebDriver.FindElement(ManageLearnerRecordsBreadcumb).Text);

        }

        public static void VerifyBoxText(string ExpectedAddLearnerRecordLinkText, string ExpectedUpdateALearnerRecordLinkText)
        {
            Assert.AreEqual(ExpectedAddLearnerRecordLinkText, WebDriver.FindElement(AddLearnerRecordsLink).Text);
            Assert.AreEqual(ExpectedUpdateALearnerRecordLinkText, WebDriver.FindElement(UpdateALearnerRecordLink).Text);
        }
        public static void VerifyLinksOnManageLearnerRecordsPage(string link1, string link2)
        {
            FindElementContainingText(link1);
            FindElementContainingText(link2);
        }

        public static void ClickUpdateLearnerRecordLink()
        {
            ClickElement(UpdateALearnerRecordLink);
        }

    }
}
