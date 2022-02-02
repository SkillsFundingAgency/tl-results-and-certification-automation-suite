using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class RegistrationsWithdrawRegistrationsSuccess : ElementHelper
    {
       
        private static string ExpectedPageUrl => string.Concat(StartPage.StartPageUrl, "registration-withdrawn-confirmation");
        private static By PageHeading = By.XPath("//*[@id='main-content']//h1");
        private static By SubPageHeading = By.XPath("//*[contains(text(),'ULN')]");
        private static string ExpectedSubPageHeading = "ULN: " + Constants.ManualRegUln;
        
        private static By HomeButton = By.Id("dashboardButton");
        private static string ExpectedHomeButtonText = "Home";
        
        private static By ViewRegistrationButton = By.Id("viewWithdrawRegButton");
        private const string ExpectedViewRegistrationButtonText = "View withdrawn registration";
        
        private const string ExpectedRegistrationButtonText = "Register learner on new course";
        private static By RegistrationButton = By.Id("registerNewCourseButton");


        private const string WithdrawnRegSuccessPageTitle = "Registration withdrawn confirmation page – Manage T Level results – GOV.UK";
        private const string WithdrawRegistrationSuccessPageHeading = "Registration withdrawn successfully";

        public static void ClickViewWithdrawnRegistrationButton()
        {
            ClickElement(ViewRegistrationButton);
        }

        public static void ClickRegisterNewCourseButton()
        {
            ClickElement(RegistrationButton);
        }

        public static void ClickHomeButton()
        {
            ClickElement(HomeButton);
        }


        public static void VerifyWithdrawRegSuccessPage_EntryActiveOptionsPage()
        {
            Assert.IsTrue((WebDriver.Url).Contains(ExpectedPageUrl));
            Assert.AreEqual(WithdrawnRegSuccessPageTitle, WebDriver.Title);
            Assert.AreEqual(WithdrawRegistrationSuccessPageHeading, WebDriver.FindElement(PageHeading).Text);
            Assert.AreEqual(ExpectedSubPageHeading, WebDriver.FindElement(SubPageHeading).Text);
            Assert.AreEqual(ExpectedHomeButtonText, WebDriver.FindElement(HomeButton).Text);
            Assert.AreEqual(ExpectedViewRegistrationButtonText, WebDriver.FindElement(ViewRegistrationButton).Text);
        }

        public static void VerifyWithdrawRegSuccessPage_EntryChangeProviderCorePages()
        {
            Assert.IsTrue((WebDriver.Url).Contains(ExpectedPageUrl));
            Assert.AreEqual(WithdrawnRegSuccessPageTitle, WebDriver.Title);
            Assert.AreEqual(WithdrawRegistrationSuccessPageHeading, WebDriver.FindElement(PageHeading).Text);
            Assert.AreEqual(ExpectedSubPageHeading, WebDriver.FindElement(SubPageHeading).Text);
            Assert.AreEqual(ExpectedHomeButtonText, WebDriver.FindElement(HomeButton).Text);
            Assert.AreEqual(ExpectedRegistrationButtonText, WebDriver.FindElement(RegistrationButton).Text);
        }




    }
}
