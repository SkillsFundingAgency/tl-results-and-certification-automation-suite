using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System.Threading;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class RegistrationsWithdrawOptionsPage : ElementHelper
    {

        //amend-withdrawn-registration page elements
        private static string ExpectedAmendWithdrawnRegistrationPageUrl => string.Concat(StartPage.StartPageUrl, "amend-withdrawn-registration");
        private static By AmendWithdrawnRegistrationPageHeading = By.XPath("//*[@id='main-content']//h1");

        private static By ContinueButton = By.Id("continueButton");
        private const string ExpectedContinueButtonText = "Continue";
        
        private static By BackLink = By.Id("backLink");
        private const string ExpectedBackLinkText = "Back";

        ////radio buttons
        private static By ReactivateRadioButton = By.Id("changestatus");
        private static By RegisterLearnerRadioButton = By.Id("tl-change-status-no");
        private static By ReactivateRadioButtonLabel = By.XPath("//*[@id='main-content']//div[1]/label");
        private static By RegisterLearnerRadioButtonLabel = By.XPath("//*[@id='main-content']//div[2]/label");
        private const string ExpectedReactivateLabelText = "Reactivate this registration with the same course";
        private const string ExpectedRegisterLabelText = "Register learner on a different course";

        //Error Message elements
        public static string ErrorHeadingText = "There is a problem";
        private static By ErrorHeading = By.XPath("//*[@id='main-content']//h2");
        private static By ErrorSummaryNoRadioButtonSelected = By.XPath("//*[@id='main-content']//a");
        private static By ErrorNoRadioButtonSelected = By.XPath("//*[text()='Select if you would like to reactivate this registration with the same course or register a different course']");
        public static string ExpectedError_NoRadioButtonSelected = "Select if you would like to reactivate this registration with the same course or register a different course";
        public static string ExpectedError_Heading = "There is a problem";


        public static void ClickContinueButton()
        {
            ClickElement(ContinueButton);
        }

        public static void ClickReactiveRegistrationRadioButton()
        {
            ClickElement(ReactivateRadioButton);
        }

        public static void ClickRegisterLearnerNewCourseRadioButton()
        {

            ClickElement(RegisterLearnerRadioButtonLabel);
        }

        public static void VerifyRegistrationsWithdrawOptionsPage()
        {
            Assert.IsTrue((WebDriver.Url).Contains(ExpectedAmendWithdrawnRegistrationPageUrl));
            Assert.AreEqual(Constants.WithdrawnRegOptionsPageTitle, WebDriver.Title);
            Assert.AreEqual(Constants.WithdrawnRegOptionsPageHeading, WebDriver.FindElement(AmendWithdrawnRegistrationPageHeading).Text);
            Assert.AreEqual(ExpectedContinueButtonText, WebDriver.FindElement(ContinueButton).Text);
            Assert.AreEqual(ExpectedReactivateLabelText, WebDriver.FindElement(ReactivateRadioButtonLabel).Text);
            Assert.AreEqual(ExpectedRegisterLabelText, WebDriver.FindElement(RegisterLearnerRadioButtonLabel).Text);
        }

        public static void  VerifyRadioButtonsNotSelected()
        {
            Assert.AreEqual(false, WebDriver.FindElement(ReactivateRadioButton).Selected);
            Assert.AreEqual(false, WebDriver.FindElement(RegisterLearnerRadioButton).Selected);
        }


        public static void VerifyErrorMessage_RadioButtonsNotSelected(string ErrorMessage)
        {
            Assert.IsTrue(WebDriver.FindElement(ErrorHeading).Text.Contains(ErrorHeadingText));
            Assert.IsTrue(WebDriver.FindElement(ErrorSummaryNoRadioButtonSelected).Text.Contains(ErrorMessage));
            Assert.IsTrue(WebDriver.FindElement(ErrorNoRadioButtonSelected).Text.Contains(ErrorMessage));
            AssertPageErrorTitle();
        }

        public static void ClickBackLink()
        {
            ClickElement(BackLink);
        }

        public static void AssertPageErrorTitle()
        {
            Assert.AreEqual(Constants.WithdrawnRegOptionsPageErrorTitle, WebDriver.Title);
        }


    }
}
