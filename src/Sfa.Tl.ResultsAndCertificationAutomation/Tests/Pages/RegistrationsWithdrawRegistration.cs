using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class RegistrationsWithdrawRegistrations : ElementHelper
    {
       
        private static string ExpectedWithdrawRegistrationPageUrl => string.Concat(StartPage.StartPageUrl, "withdraw-registration");
        private static By PageHeading = By.XPath("//*[@id='main-content']//h1");
        private static By SubPageHeading = By.XPath("//*[@id='withdraw-uln-hint']");
        private static string ExpectedSubPageHeading = "ULN: " + Constants.ManualRegUln;
        private static By SubmitButton = By.Id("submitButton");
        private const string ExpectedSubmitButtonText = "Submit";
        private static By BackLink = By.Id("backLink");
        private const string ExpectedBackLinkText = "Back";
       
        //radio buttons
        private static By YesRadioButton = By.Id("canwithdraw");
        private static By NoRadioButton = By.Id("tl-can-withdraw-no");

        //radio button
        private static By YesRadioButtonLabel = By.XPath("//*[@id='main-content']//div[1]/label");
        private static By NoRadioButtonLabel = By.XPath("//*[@id='main-content']//div[2]/label");
        private const string ExpectedYesRadioButtonText = "Yes, withdraw registration";
        private const string ExpectedNoRadioButtonText = "No, do not withdraw registration";

        //Error Message elements
        private static By ErrorSummaryNoRadioButtonSelected = By.XPath("//*[@id='main-content']//a");
        private static By ErrorNoRadioButtonSelected = By.XPath("//*[text()='Select yes if you want to withdraw this registration']");
        public static string NoRadioButtonSelectedErrorMessage = "Select yes if you want to withdraw this registration";


        public static void ClickSubmitButton()
        {
            ClickElement(SubmitButton);
        }

        public static void WithdrawApplication()
        {
            ClickElement(YesRadioButton);
            ClickElement(SubmitButton);
        }

        public static void DoNotWithdrawApplication()
        {
            ClickElement(NoRadioButton);
            ClickElement(SubmitButton);
        }

        public static void VerifyWithdrawRegistrationPage()
        {
            Assert.IsTrue((WebDriver.Url).Contains(ExpectedWithdrawRegistrationPageUrl));
            Assert.AreEqual(Constants.WithdrawRegistrationPageTitle, WebDriver.Title);
            Assert.AreEqual(Constants.WithdrawRegistrationPageHeading, WebDriver.FindElement(PageHeading).Text);
            Assert.AreEqual(ExpectedSubPageHeading, WebDriver.FindElement(SubPageHeading).Text);
            Assert.AreEqual(ExpectedBackLinkText, WebDriver.FindElement(BackLink).Text);
            Assert.AreEqual(ExpectedSubmitButtonText, WebDriver.FindElement(SubmitButton).Text);
            Assert.AreEqual(ExpectedYesRadioButtonText, WebDriver.FindElement(YesRadioButtonLabel).Text);
            Assert.AreEqual(ExpectedNoRadioButtonText, WebDriver.FindElement(NoRadioButtonLabel).Text);

        }

        public static void VerifyRadioButtonsNotSelected()
        {
            Assert.AreEqual(false, WebDriver.FindElement(YesRadioButtonLabel).Selected);
            Assert.AreEqual(false, WebDriver.FindElement(NoRadioButtonLabel).Selected);
        }

        public static void ErrorMessage_RadioButtonsNotSelected(string ErrorMessage)
        {
            Assert.IsTrue(WebDriver.FindElement(ErrorNoRadioButtonSelected).Text.Contains(ErrorMessage));
            AssertPageErrorTitle();
        }

        public static void ClickBackLink()
        {
            ClickElement(BackLink);
        }

        public static void AssertPageErrorTitle()
        {
            Assert.AreEqual(Constants.WithdrawRegistrationPageErrorTitle, WebDriver.Title);
        }


    }
}
