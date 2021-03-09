using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class LearnerManageLearnerRecordsPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "manage-learner-records");
        public static string PageTitle = "Manage learner records page – Manage T Level results – GOV.UK";
        public static By AddLearnerRecordsLink = By.XPath("//a[@href='/add-learner-record-unique-learner-number']");
       

        public static By UpdateALearnerRecordLink = By.XPath("//a[@href='/manage-learner-records']");
        
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
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
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

    }
}
