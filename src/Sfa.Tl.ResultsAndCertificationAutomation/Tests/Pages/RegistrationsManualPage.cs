using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class RegistrationsManualPage : ElementHelper
    {
        private static By PageHeader { get; } = By.TagName("h1");
        private static readonly By BackLink = By.Id("backLink");
        private static By ContinueBtn { get; } = By.XPath("//button[contains(text(),'Continue')]");
        private static By AddRegistrationLink { get; } = By.XPath("//a[contains(text(),'Add a new registration')]");
        // ULN Page
        private static string UlnUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-registration-unique-learner-number");
        private static By UlnInput { get; } = By.Id("uln");
        private static readonly string UlnPageHeader = "Enter the Unique Learner Number (ULN)";
        public const string UlnNo = "9700000001";
        //Learner Name Page
        private static string LearnerNameUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-registration-learners-name");
        private static readonly string LearnerPageHeader = "Enter the learner's name";
        private static By FirstName { get; } = By.Id("firstname");
        private static By LastName { get; } = By.Id("lastname");
        private const string InputFirstName = "FirstName1";
        private const string InputLastName = "LastName1";
        //DOB Page
        private static string DobPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-registration-date-of-birth");
        private static readonly string DobPageHeader = "Enter the learner's date of birth";
        private static By Day { get; } = By.Id("day");
        private static By Month { get; } = By.Id("month");
        private static By Year { get; } = By.Id("year");
        private const string InputDay = "1";
        private const string InputMonth = "1";
        private const string InputYear = "2010";

        //Select Provider Page
        private static string ProviderPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-registration-provider");
        private static readonly string ProviderHeader = "Select the provider";
        private static By SelectProvider { get; } = By.Id("selectedproviderid");
        private const string InputPovider = "Automation Test2(90000002)";
        //Select Core Page
        private static string CorePageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-registration-core");
        private static readonly string CoreHeader = "Select the core";
        private static By SelectCore { get; } = By.Id("selectedcoreid");
        private const string InputCore = "Legal, Finance and Accounting(55555555)";
        //Specialism Page
        private static string SpecialismDecidePageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-registration-learner-decided-specialism-question");
        private static readonly string SpecialismDecideHeader = "Has the learner decided on the specialism?";
        private static By DecideYes { get; } = By.Id("haslearnerdecidedspecialism");
        private static By DecideNo { get; } = By.Id("specialismdecided-no");

        public static void AddNewRegistrations()
        {
            ClickElement(AddRegistrationLink);
        }
        public static void ClickContiune()
        {
            ClickElement(ContinueBtn);
        }
        public static void ClickBackLink()
        {
            WebDriver.FindElement(BackLink).Click();
        }
        public static void VerifyUlnPage()
        {
            Assert.AreEqual(UlnUrl, WebDriver.Url);
            Assert.AreEqual(Constants.UlnPageTitle, WebDriver.Title);
            Assert.AreEqual(UlnPageHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyLearnersPage()
        {
            Assert.AreEqual(LearnerNameUrl, WebDriver.Url);
            Assert.AreEqual(Constants.LearnerPageTitle, WebDriver.Title);
            Assert.AreEqual(LearnerPageHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyDobPage()
        {
            Assert.AreEqual(DobPageUrl, WebDriver.Url);
            Assert.AreEqual(Constants.DobPageTitle, WebDriver.Title);
            Assert.AreEqual(DobPageHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyProviderPage()
        {
            Assert.AreEqual(ProviderPageUrl, WebDriver.Url);
            Assert.AreEqual(Constants.SelectProviderTitle, WebDriver.Title);
            Assert.AreEqual(ProviderHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyCorePage()
        {
            Assert.AreEqual(CorePageUrl, WebDriver.Url);
            Assert.AreEqual(Constants.SelectCoreTitle, WebDriver.Title);
            Assert.AreEqual(CoreHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifySpecialismDecidePage()
        {
            Assert.AreEqual(SpecialismDecidePageUrl, WebDriver.Url);
            Assert.AreEqual(Constants.SpecialismDecideTitle, WebDriver.Title);
            Assert.AreEqual(SpecialismDecideHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public static void SelectProviderFromList(string provider)
        {
            IWebElement providerSelect = WebDriver.FindElement(By.Id("selectedproviderid"));
            SelectElement selectElement = new SelectElement(providerSelect);
            selectElement.SelectByText(provider);
        }
        public static void EnterUln()
        {
            WebDriver.FindElement(UlnInput).SendKeys(UlnNo);
        }
        public static void EnterLearnerName()
        {
            WebDriver.FindElement(FirstName).SendKeys(InputFirstName);
            WebDriver.FindElement(LastName).SendKeys(InputLastName);
        }
        public static void EnterDob()
        {
            WebDriver.FindElement(Day).SendKeys(InputDay);
            WebDriver.FindElement(Month).SendKeys(InputMonth);
            WebDriver.FindElement(Year).SendKeys(InputYear);
        }
        public static void SelectCoreFromList(string coreName)
        {
            IWebElement coreSelect = WebDriver.FindElement(SelectProvider);
            SelectElement selectElement = new SelectElement(coreSelect);
            selectElement.SelectByText(coreName);
        }
    }
}
