using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System;
using System.Threading;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    class RegistrationChangeNamePage : ElementHelper
    {


        private const string ExpectedButtonText = "Change";
        private static string ExpectedChangeNamePageUrl => string.Concat(StartPage.StartPageUrl, "change-learners-name");
        private static By PageHeading = By.XPath("//*[text()='Change registration']");
        private static By PageSubHeading = By.XPath("//*[@id='main-content']//h1");
        private static By ChangeButton = By.Id("ChangeButton");
        private static By BackLink = By.Id("backLink");
        private static By FirstName = By.Id("firstname");
        private static By LastName = By.Id("lastname");
        private static string ValidName = "TestName";
        

        //Error Message elements
        private static By ErrorFirstNameNull = By.XPath("//*[text()='Enter first name']");
        private static By ErrorLastNameNull = By.XPath("//*[text()='Enter last name']");
        private static By ErrorFirstNameGreater100Char = By.XPath("//*[text()='First name must be 100 characters or fewer']");
        private static By ErrorLastNameGreater100Char = By.XPath("//*[text()='Last name must be 100 characters or fewer']");
        public static string FirstNameNullErrorMessage = "Enter first name";
        public static string LastNameNullErrorMessage = "Enter last name";
        public static string FirstNameLengthErrorMsg  = "First name must be 100 characters or fewer";
        public static string LastNameLengthErrorMsg = "Last name must be 100 characters or fewer";
        public static string Name101Characters = "ABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJ1";

        public static void VerifyChangeNamePageDetails()
        {
            Assert.IsTrue((WebDriver.Url).Contains(ExpectedChangeNamePageUrl));
            Assert.AreEqual(Constants.RegistrationChangeNamePageTitle, WebDriver.Title);
            Assert.AreEqual(Constants.RegistrationChangeNamePageHeading, WebDriver.FindElement(PageHeading).Text);
            Assert.AreEqual(Constants.RegistrationChangeNamePageSubHeading, WebDriver.FindElement(PageSubHeading).Text);
            Assert.AreEqual(ExpectedButtonText, WebDriver.FindElement(ChangeButton).Text);
        }

        public static void VerifyNameFieldsArePrePopulated()
        {
             Assert.AreEqual(Constants.ManualRegFirstName, WebDriver.FindElement(FirstName).GetAttribute("value"));
             Assert.AreEqual(Constants.ManualRegLastName, WebDriver.FindElement(LastName).GetAttribute("value"));
        }

        public static void ClickBackLink()
        {
            ClickElement(BackLink);
        }

        public static void ClickChangeButton()
        {
            ClickElement(ChangeButton);
        }

        public static void EnterFirstNameOnly()
        {
            WebDriver.FindElement(FirstName).Clear();
            WebDriver.FindElement(LastName).Clear();
            WebDriver.FindElement(FirstName).SendKeys(ValidName);
            ClickElement(ChangeButton);
        }

        public static void AssertFirstNameEmptyErrorMessage()
        {
            Assert.IsTrue(WebDriver.FindElement(ErrorFirstNameNull).Text.Contains(FirstNameNullErrorMessage));
            AssertPageErrorTitle();
        }


        public static void EnterLastNameOnly()
        {
            WebDriver.FindElement(FirstName).Clear();
            WebDriver.FindElement(LastName).Clear();
            WebDriver.FindElement(LastName).SendKeys(ValidName);
            ClickElement(ChangeButton);
        }

        public static void AssertLastNameEmptyErrorMessage()
        {
            Assert.IsTrue(WebDriver.FindElement(ErrorLastNameNull).Text.Contains(LastNameNullErrorMessage));
            AssertPageErrorTitle();
        }

        public static void AssertPageErrorTitle()
        {
            Assert.AreEqual(Constants.RegistrationChangeNameErrorTitle, WebDriver.Title);
        }


        public static void EnterNamesGreaterThan100Characters()
        {
            WebDriver.FindElement(FirstName).Clear();
            WebDriver.FindElement(LastName).Clear();
            WebDriver.FindElement(FirstName).SendKeys(Name101Characters);
            WebDriver.FindElement(LastName).SendKeys(Name101Characters);
            ClickElement(ChangeButton);
        }

        public static void AssertLongNamesErrorMessage()
        {
            Assert.IsTrue(WebDriver.FindElement(ErrorFirstNameGreater100Char).Text.Contains(FirstNameLengthErrorMsg));
            Assert.IsTrue(WebDriver.FindElement(ErrorLastNameGreater100Char).Text.Contains(LastNameLengthErrorMsg));
            AssertPageErrorTitle();
        }

        public static void EnterNullNames()
        {
            WebDriver.FindElement(FirstName).Clear();
            WebDriver.FindElement(LastName).Clear();
            ClickElement(ChangeButton);
        }

        public static void EnterValidNames(string ValidName1, string ValidName2)
        {
            WebDriver.FindElement(FirstName).Clear();
            WebDriver.FindElement(LastName).Clear();
            WebDriver.FindElement(FirstName).SendKeys(ValidName1);
            WebDriver.FindElement(LastName).SendKeys(ValidName2);
            ClickElement(ChangeButton);
        }

        public static void AssertBothNamesEmptyErrorMessages()
        {
            Assert.IsTrue(WebDriver.FindElement(ErrorFirstNameNull).Text.Contains(FirstNameNullErrorMessage));
            Assert.IsTrue(WebDriver.FindElement(ErrorLastNameNull).Text.Contains(LastNameNullErrorMessage));
            AssertPageErrorTitle();
        }

        public static string CapturePageURL()
        {
           return WebDriver.Url;
        }


        public static void NavigateToBookmarkedPage(String URL)
        {
            WebDriver.Navigate().GoToUrl(URL);
        }


        public static void AssertPageNotFoundPageDisplayed()
        {
            Assert.IsTrue(WebDriver.Title.Contains(Constants.PageNotFoundPageTitle));
            
        }


    }
}
