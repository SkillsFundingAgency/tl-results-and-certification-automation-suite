using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers
{
    public class SubmitSuccessPage : ElementHelper
    {
        private static string SubmitSuccessPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "learner-record-added-confirmation");
        private static string SubmitSuccessPageTitle { get; } = "Learner T Level record added confirmation page – Manage T Level results – GOV.UK";
        private static string SubmitSuccessPageHeader { get; } = "Learner T Level record added successfully";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By HeaderBody { get; } = By.XPath("//*[@class='govuk-panel__body']");
        private static By addAnotherLearnerBtn { get; } = By.Id("addAnotherLearnerRecordButton");
        private static By backToManageLearner { get; } = By.Id("backToManageLearnerRecordsLink");
        public static void VerifySubmitSuccessPage()
        {
            Assert.AreEqual(SubmitSuccessPageUrl, WebDriver.Url);
            Assert.AreEqual(SubmitSuccessPageTitle, WebDriver.Title);
            Assert.AreEqual(SubmitSuccessPageHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyDataInSuccessPage(string uln)
        {
            Assert.IsTrue(WebDriver.FindElement(HeaderBody).Text.Contains("Db FirstName Db LastName"));
            Assert.IsTrue(WebDriver.FindElement(HeaderBody).Text.Contains("ULN:"+" "+uln));
        }
        public static void VerifyLinksOnSubmitSuccessPage()
        {
            Assert.AreEqual(true, WebDriver.FindElement(addAnotherLearnerBtn).Displayed);
            Assert.AreEqual(true, WebDriver.FindElement(backToManageLearner).Displayed);
        }
        public static void ClickAddNotherLearnerBtn()
        {
            ClickElement(addAnotherLearnerBtn);
        }
        public static void ClickBackToManageLearnerLink()
        {
            ClickElement(backToManageLearner);
        }
    }
}
