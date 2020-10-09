using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using System;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class RegistrationReactivateChangeCorePage : ElementHelper
    {
        private static readonly string ReactivateRegistrationChangeCorePageUrl = string.Concat(StartPage.StartPageUrl, "register-learner-new-course-select-core");
        private const string ReactivateRegistrationChangeCorePageTitle = "Register learner on a new course - Select the core page – Manage T Level results – GOV.UK";
        
        private static readonly string ExpectedPageHeader = "Select the core";
        private const string ExpectedErrorMessage_NoCoreSelected = "Select a core";
        private const string ExpectedErrorPageTitle = "Error: Register learner on a new course - Select the core page – Manage T Level results – GOV.UK";

        private static By BackLink { get; } = By.Id("backLink");
        private const string RegisterLearnerOnNewCourseTxt = "Register learner on a new course";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By PageSubHeader { get; } = By.XPath("//*[@id='main-content']/div/div/form/div/span");
        public static By ContinueBtn { get; } = By.XPath("//*[@id='main-content']/div/div/form/p/button");
        private static readonly string ExpectedButtonText = "Continue";
        public static By DropdownList { get; } = By.Id("selectedcorecode");
        public static By CannotFindACoreLink { get; } = By.XPath("//*[@id='main-content']//summary");
         public static string ExpectedCannotFinaACoreLinkText = "Cannot find a core?";
        //Error Message elements
        public static string ExpectedError_HeadingText = "There is a problem";
        private static By ErrorHeading = By.Id("error-summary-title");

        private static By ErrorNoDropDownValueSelectedMain = By.XPath("//*[@id='main-content']//li/a");
        private static By ErrorNoDropDownValueSelectedLower = By.XPath("//*[@id='main-content']/div/div/form/div[2]/div/span");
       
 



        public static void VerifyRegReactivateChangeCorePageDetails()
        {
            Assert.IsTrue((WebDriver.Url).Contains(ReactivateRegistrationChangeCorePageUrl));
            Assert.AreEqual(ReactivateRegistrationChangeCorePageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(RegisterLearnerOnNewCourseTxt, WebDriver.FindElement(PageSubHeader).Text);
            Assert.AreEqual(ExpectedButtonText, WebDriver.FindElement(ContinueBtn).Text);
            Assert.IsTrue((WebDriver.FindElement(CannotFindACoreLink).Text.Contains(ExpectedCannotFinaACoreLinkText)));
        }


        public static void VerifyDropDownListDefaultValue()
        {
            string expectedDropdownListDefault = "Select one"; 
        
            IWebElement selectElement = WebDriver.FindElement(By.Id("selectedcorecode"));
            SelectElement selectedValue = new SelectElement(selectElement);
            string selectedText = selectedValue.SelectedOption.Text;
            Console.WriteLine(selectedText);

            Assert.AreEqual(expectedDropdownListDefault, selectedText);
        }

        
        public static void VerifyProviderPageDropDownListValue()
        {
            string expectedDropdownListValue = "Automation Test2 (99999902)";

            IWebElement selectElement = WebDriver.FindElement(By.Id("selectedproviderukprn"));
            SelectElement selectedValue = new SelectElement(selectElement);
            string selectedText = selectedValue.SelectedOption.Text;
            Console.WriteLine(selectedText);

            Assert.AreEqual(expectedDropdownListValue, selectedText);
        }

        public static void ClickBackLink()
        {
            ClickElement(BackLink);
        }

        public static void ClickContinueButton()
        {
            ClickElement(ContinueBtn);
        }


        public static void VerifyErrorRegReactivateChangeCorePageDetails(string ErrorMessage)
        {
            Assert.AreEqual(ExpectedError_HeadingText, WebDriver.FindElement(ErrorHeading).Text);
            Assert.IsTrue(WebDriver.FindElement(ErrorNoDropDownValueSelectedMain).Text.Contains(ErrorMessage));
            Assert.IsTrue(WebDriver.FindElement(ErrorNoDropDownValueSelectedLower).Text.Contains(ErrorMessage));
            AssertPageErrorTitle();
        }

        public static void AssertPageErrorTitle()
        {
            Assert.AreEqual(ExpectedErrorPageTitle, WebDriver.Title);
        }









    }
}
