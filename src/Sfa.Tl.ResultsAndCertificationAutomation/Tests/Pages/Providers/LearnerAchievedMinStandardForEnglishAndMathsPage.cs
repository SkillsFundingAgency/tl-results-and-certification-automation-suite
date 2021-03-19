using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers
{
    public class LearnerAchievedMinStandardForEnglishAndMathsPage : ElementHelper
    {
        private static string PageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-learner-record-english-and-maths-achievement");
        private static string PageTitle { get; } = "Add a new learner record - English and maths achievement page – Manage T Level results – GOV.UK";
        private static string ErrorPageTitle { get; } = "Error: Add a new learner record - English and maths achievement page – Manage T Level results – GOV.UK";
        private static string ExpectedPageHeader { get; } = "Has the learner achieved the required minimum standard for English and maths?";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static string ExpectedCaption { get; } = "Add a new learner T Level record";
        private static By Caption { get; } = By.XPath("//*[@id='addEnglishAndMathsForm']/div/span");
        private static By LearnerDetails { get; } = By.Id("uln-hint");
        private static By ContinueBtn { get; } = By.Id("continueButton");
        private static By BackLink { get; } = By.Id("backLink");
        private static By RadioAchievedMinStandard { get; } = By.Id("englishandmathsstatus");
        private static string ExpectedTextAchievedMinStandard { get; } = "Achieved the minimum standard";
        private static By RadioAchievedMinStandardWithSend { get; } = By.Id("status-achieved-send");
        private static string ExpectedTextAchievedMinStandardWithSend { get; } = "Achieved the minimum standard with SEND adjustments";
        private static By RadioNotAchievedMinStandard { get; } = By.Id("status-not-achieved");
        private static string ExpectedTextNotAchievedMinStandard { get; } = "Not achieved the minimum standard";
        public static By MainErrorMessage = By.XPath("//*[@id='main-content']//ul/li/a");
        public static By SubErrorMessage = By.XPath("//*[@id='main-content']//div[2]//div/span");


        public static void ClickBackLink()
        {
            ClickElement(BackLink);
        }

        public static void VerifyMinStandardAchievedForEnglishMathsPage()
        {
            Assert.AreEqual(PageUrl, WebDriver.Url);
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(ExpectedCaption, WebDriver.FindElement(Caption).Text);
            Assert.IsTrue(WebDriver.FindElement(ContinueBtn).Text.Contains("Continue"));
            //Assert.AreEqual(ExpectedTextAchievedMinStandard, WebDriver.FindElement(RadioAchievedMinStandard).Text);
            //Assert.AreEqual(ExpectedTextAchievedMinStandardWithSend, WebDriver.FindElement(RadioAchievedMinStandardWithSend).Text);
            //Assert.AreEqual(ExpectedTextNotAchievedMinStandard, WebDriver.FindElement(RadioNotAchievedMinStandard).Text);

        }


        public static void VerifyProviderCheckAndSubmitContent(string uln)
        {
            string ExpectedULN = uln;
            string ExpectedNameString = Constants.DbFirstName + " " + Constants.DbLastName;
            Assert.IsTrue(WebDriver.FindElement(LearnerDetails).Text.Contains(ExpectedNameString));
    
        }

        public static void VerifyErrorMessage(string ErrorMessage)
        {
            Assert.AreEqual(ErrorPageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.FindElement(MainErrorMessage).Text.Contains(ErrorMessage));
            Assert.IsTrue(WebDriver.FindElement(SubErrorMessage).Text.Contains(ErrorMessage));
        }

        public static void VerifyRadioButtonsNotSelected()
        {
            Assert.AreEqual(false, WebDriver.FindElement(RadioAchievedMinStandard).Selected);
            Assert.AreEqual(false, WebDriver.FindElement(RadioAchievedMinStandardWithSend).Selected);
            Assert.AreEqual(false, WebDriver.FindElement(RadioNotAchievedMinStandard).Selected);
        }

        public static void ClickAchievedMinStandardRadio()
        {
            WebDriver.FindElement((RadioAchievedMinStandard)).Click();
        }

        public static void ClickAchievedMinStandardWithSendRadio()
        {
            WebDriver.FindElement((RadioAchievedMinStandardWithSend)).Click();
        }

        public static void ClickNotAchievedMinStandardRadio()
        {
            WebDriver.FindElement((RadioNotAchievedMinStandard)).Click();
        }

        public static void ClickContinue()
        {
            WebDriver.FindElement((ContinueBtn)).Click();
        }

        public static void ClickRadioButton(string RadioButton)
        {
            switch (RadioButton)
            {
                case "Achieved the minimum standard":
                    ClickAchievedMinStandardRadio();
                    break;
                case "Achieved the minimum standard with SEND adjustments":
                    ClickAchievedMinStandardWithSendRadio();
                    break;
                case "Not achieved the minimum standard":
                    ClickNotAchievedMinStandardRadio();
                    break;

            }
            ClickContinue();
        }

        public static void VerifyRadioButtonsSelected(string RadioButton)
        {
            switch (RadioButton)
            {
                case "Achieved the minimum standard":
                    Assert.AreEqual(true, WebDriver.FindElement(RadioAchievedMinStandard).Selected);
                    break;
                case "Achieved the minimum standard with SEND adjustments":
                    Assert.AreEqual(true, WebDriver.FindElement(RadioAchievedMinStandardWithSend).Selected);
                    break;
                case "Not achieved the minimum standard":
                    Assert.AreEqual(true, WebDriver.FindElement(RadioNotAchievedMinStandard).Selected);
                    break;
            }
        }
    }
}
