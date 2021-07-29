using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Registrations
{
    public class CannotWithdrawRegistrationPage : ElementHelper
    {
        private static string pageTitle { get; } = "Registration cannot be withdrawn – Manage T Level results – GOV.UK";
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "registration-cannot-be-withdrawn");
        private static By pageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static string pageHeader { get; } = "You cannot withdraw this registration";
        private static By backLink { get; } = By.Id("backLink");
        private static By backToDetailsBtn { get; } = By.Id("buttonBackToRegistrationDetails");
        private static By backToHomeBtn { get; } = By.Id("buttonBackToHome");
        private static By continueBtn { get; } = By.Id("continueButton");
        public static void VerifyCannotWithdrawPage()
        {
            Assert.AreEqual(pageUrl, WebDriver.Url);
            Assert.AreEqual(pageTitle, WebDriver.Title);
            Assert.AreEqual(pageHeader, WebDriver.FindElement(pageHeaderElement).Text);
        }
        public static void CheckBackLink()
        {
            ClickElement(backLink);
            Assert.IsTrue(WebDriver.Url.Contains("amend-active-registration"));
            Assert.AreEqual(true,WebDriver.FindElement(By.Id("changestatus")).Selected);
        }
        public static void ClickContunue()
        {
            ClickButton(continueBtn);
        }
        public static void CheckBackToRegDetails()
        {
            ClickButton(backToDetailsBtn);
            Assert.IsTrue(WebDriver.Url.Contains("search-for-registration-registration-details"));
            Assert.IsTrue(WebDriver.Title.Equals("Search for a registration - Registration details page – Manage T Level results – GOV.UK"));
        }
        public static void CheckBackToHome()
        {
            ClickButton(backToHomeBtn);
            Assert.IsTrue(WebDriver.Title.Equals("Home page – Manage T Level results – GOV.UK"));
            Assert.IsTrue(WebDriver.Url.Contains("home"));
        }
    }
}
