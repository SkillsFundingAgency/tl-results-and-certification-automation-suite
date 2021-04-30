using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers
{
    public class LearnerCheckAndSubmitPage : ElementHelper
    {
        private static string CheckAndSubmitPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-learner-record-check-and-submit");
        private static string CheckAndSubmitPageTitle { get; } = "Add a new learner T Level record - Check and submit page – Manage T Level results – GOV.UK";
        private static string CheckAndSubmitPageHeader { get; } = "Check and submit";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By LearnerDetails { get; } = By.XPath("//*[@id='main-content']/div/div/form/dl[1]");
        private static By EnglishStatus { get; } = By.XPath("//*[@id='main-content']/div/div/form/dl[2]");
        private static By IpStatus { get; } = By.XPath("//*[@id='main-content']/div/div/form/dl[3]");
        private static By IpChangeLink { get; } = By.Id("industryplacementstatus");
        private static By SubmitBtn { get; } = By.Id("continueButton");
        private static By CancelLink { get; } = By.Id("cancelLink");
        private static By BackLink { get; } = By.Id("backLink");
        public static By changeEnglishMaths = By.Id("englishmathsstatus");

        public static void ClickBackLink()
        {
            ClickElement(BackLink);
        }

        public static void ClickSubmitButton()
        {
            ClickElement(SubmitBtn);
        }


        public static void VerifyProviderCheckAndSubmitPage()
        {
            Assert.AreEqual(CheckAndSubmitPageUrl, WebDriver.Url);
            Assert.AreEqual(CheckAndSubmitPageTitle, WebDriver.Title);
            Assert.AreEqual(CheckAndSubmitPageHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyProviderCheckAndSubmitContent(string uln)
        {
            string ExpectedULN = uln;
            Assert.IsTrue(WebDriver.FindElement(LearnerDetails).Text.Contains(ExpectedULN));
            string ExpectedNameString = Constants.DbFirstName + " " + Constants.DbLastName;
            Assert.IsTrue(WebDriver.FindElement(LearnerDetails).Text.Contains(ExpectedNameString));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetails).Text.Contains(Constants.DbDOB));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetails).Text.Contains(Constants.DbProviderNameForLrs));
        }

        public static void VerifyEnglishAndMathsStatus(string EMStatusTxt)
        {
            Assert.IsTrue(WebDriver.FindElement(EnglishStatus).Text.Contains(EMStatusTxt));
            
        }

        public static void VerifyIPStatus(string IpStatusTxt)
        {
            Assert.IsTrue(WebDriver.FindElement(IpStatus).Text.Contains(IpStatusTxt));
        }

        public static void VerifyProviderCheckAndSubmitLinks()
        {
            Assert.AreEqual(true, WebDriver.FindElement(IpChangeLink).Displayed);
            Assert.AreEqual(true, WebDriver.FindElement(SubmitBtn).Displayed);
            Assert.AreEqual(true, WebDriver.FindElement(CancelLink).Displayed);
        }
    }
}
