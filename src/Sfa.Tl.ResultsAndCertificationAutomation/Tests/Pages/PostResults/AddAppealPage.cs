using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults
{
    public class AddAppealPage : ElementHelper
    {
        private static string PageUrl { get; } = "post-results-add-appeal";
        private static string PageTitle { get; } = "Add an appeal - Post-results – Manage T Level results – GOV.UK";
        private static string PageErrorTitle { get; } = "Error: Add an appeal - Post-results – Manage T Level results – GOV.UK";
        private static string PageHeader { get; } = "Add an appeal";
        private static readonly By PageHeaderElement = By.XPath("//*[@id='main-content']//h1");
        private static readonly By LearnerDetailsElement = By.XPath("//*[@id='main-content']/div[1]");
        private static readonly By RadioBtnYes = By.Id("isappealrequested");
        private static readonly By RadioBtnNo = By.Id("isappealrequested-no");
        private static readonly By ContinueBtn = By.Id("continueButton");

        public static void VerifyAddAppealPage()
        {
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(PageHeader, WebDriver.FindElement(PageHeaderElement).Text);
        }
        protected static void AddAppealBtn(string buttonName)
        {
            switch (buttonName)
            {
                case "Yes, request appeal":
                    ClickElement(RadioBtnYes);
                    ClickButton(ContinueBtn);
                    break;
                case "No, request appeal":
                    ClickElement(RadioBtnNo);
                    ClickButton(ContinueBtn);
                    break;
            }
        }
        protected static void VerifyAddAppealErrorPage()
        {
            Assert.AreEqual(PageErrorTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        }
        protected static void VerifyLearnerCoreDetailsAddAppealPage()
        {
            const string text = "Tell us that " + Constants.DbFirstName + " " + Constants.DbLastName + " has asked for an appeal of their " + Constants.DbCoreComponentName + "";
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(text));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbDateOfBirth));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbTlevel));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbCoreComponent));
            const string requestAppealText = "Has " + Constants.DbFirstName + " " + Constants.DbLastName + " raised an appeal against this grade?";
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(requestAppealText));
        }
    }
}
