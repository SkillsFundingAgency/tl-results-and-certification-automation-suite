using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers
{
    public class CheckAndSubmitPage : ElementHelper
    {
        private static string CheckAndSubmitPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-learner-record-check-and-submit");
        private static string CheckAndSubmitPageTitle { get; } = "Add a new learner record – Check and submit page – Manage T Level results – GOV.UK";
        private static string CheckAndSubmitPageHeader { get; } = "Check and submit";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By LearnerDetails { get; } = By.XPath("//*[@id='main-content']/div/div/form/dl[1]");
        private static By EnglishStatus { get; } = By.XPath("//*[@id='main-content']/div/div/form/dl[2]");
        private static By IpStatus { get; } = By.XPath("//*[@id='main-content']/div/div/form/dl[3]");
        private static By IpChangeLink { get; } = By.Id("industryplacementstatus");
        private static By ContunueBtn { get; } = By.Id("continueButton");
        private static By CancelLink { get; } = By.Id("cancelLink");
        public static void VerifyProviderCheckAndSubmitPage()
        {
            Assert.AreEqual(CheckAndSubmitPageUrl, WebDriver.Url);
            Assert.AreEqual(CheckAndSubmitPageTitle, WebDriver.Title);
            Assert.AreEqual(CheckAndSubmitPageHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyProviderCheckAndSubmitContent(string uln, string EMStatusTxt, string IpStatusTxt)
        {
            string ExpectedPageSubHeading = uln;
            Assert.AreEqual(ExpectedPageSubHeading, WebDriver.FindElement(LearnerDetails).Text);
            string ExpectedNameString = Constants.DbFirstName + " " + Constants.DbLastName;
            Assert.AreEqual(ExpectedNameString, WebDriver.FindElement(LearnerDetails).Text);
            string ExpectedDobString = Constants.DbDOB;
            Assert.AreEqual(ExpectedDobString, WebDriver.FindElement(LearnerDetails).Text);
            string ExpectedProvider = RegistrationsManualPage.InputPovider;
            Assert.AreEqual(ExpectedProvider, WebDriver.FindElement(LearnerDetails).Text);
            Assert.AreEqual(EMStatusTxt, WebDriver.FindElement(EnglishStatus).Text);
            Assert.AreEqual(IpStatusTxt, WebDriver.FindElement(IpStatus).Text);
        }
        public static void VerifyProviderCheckAndSubmitLinks()
        {
            Assert.AreEqual(true, WebDriver.FindElement(IpChangeLink).Displayed);
            Assert.AreEqual(true, WebDriver.FindElement(ContunueBtn).Displayed);
            Assert.AreEqual(true, WebDriver.FindElement(CancelLink).Displayed);
        }
    }
}
