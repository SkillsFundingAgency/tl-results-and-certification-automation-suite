using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals
{
    public class RAUAppealGradePage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "reviews-and-appeals-appeal-grade");
        private static string pageTitle { get; } = "Appeal grade – Manage T Level results – GOV.UK";
        private static By pageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static string  pageHeader { get; } = "Appeal grade";
        private static By submitBtn { get; } = By.Id("submitButton");
        private static By learnerDetailsElement { get; } = By.XPath("//*[@id='main-content']/div/div/form");
        private static By backLink = By.Id("backLink");
        private static By yesRadioBtn = By.Id("appealgrade");
        private static By noRadioBtn = By.Id("appealgrade-no");
        private static By originalGrade = By.XPath("//*[@id='main-content']//div[6]");
        private static By mainErrorMesg = By.ClassName("govuk-error-summary__body");
        private static By subErrorMesg = By.ClassName("govuk-error-message");
     

        public static void VerifyRAUAppealGradePage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(pageTitle, WebDriver.Title);
            Assert.AreEqual(WebDriver.FindElement(pageHeaderElement).Text, pageHeader);
        }

        public static void VerifyRAULearnerDetails(string ULN)
        {
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(ULN));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RAAName));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RAADOB));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RAACoreTitle));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RAACoreCode));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RAAExamPeriod));
            Assert.IsTrue(WebDriver.FindElement(originalGrade).Text.Contains(Constants.RAAOriginalGrade));
        }

        public static void VerifyErrorMessage(string ErrorMsg)
        {
            Assert.IsTrue(WebDriver.FindElement(mainErrorMesg).Text.Contains(ErrorMsg));
            Assert.IsTrue(WebDriver.FindElement(subErrorMesg).Text.Contains(ErrorMsg));
        }

        public static void ClickSubmitBtn()
        {
            ClickButton(submitBtn);
        }


        public static void ClickBackLink()
        {
            ClickButton(backLink);
        }

        public static void VerifyRadioButtonsNotPrepopulated()
        {
            Assert.AreEqual(false, WebDriver.FindElement(yesRadioBtn).Selected);
            Assert.AreEqual(false, WebDriver.FindElement(noRadioBtn).Selected);
        }

        public static void ClickYesRadioBtn()
        {
            ClickButton(yesRadioBtn);
        }

    }
}
