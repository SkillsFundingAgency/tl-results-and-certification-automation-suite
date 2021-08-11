using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals
{
    public class RAUCancelSelectRequestGradeChangePage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "cancel-grade-change-request");
        private static string pageTitle { get; } = "Cancel grade change request – Manage T Level results – GOV.UK";
        private static By pageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static string PageHeader { get; } = "Are you sure you want to cancel the request for a grade change?";
        private static By continueBtn { get; } = By.Id("continueButton");
        private static By backLink = By.Id("backLink");
        private static By mainErrorMesg = By.ClassName("govuk-error-summary__body");
        private static By subErrorMesg = By.ClassName("govuk-error-message");
        private static By yesRadioBtn { get; } = By.Id("areyousuretocancel");
        private static By noRadioBtn { get; } = By.Id("areyousuretocancel-no");


        public static void VerifyCancelSelectRequestGradeChangePage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(pageTitle, WebDriver.Title);
            Assert.AreEqual(PageHeader, WebDriver.FindElement(pageHeaderElement).Text);
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
            Assert.AreEqual(false, WebDriver.FindElement(yesRadioBtn).Selected);
            Assert.AreEqual(false, WebDriver.FindElement(noRadioBtn).Selected);
        }

        public static void VerifyErrorMessage(string ErrorMsg)
        {
            Assert.IsTrue(WebDriver.FindElement(mainErrorMesg).Text.Contains(ErrorMsg));
            Assert.IsTrue(WebDriver.FindElement(subErrorMesg).Text.Contains(ErrorMsg));
        }


        public static void ClickYesRadioButton()
        {
            ClickButton(yesRadioBtn);
        }

        public static void ClickNoRadioButton()
        {
            ClickButton(noRadioBtn);
        }
    }
}
