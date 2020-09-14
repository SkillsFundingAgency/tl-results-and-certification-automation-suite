using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System;
using System.Threading;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    class RegistrationChangeDOBPage : ElementHelper
    {


        private const string ExpectedButtonText = "Change";
        private static string ExpectedChangeNamePageUrl => string.Concat(StartPage.StartPageUrl, "change-learners-date-of-birth");
        private static By PageHeading = By.XPath("//*[text()='Change registration']");
        private static By PageSubHeading = By.XPath("//*[@id='main-content']//h1");
        private static By ChangeButton = By.Id("ChangeButton");
        private static By BackLink = By.Id("backLink");
        private static By Day = By.Id("day");
        private static By Month = By.Id("month");
        private static By Year = By.Id("year");
        private static string ValidName = "year";
        

        //Error Message elements
        private static By ErrorMessage = By.XPath("//*[@class='govuk-list govuk-error-summary__list']");
        public static string ErrorMessageAllDOBFieldsNull = "Enter your date of birth";
        public static string ErrorMessageOnlyDayFieldPopulated = "Date of birth must include a month and year";
        public static string ErrorMessageOnlyMonthFieldPopulated = "Date of birth must include a day and year";

        public static void VerifyChangeDOBPageDetails()
        {
            Assert.IsTrue((WebDriver.Url).Contains(ExpectedChangeNamePageUrl));
            Assert.AreEqual(Constants.RegistrationChangeDOBPageTitle, WebDriver.Title);
            Assert.AreEqual(Constants.RegistrationChangeDOBPageHeading, WebDriver.FindElement(PageHeading).Text);
            Assert.AreEqual(Constants.RegistrationChangeDOBPageSubHeading, WebDriver.FindElement(PageSubHeading).Text);
            Assert.AreEqual(ExpectedButtonText, WebDriver.FindElement(ChangeButton).Text);
        }

        public static void ClickBackLink()
        {
            ClickElement(BackLink);
        }

        public static void ClickChangeButton()
        {
            ClickElement(ChangeButton);
        }


        public static void EnterDayOnly()
        {
            WebDriver.FindElement(Day).Clear();
            WebDriver.FindElement(Month).Clear();
            WebDriver.FindElement(Year).Clear();
            WebDriver.FindElement(Day).SendKeys("02");
            ClickElement(ChangeButton);
        }

        public static void AssertErrorMessage(string ExpectedErrorMessage)
        {
            Assert.IsTrue(WebDriver.FindElement(ErrorMessage).Text.Contains(ExpectedErrorMessage));
            AssertPageErrorTitle();
        }

        public static void EnterMonthOnly()
        {
            WebDriver.FindElement(Day).Clear();
            WebDriver.FindElement(Month).Clear();
            WebDriver.FindElement(Year).Clear();
            WebDriver.FindElement(Month).SendKeys("02");
            ClickElement(ChangeButton);
        }

        public static void EnterYearOnly()
        {
            WebDriver.FindElement(Day).Clear();
            WebDriver.FindElement(Month).Clear();
            WebDriver.FindElement(Year).Clear();
            WebDriver.FindElement(Year).SendKeys("2000");
            ClickElement(ChangeButton);
        }

        public static void EnterDayAndMonthOnly()
        {
            WebDriver.FindElement(Day).Clear();
            WebDriver.FindElement(Month).Clear();
            WebDriver.FindElement(Year).Clear();
            WebDriver.FindElement(Day).SendKeys("2");
            WebDriver.FindElement(Month).SendKeys("2");
            ClickElement(ChangeButton);
        }


        public static void EnterMonthAndYearOnly()
        {
            WebDriver.FindElement(Day).Clear();
            WebDriver.FindElement(Month).Clear();
            WebDriver.FindElement(Year).Clear();
            WebDriver.FindElement(Month).SendKeys("12");
            WebDriver.FindElement(Year).SendKeys("2000");
            ClickElement(ChangeButton);
        }

        public static void EnterDayAndYearOnly()
        {
            WebDriver.FindElement(Day).Clear();
            WebDriver.FindElement(Month).Clear();
            WebDriver.FindElement(Year).Clear();
            WebDriver.FindElement(Day).SendKeys("12");
            WebDriver.FindElement(Year).SendKeys("2000");
            ClickElement(ChangeButton);
        }

        public static void EnterInvalidDate()
        {
            WebDriver.FindElement(Day).Clear();
            WebDriver.FindElement(Month).Clear();
            WebDriver.FindElement(Year).Clear();
            WebDriver.FindElement(Day).SendKeys("32");
            WebDriver.FindElement(Month).SendKeys("12");
            WebDriver.FindElement(Year).SendKeys("2000");
            ClickElement(ChangeButton);
        }

        public static void EnterFutureDatedDOB()
        {
            WebDriver.FindElement(Day).Clear();
            WebDriver.FindElement(Month).Clear();
            WebDriver.FindElement(Year).Clear();
            WebDriver.FindElement(Day).SendKeys("01");
            WebDriver.FindElement(Month).SendKeys("1");
            WebDriver.FindElement(Year).SendKeys("2090");
            ClickElement(ChangeButton);
        }

        public static void EnterValidDOB(string DD, string MM, string YYYY)
        {
            WebDriver.FindElement(Day).Clear();
            WebDriver.FindElement(Month).Clear();
            WebDriver.FindElement(Year).Clear();
            WebDriver.FindElement(Day).SendKeys(DD);
            WebDriver.FindElement(Month).SendKeys(MM);
            WebDriver.FindElement(Year).SendKeys(YYYY);
            ClickElement(ChangeButton);
        }


        public static void AssertPageErrorTitle()
        {
            Assert.AreEqual(Constants.RegistrationChangeDOBErrorTitle, WebDriver.Title);
        }


        public static void EnterNullDOBFields()
        {
            WebDriver.FindElement(Day).Clear();
            WebDriver.FindElement(Month).Clear();
            WebDriver.FindElement(Year).Clear();
            ClickElement(ChangeButton);
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

        public static void VerifyDOBFieldsArePrePopulated()
        {
            Assert.AreEqual(Constants.ManualRegDOBDay, WebDriver.FindElement(Day).GetAttribute("value"));
            Assert.AreEqual(Constants.ManualRegDOBMonth, WebDriver.FindElement(Month).GetAttribute("value"));
            Assert.AreEqual(Constants.ManualRegDOBYear, WebDriver.FindElement(Year).GetAttribute("value"));
        }
    }
}
