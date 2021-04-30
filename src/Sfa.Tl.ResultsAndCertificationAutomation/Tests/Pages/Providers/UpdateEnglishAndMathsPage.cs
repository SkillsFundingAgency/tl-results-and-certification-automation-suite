using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers
{
    public class UpdateEnglishAndMathsPage : ElementHelper
    {
        private static string pageUrl { get; } = "update-learner-record-english-and-maths-achievement";
        private static string pagetitle { get; } = "Update learner T Level record - English and maths achievement page – Manage T Level results – GOV.UK";
        private static string pageHeader { get; } = "Has the learner achieved the required minimum standard for English and maths?";
        private static By pageHeadElement { get; } = By.XPath("//*[@id='main-content']//h1");
        //links
        public static By backToLearnerRecordBtn = By.Id("backToLearnerTLevelRecordButton");
        public static By updateBtn = By.Id("updateButton");
        //Radio Options
        private static By acheived = By.Id("englishandmathsstatus");
        private static By acheivedWithSend = By.Id("status-achieved-send");
        private static By notAcheived = By.Id("status-not-achieved");

        public static void VerifyUpdateIPSuccessPage()
        {
            Assert.AreEqual(pagetitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(pageHeader, WebDriver.FindElement(pageHeadElement).Text);
        }
        public static void VerifyRadioButtonsSelected(string RadioButton)
        {
            switch (RadioButton)
            {
                case "Achieved the minimum standard":
                    Assert.AreEqual(true, WebDriver.FindElement(acheived).Selected);
                    break;
                case "Achieved the minimum standard for learners with SEND":
                    Assert.AreEqual(true, WebDriver.FindElement(acheivedWithSend).Selected);
                    break;
                case "Not achieved the minimum standard":
                    Assert.AreEqual(true, WebDriver.FindElement(notAcheived).Selected);
                    break;
            }
        }
        public static void SelectRadioButton(string RadioButton)
        {
            switch (RadioButton)
            {
                case "Achieved the minimum standard":
                    ClickElement(acheived);
                    break;
                case "Achieved the minimum standard for learners with SEND":
                    ClickElement(acheivedWithSend);
                    break;
                case "Not achieved the minimum standard":
                    ClickElement(notAcheived);
                    break;
            }
            ClickElement(updateBtn);
        }
    }
}
