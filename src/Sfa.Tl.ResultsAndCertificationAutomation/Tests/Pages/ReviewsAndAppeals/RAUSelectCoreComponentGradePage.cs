using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals
{
    public class RAUSelectCoreComponentGradePage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "reviews-and-appeals-appeal-update-grade");
        private static string pageTitle { get; } = "Select core component grade – Manage T Level results – GOV.UK";
        private static By pageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static string  PageHeader { get; } = "Select the core component grade";
        private static By continueBtn { get; } = By.Id("continueButton");
        private static By learnerDetailsElement { get; } = By.XPath("//*[@id='main-content']//form");
        private static By backLink = By.Id("backLink");
        private static By AStarGradeRadioBtn = By.Id("selectedgradecode");
        private static By AGradeRadioBtn = By.Id("selectedgradecode-1");
        private static By BGradeRadioBtn = By.Id("selectedgradecode-2");
        private static By CGradeRadioBtn = By.Id("selectedgradecode-3");
        private static By DGradeRadioBtn = By.Id("selectedgradecode-4");
        private static By EGradeRadioBtn = By.Id("selectedgradecode-5");
        private static By UnclassifiedGradeRadioBtn = By.Id("selectedgradecode-6");
        private static By mainErrorMesg = By.ClassName("govuk-error-summary__body");
        private static By subErrorMesg = By.ClassName("govuk-error-message");
        private static By oldGradeElement = By.XPath("//*[@id='main-content']//dl/div[6]/dd[1]");



        public static void VerifySelectTheCoreComponentGradePage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(pageTitle, WebDriver.Title);
            Assert.AreEqual(PageHeader, WebDriver.FindElement(pageHeaderElement).Text);
        }

        public static void VerifyRAULearnerDetails(string ULN)
        {
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(ULN));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RaaName));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.Raadob));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RaaExamPeriod));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RaaCoreCode));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RaaCoreTitle));

            //Get current grade from TqPathwayResult table and compare against old grade on screen
            string Grade = SqlQueries.RetrieveLatestGrade(ULN);
            Assert.AreEqual(Grade, WebDriver.FindElement(oldGradeElement).Text);
        }

        public static void ClickBackLink()
        {
            ClickButton(backLink);
        }
        public static void ClickContinueBtn()
        {
            ClickButton(continueBtn);
        }

        public static void VerifyRadioButtonsNotPopulated()
        {
            Assert.AreEqual(false, WebDriver.FindElement(AStarGradeRadioBtn).Selected);
            Assert.AreEqual(false, WebDriver.FindElement(AGradeRadioBtn).Selected);
            Assert.AreEqual(false, WebDriver.FindElement(BGradeRadioBtn).Selected);
            Assert.AreEqual(false, WebDriver.FindElement(CGradeRadioBtn).Selected);
            Assert.AreEqual(false, WebDriver.FindElement(DGradeRadioBtn).Selected);
            Assert.AreEqual(false, WebDriver.FindElement(EGradeRadioBtn).Selected);
            Assert.AreEqual(false, WebDriver.FindElement(UnclassifiedGradeRadioBtn).Selected);
        }

        public static void VerifyErrorMessage(string ErrorMsg)
        {
            Assert.IsTrue(WebDriver.FindElement(mainErrorMesg).Text.Contains(ErrorMsg));
            Assert.IsTrue(WebDriver.FindElement(subErrorMesg).Text.Contains(ErrorMsg));
        }

        public static void VerifyOldGrade(string ULN)
        {
            //Verify the TqPathwayResult table record is updated to state the grade is being appealed
            int resultStatus = SqlQueries.RetrieveResultStatus(ULN);
            Assert.AreEqual(3, resultStatus);
        }

        public static void ClickAGradeRadioButton()
        {
            ClickButton(AGradeRadioBtn);
        }

        public static void ClickBGradeRadioButton()
        {
            ClickButton(BGradeRadioBtn);
        }


    }
}
