using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals
{
    public class RAUCancelAppealUpdatePage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "reviews-and-appeals-cancel-appeal-update");
        private static string pageTitle { get; } = "Cancel appeal update – Manage T Level results – GOV.UK";
        private static By pageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static string  pageHeader { get; } = "Are you sure you want to cancel the update to this appeal?";
        private static By continueBtn { get; } = By.Id("continueButton");
        private static By radioButtonsElement { get; } = By.XPath("//*[@id='main-content']//form");
        private static By backLink = By.Id("backLink");
       
        private static By yesRadioBtn = By.Id("cancelrequest");
        private static By noRadioBtn = By.Id("cancelrequest-no");
        private static By mainErrorMesg = By.ClassName("govuk-error-summary__body");
        private static By subErrorMesg = By.ClassName("govuk-error-message");
     

        public static void VerifyRAUCancelAppealUpdatePage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(pageTitle, WebDriver.Title);
            Assert.AreEqual(WebDriver.FindElement(pageHeaderElement).Text, pageHeader);
            Assert.IsTrue(WebDriver.FindElement(radioButtonsElement).Text.Contains("Yes, I want to cancel"));
            Assert.IsTrue(WebDriver.FindElement(radioButtonsElement).Text.Contains("No, I do not want to cancel"));
        }



        public static void VerifyErrorMessage(string ErrorMsg)
        {
            Assert.IsTrue(WebDriver.FindElement(mainErrorMesg).Text.Contains(ErrorMsg));
            Assert.IsTrue(WebDriver.FindElement(subErrorMesg).Text.Contains(ErrorMsg));
        }

        public static void ClickContinueBtn()
        {
            ClickButton(continueBtn);
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

        public static void ClickNoRadioBtn()
        {
            ClickButton(noRadioBtn);
        }
    }
}
