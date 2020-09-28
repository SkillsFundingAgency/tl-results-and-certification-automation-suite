using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class RegistrationsActiveOptionPage : ElementHelper
    {
       
       
        private static string ExpectedAmendActiveRegistrationPageUrl => string.Concat(StartPage.StartPageUrl, "amend-active-registration");
        private static By PageHeading = By.XPath("//*[@id='main-content']//h1");
        private static By ContinueButton = By.Id("continueButton");
        private const string ExpectedContinueButtonText = "Continue";
        private static By BackLink = By.Id("backLink");
        private const string ExpectedBackLinkText = "Back";

        //radio buttons elements
        private static By WithdrawRadioButton = By.Id("changestatus");
        private static By DeleteRadioButton = By.Id("tl-change-status-no");
        private static By WithdrawRegistrationLabel = By.XPath("//*[text()='Withdraw this registration']");
        private static By WithdrawRegistrationSubLabel = By.XPath("//*[text()='Remove the learner from the course for now but do not delete the registration permanently']");
        private static By DeleteRegistrationLabel = By.XPath("//*[text()='Delete this registration permanently']");
        private const string ExpectedWithdrawRadioButtonText = "Withdraw this registration";
        private const string ExpectedWithdrawRadioButtonSubText = "Remove the learner from the course for now but do not delete the registration permanently";
        private const string ExpectedDeleteRadioButtonText = "Delete this registration permanently";

        //Error Message elements
        private static By ErrorNoRadioButtonSelected = By.XPath("//*[text()='Select if you want to withdraw or delete this registration']");
        //  public static string NoRadioButtonSelectedErrorMessage = "Select if you want to withdraw or delete this registration";
       

        public static void ClickContinueButton()
        {
            ClickElement(ContinueButton);
        }

        public static void VerifyAmendActiveRegistrationPage()
        {
            Assert.IsTrue((WebDriver.Url).Contains(ExpectedAmendActiveRegistrationPageUrl));
            Assert.AreEqual(Constants.AmendActiveRegistrationPageTitle, WebDriver.Title);
            Assert.AreEqual(Constants.AmendActiveRegistrationPageHeading, WebDriver.FindElement(PageHeading).Text);
            Assert.AreEqual(ExpectedBackLinkText, WebDriver.FindElement(BackLink).Text);
            //Check radio button labels
            Assert.AreEqual(ExpectedWithdrawRadioButtonText, WebDriver.FindElement(WithdrawRegistrationLabel).Text);
            Assert.AreEqual(ExpectedWithdrawRadioButtonSubText, WebDriver.FindElement(WithdrawRegistrationSubLabel).Text);
            Assert.AreEqual(ExpectedDeleteRadioButtonText, WebDriver.FindElement(DeleteRegistrationLabel).Text);
            //Check Continue button text
            Assert.AreEqual(ExpectedContinueButtonText, WebDriver.FindElement(ContinueButton).Text);

        }

        public static void VerifyRadioButtonsNotSelected()
        {
            Assert.AreEqual(false, WebDriver.FindElement(WithdrawRadioButton).Selected);
            Assert.AreEqual(false, WebDriver.FindElement(DeleteRadioButton).Selected);
        }

        public static void ClickBackLink()
        {
            ClickElement(BackLink);
        }

        public static void ClickWithdrawRadioButton()
        {
            ClickElement(WithdrawRadioButton);
        }

        public static void AssertErrorMessage(string ExpectedErrorMessage)
        {
            Assert.IsTrue(WebDriver.FindElement(ErrorNoRadioButtonSelected).Text.Contains(ExpectedErrorMessage));
            AssertPageErrorTitle();
        }

        public static void AssertPageErrorTitle()
        {
            Assert.AreEqual(Constants.RegistrationsActiveOptionsPageErrorTitle, WebDriver.Title);
        }


    }
}
