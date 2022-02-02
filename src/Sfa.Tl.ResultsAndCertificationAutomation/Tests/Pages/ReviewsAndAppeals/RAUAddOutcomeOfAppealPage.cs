using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals
{
    public class RAUAddOutcomeOfAppealPage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "reviews-and-appeals-appeal-outcome-grade");
        private static string pageTitle { get; } = "Add outcome of core appeal – Manage T Level results – GOV.UK";
        private static By pageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static string  PageHeader { get; } = "Add outcome of appeal";
        private static By continueBtn { get; } = By.Id("continueButton");
        private static By backLink { get; } = By.Id("backLink");
        private static By theGradeIsTheSameRadioBtn = By.Id("appealoutcome");
        private static By iNeedToUpdateTheGradeRadioBtn = By.Id("appealoutcome-updategrade");
        private static By withdrawnAppeal { get; } = By.Id("appealoutcome-withdraw");
        private static By learnerDetailsElement = By.XPath("//*[@id='main-content']/div/div/form");
        private static By RadioButtonTextElement = By.ClassName("govuk-fieldset");
        private static By originalGrade = By.XPath("//*[@id='main-content']//div[6]");
        private static By mainErrorMesg = By.ClassName("govuk-error-summary__body");
        private static By subErrorMesg = By.ClassName("govuk-error-message");
        private static By confirmationMgs { get; } = By.XPath("//*[@id='main-content']//h3");
        private static string withdrawnConfirmationTxt = "appeal has been withdrawn";


        public static void VerifyAddOutcomeOfAppealPage()
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
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RaaCoreTitle));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RaaCoreCode));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RaaExamPeriod));
            Assert.IsTrue(WebDriver.FindElement(originalGrade).Text.Contains(Constants.RaaOriginalGrade));
        }

        public static void VerifRadioButtonText()
        {
            Assert.IsTrue(WebDriver.FindElement(RadioButtonTextElement).Text.Contains("No change to the grade"));
            Assert.IsTrue(WebDriver.FindElement(RadioButtonTextElement).Text.Contains("The grade is changed"));
            Assert.IsTrue(WebDriver.FindElement(RadioButtonTextElement).Text.Contains("The appeal is withdrawn"));
        }

        public static void ClickBackLink()
        {
            ClickButton(backLink);
           
        }

        public static void ClickGradeIsSameRadioBtn()
        {
            ClickButton(theGradeIsTheSameRadioBtn);
        }

        public static void ClickINeedToUpdateTheGradeRadioBtn()
        {
            ClickButton(iNeedToUpdateTheGradeRadioBtn);
        }
        public static void ClickWithdrawnAppealRadioBtn()
        {
            ClickButton(withdrawnAppeal);
        }

        public static void ClickContinueBtn()
        {
            ClickButton(continueBtn);
        }

        public static void VerifyRadioButtonsNotPrepopulated()
        {
            Assert.AreEqual(false, WebDriver.FindElement(iNeedToUpdateTheGradeRadioBtn).Selected);
            Assert.AreEqual(false, WebDriver.FindElement(theGradeIsTheSameRadioBtn).Selected);
        }

        public static void VerifyErrorMessage(string ErrorMsg)
        {
            Assert.IsTrue(WebDriver.FindElement(mainErrorMesg).Text.Contains(ErrorMsg));
            Assert.IsTrue(WebDriver.FindElement(subErrorMesg).Text.Contains(ErrorMsg));
        }
        public static void VerifyAppealWithdrawnSuccessMgs()
        {
            Assert.IsTrue(WebDriver.FindElement(confirmationMgs).Text.Contains(withdrawnConfirmationTxt));
        }
    }
}
