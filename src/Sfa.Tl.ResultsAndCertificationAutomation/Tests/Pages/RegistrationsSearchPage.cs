using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class RegistrationsSearchPage : ElementHelper
    {
        private static readonly string SearchPageUrl = string.Concat(StartPage.StartPageUrl, "search-for-registration");
        private static readonly string SearchNotFoundUrl = string.Concat(StartPage.StartPageUrl, "search-for-registration-ULN-not-found");
        private static readonly string SearchResultUrl = string.Concat(StartPage.StartPageUrl, "search-for-registration-registration-details");
        private static readonly string CancelRegUrl = string.Concat(StartPage.StartPageUrl, "cancel-registration");
        private static readonly string CancelRegSuccessUrl = string.Concat(StartPage.StartPageUrl, "registration-cancelled-confirmation");
        public static readonly By SearchRegistrationLink = By.XPath("//a[contains(text(),'Search for a registration')]");
        public static readonly By SearchBox = By.Id("searchuln");
        public static readonly By SearchBtn = By.XPath("//button[contains(text(),'Search')]");
        private static readonly By BackToSearchBtn = By.XPath("//a[contains(text(),'Back to search')]");
        private static readonly By SearchAgainBtn = By.XPath("//a[contains(text(),'Search again')]");
        private static readonly By CancelRegBtn = By.XPath("//a[contains(text(),'Cancel this registration')]");
        private static readonly By BackLink = By.Id("backLink");
        private static readonly By CancelRegYes = By.Id("cancelregistration");
        private static readonly By CancelRegNo = By.Id("cancel-registration-no");
        private static readonly By SubmitBtn = By.XPath("//button[contains(text(),'Submit')]");
        private static readonly By SearchAnotherRegBtn = By.XPath("//a[contains(text(),'Search for another registration')]");
        private static readonly By BackToRegBtn = By.XPath("//a[contains(text(),'Back to registration')]");
        private static By PageHeader { get; } = By.TagName("h1");
        public static void ClickButton(By locator)
        {
            WebDriver.FindElement((locator)).Click();
        }
        public static void VerifySearchResultPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(SearchResultUrl));
            Assert.AreEqual(Constants.SearchDetailsTitle, WebDriver.Title);
            Assert.AreEqual(Constants.SearchDetailsHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public static void verifyName(string name) 
        {
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(name));
        }
        public static void verifyDob(string Dob)
        {
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(Dob));
        }
        public static void verifyProvider(string Provider)
        {
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(Provider));
        }
        public static void verifyCore(string Core)
        {
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(Core));
        }
        public static void verifySpecialism(string Specialism)
        {
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(Specialism));
        }
    }
}
