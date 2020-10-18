using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class RegistrationDeletePage : ElementHelper
    {
        private static readonly string AmendActivePageUrl = string.Concat(StartPage.StartPageUrl, "amend-active-registration");
        private const string AmendActivePageTitle = "What would you like to do with this active registration page – Manage T Level results – GOV.UK";
        private static readonly string AmendActivePageHeader = "What would you like to do with this active registration?";
        private static By ChangeStatusLink { get; } = By.Id("learnerstatus");
        public static By DeleteRadioBtn { get; } = By.Id("tl-change-status-no");
        public static By ContinueBtn { get; } = By.Id("continueButton");
        public static By DeleteYesRadio { get; } = By.Id("deleteregistration");
        public static By DeleteNoRadio { get; } = By.Id("cancel-registration-no");
        public static By SubmitBtn { get; } = By.Id("submitButton");
        private static string DeleteRegCheckPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "delete-registration");
        private const string DeleteRegCheckPageTitle = "Delete registration page – Manage T Level results – GOV.UK";
        private static readonly string DeleteRegCheckPageHeader = "Are you sure you want to delete this registration permanently?";
        private const string DeleteRegCheckErrorPageTitle = "Error: Delete registration page – Manage T Level results – GOV.UK";
        private static By DeleteErrorPageId { get; } = By.XPath("//a[@href='#deleteregistration']");
        private const string DeleteErrorPageMsg = "Select yes if you want to delete this registration";
        private const string DeleteRegSuccessMsg = "Registration deleted successfully";
        private static string DeleteRegSuccessUrl { get; } = string.Concat(StartPage.StartPageUrl, "registration-deleted-confirmation");
        private static string DeleteRegSuccessPageTitle = "Registration deleted confirmation page – Manage T Level results – GOV.UK";
        public static By SearchAnotherRegBtn { get; } = By.XPath("//a[contains(text(),'Search for another registration')]");
        public static By BackToRegBtn { get; } = By.XPath("//a[contains(text(),'Back to registrations')]");
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        public static void VerifyDeleteRegCheckPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(DeleteRegCheckPageUrl));
            Assert.AreEqual(DeleteRegCheckPageTitle, WebDriver.Title);
            Assert.AreEqual(DeleteRegCheckPageHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyDeleteRegCheckErrorPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(DeleteRegCheckPageUrl));
            Assert.AreEqual(DeleteRegCheckErrorPageTitle, WebDriver.Title);
            Assert.AreEqual(DeleteRegCheckPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(DeleteErrorPageMsg, WebDriver.FindElement(DeleteErrorPageId).Text);
        }

        public static void VerifyDeleteConfirmationPage()
        {
            Assert.AreEqual(DeleteRegSuccessUrl, WebDriver.Url);
            Assert.AreEqual(DeleteRegSuccessPageTitle, WebDriver.Title);
            Assert.AreEqual(DeleteRegSuccessMsg, WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyAmendActiveRegPage()
        {
            Assert.AreEqual(AmendActivePageTitle, WebDriver.Title);
            Assert.AreEqual(AmendActivePageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(AmendActivePageUrl));
        }
    }
}
