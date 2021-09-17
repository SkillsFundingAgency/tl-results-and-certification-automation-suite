using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals
{
    public class RAUExceptionsConfirmAppeal : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "confirm-appeal-after-deadline");
        private static string pageTitle { get; } = "Confirm appeal after deadline – Manage T Level results – GOV.UK";
        private static By pageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static string  PageHeader { get; } = "Appeal a grade after the deadline";
        private static By submitBtn { get; } = By.Id("submitButton");
        private static By backLink { get; } = By.Id("backLink");
        private static By learnerDetailsElement { get; } = By.XPath("//*[@id='main-content']/div/div/form");
        private static string subPageHeader { get; } = "Is this grade being appealed?";
        private static By yesRadioBtn = By.Id("isthisgradebeingappealed");
        private static By noRadioBtn = By.Id("isthisgradebeingappealed-no");     
        private static By mainErrorMesg = By.ClassName("govuk-error-summary__body");
        private static By subErrorMesg = By.ClassName("govuk-error-message");
        private static By originalGrade = By.XPath("//*[@id='main-content']//div[6]");
        private static By RadioButtonTextElement = By.ClassName("govuk-fieldset");



        public static void VerifyExceptionConfirmAppealPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(pageTitle, WebDriver.Title);
            Assert.AreEqual(PageHeader, WebDriver.FindElement(pageHeaderElement).Text);
        }

        public static void VerifyLearnerDetails(string ULN)
        {
  
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RAAName));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(ULN));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RAADOB));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RAACoreTitle));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RAACoreCode));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RAAExamPeriod));
            Assert.IsTrue(WebDriver.FindElement(originalGrade).Text.Contains(Constants.RAAOriginalGrade));
        }

        public static void VerifRadioButtonText()
        {
            Assert.IsTrue(WebDriver.FindElement(RadioButtonTextElement).Text.Contains("Yes, it is being appealed"));
            Assert.IsTrue(WebDriver.FindElement(RadioButtonTextElement).Text.Contains("No, leave it as it is"));
        }

        public static void ClickBackLink()
        {
            ClickButton(backLink);
           
        }

        public static void ClickYesRadioBtn()
        {
            ClickButton(yesRadioBtn);
        }

        public static void ClickNoRadioBtn()
        {
            ClickButton(noRadioBtn);
        }
   
        public static void ClickSubmitBtn()
        {
            ClickButton(submitBtn);
        }

        public static void VerifyRadioButtonsNotPrepopulated()
        {
            Assert.AreEqual(false, WebDriver.FindElement(yesRadioBtn).Selected);
            Assert.AreEqual(false, WebDriver.FindElement(noRadioBtn).Selected);
        }

        public static void VerifyErrorMessage(string ErrorMsg)
        {
            Assert.IsTrue(WebDriver.FindElement(mainErrorMesg).Text.Contains(ErrorMsg));
            Assert.IsTrue(WebDriver.FindElement(subErrorMesg).Text.Contains(ErrorMsg));
        }
    }
}
