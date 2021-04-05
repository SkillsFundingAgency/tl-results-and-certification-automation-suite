using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers
{
    public class UpdateIndustryPlacementpage : ElementHelper
    {
        private static string pageUrl { get; } = "update-learner-record-industry-placement-status";
        private static string pageTitle { get; } = "Update learner T Level record - Industry placement status page – Manage T Level results – GOV.UK";
        private static string pageHeader { get; } = "Has the learner completed their industry placement?";
        private static By pageHeadElement { get; } = By.XPath("//*[@id='main-content']//h1");
        //radio options
        private static By yesCompleted { get; } = By.Id("industryplacementstatus");
        private static By completedWithSC { get; } = By.Id("tl-industry-placement-status-wsp");
        private static By notCompleted { get; } = By.Id("tl-industry-placement-status-not-comp");
        public static By updateBtn { get; } = By.Id("updateButton");
        public static void VerifyUpdateIPPage()
        {
            Assert.AreEqual(pageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(pageHeader, WebDriver.FindElement(pageHeadElement).Text);
        }
        public static void VerifyRadioButtonsSelected(string RadioButton)
        {
            switch (RadioButton)
            {
                case "Yes, completed":
                    Assert.AreEqual(true, WebDriver.FindElement(yesCompleted).Selected);
                    break;
                case "Yes, completed with special consideration":
                    Assert.AreEqual(true, WebDriver.FindElement(completedWithSC).Selected);
                    break;
                case "No, still to be completed":
                    Assert.AreEqual(true, WebDriver.FindElement(notCompleted).Selected);
                    break;
            }
        }
        public static void SelectRadioButton(string RadioButton)
        {
            switch (RadioButton)
            {
                case "Yes, completed":
                    ClickElement(yesCompleted);
                    break;
                case "Yes, completed with special consideration":
                    ClickElement(completedWithSC);
                    break;
                case "No, still to be completed":
                    ClickElement(notCompleted);
                    break;
            }
            ClickElement(updateBtn);
        }
    }
}
