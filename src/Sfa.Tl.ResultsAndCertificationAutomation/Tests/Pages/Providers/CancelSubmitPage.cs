using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers
{
    public class CancelSubmitPage : ElementHelper
    {
        private static By cancelLink { get; } = By.Id("cancelLink");
        private static string CancelPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-learner-record-cancel");
        private static string CancelPageTitle { get; } = "Cancel adding a new learner page – Manage T Level results – GOV.UK";
        private static string CancelPageHeader { get; } = "Are you sure you want to cancel adding this learner’s T Level record?";
        private static By cancelYesRadio { get; } = By.Id("cancellearnerrecord");
        public static By cancelNoRadio { get; } = By.Id("cancel-learner-record-no");
        private static By continueBtn { get; } = By.Id("continueButton");
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By LearnerDetails { get; } = By.Id("main-content");
        public static void VerifyCancelPage()
        {
            Assert.AreEqual(CancelPageUrl, WebDriver.Url);
            Assert.AreEqual(CancelPageTitle, WebDriver.Title);
            Assert.AreEqual(CancelPageHeader, WebDriver.FindElement(PageHeader).Text);
            string ExpectedNameString = "Learner"+" "+Constants.DbFirstName + " " +Constants.DbLastName;
            Assert.IsTrue(WebDriver.FindElement(LearnerDetails).Text.Contains(ExpectedNameString));
        }
        public static void VerifyCanelRadioOption()
        {
            Assert.AreEqual(true, WebDriver.FindElement(cancelYesRadio).Selected);
            Assert.AreEqual(false, WebDriver.FindElement(cancelNoRadio).Selected);
            Assert.AreEqual(true, WebDriver.FindElement(continueBtn).Displayed);
        }
    }
}
