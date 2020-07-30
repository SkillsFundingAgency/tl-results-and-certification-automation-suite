using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class RegistrationsManualPage : ElementHelper
    {
        private static By PageHeader { get; } = By.TagName("h1");
        private static readonly By BackLink = By.Id("backLink");
        private static By ContinueBtn { get; } = By.XPath("//button[contains(text(),'Continue')]");
        private static By SubmitBtn { get; } = By.XPath("//button[contains(text(),'Submit')]");
        private static By AddRegistrationLink { get; } = By.XPath("//a[contains(text(),'Add a new registration')]");
        // ULN Page
        private static string UlnUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-registration-unique-learner-number");
        private static By UlnInput { get; } = By.Id("uln");
        private static readonly string UlnPageHeader = "Enter the Unique Learner Number (ULN)";
        //Learner Name Page
        private static string LearnerNameUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-registration-learners-name");
        private static readonly string LearnerPageHeader = "Enter the learner's name";
        private static By FirstName { get; } = By.Id("firstname");
        private static By LastName { get; } = By.Id("lastname");
        //DOB Page
        private static string DobPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-registration-date-of-birth");
        private static readonly string DobPageHeader = "Enter the learner's date of birth";
        private static By Day { get; } = By.Name("Day");
        private static By Month { get; } = By.Name("Month");
        private static By Year { get; } = By.Name("Year");
        //Select Provider Page
        private static string ProviderPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-registration-provider");
        private static readonly string ProviderHeader = "Select the provider";
        private static By SelectProvider { get; } = By.Id("selectedproviderukprn");
        public const string InputPovider = "Automation Test2 (90000002)";
        public const string InputPearsonPovider = "Automation Test3 (90000003)";
        //Select Core Page
        private static string CorePageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-registration-core");
        private static readonly string CoreHeader = "Select the core";
        private static By SelectCore { get; } = By.Id("selectedcorecode");
        public const string InputCore = "Legal, Finance and Accounting (55555555)";
        public const string InputPearsonCore = "Creative and Design (10101010)";
        //Specialism Page
        private static string SpecialismDecidePageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-registration-learner-decided-specialism-question");
        private static readonly string SpecialismDecideHeader = "Has the learner decided on the specialism?";
        public static By DecideYes { get; } = By.Id("haslearnerdecidedspecialism");
        public static By DecideNo { get; } = By.Id("specialismdecided-no");
        private static string SpecialismSelectPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-registration-specialism");
        public static By SelectSpecialismLegal = By.XPath("//label[contains(text(),'Legal')]");
        public static By SelectSpecialismAgg = By.XPath("//label[contains(text(),'Agriculture, Land')]");
        private static string AcademicYearPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-registration-academic-year");
        private static string RegistrationSummaryPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-registration-check-and-submit");
        private static readonly string SummaryPageHeader = "Check and submit";
        private static readonly string RegistrationSuccessHeader = "Registration successful";
        private static string RegistrationSuccessPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-registration-confirmation");
        private static readonly By ViewULNDetails = By.XPath("//a[contains(text(),'View this ULN')]");
        private static string UlnRegSameAOUrl { get; } = string.Concat(StartPage.StartPageUrl, "ULN-cannot-be-registered"); 

        public static void AddNewRegistrations()
        {
            ClickElement(AddRegistrationLink);
        }
        public static void ClickContiune()
        {
            ClickElement(ContinueBtn);
        }
        public static void ClickSubmit()
        {
            ClickElement(SubmitBtn);
        }
        public static void ClickBackLink()
        {
            WebDriver.FindElement(BackLink).Click();
        }
        public static void ViewUlnDetails()
        {
            ClickElement(ViewULNDetails);
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
        public static void VerifySpecialismPage()
        {
            Assert.AreEqual(SpecialismSelectPageUrl, WebDriver.Url);
            Assert.AreEqual(Constants.SelectSpecialismTitle, WebDriver.Title);
        }
        public static void VerifyAcademicYearPage()
        {
            Assert.AreEqual(AcademicYearPageUrl, WebDriver.Url);
            Assert.AreEqual(Constants.SelectAcademicYearTitle, WebDriver.Title);
        }
        public static void VerifyRegistrationSummaryPage()
        {
            Assert.AreEqual(RegistrationSummaryPageUrl, WebDriver.Url);
            Assert.AreEqual(Constants.ManualRegSummaryTitle, WebDriver.Title);
            Assert.AreEqual(SummaryPageHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyRegistrationSuccessPage()
        {
            Assert.AreEqual(RegistrationSuccessPageUrl, WebDriver.Url);
            Assert.AreEqual(Constants.ReggistrationSuccessTitle, WebDriver.Title);
            Assert.AreEqual(RegistrationSuccessHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyULNRegWithSameAo()
        {
            Assert.AreEqual(UlnRegSameAOUrl, WebDriver.Url);
            Assert.AreEqual(Constants.UlnRegisteredWithSameAOTitle, WebDriver.Title);
            Assert.AreEqual(Constants.UlnRegisteredWithSameAOHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyULNRegWithAnotherAo()
        {
            Assert.AreEqual(UlnRegSameAOUrl, WebDriver.Url);
            Assert.AreEqual(Constants.UlnRegisteredWithAnotherAOTitle, WebDriver.Title);
            Assert.AreEqual(Constants.UlnRegisteredWithAnotherAOHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public static void SelectProviderFromList(string provider)
        {
            SelectFromDropDownByText(SelectProvider, provider);
        }
        public static void EnterUln(string uln)
        {
            WebDriver.FindElement(UlnInput).SendKeys(uln);
        }
        public static void EnterLearnerName(string First, string Last)
        {
            WebDriver.FindElement(FirstName).SendKeys(First);
            WebDriver.FindElement(LastName).SendKeys(Last);
        }
        public static void EnterDob(string day, string month,string year)
        {
            WebDriver.FindElement(Day).SendKeys(day);
            WebDriver.FindElement(Month).SendKeys(month);
            WebDriver.FindElement(Year).SendKeys(year);
        }
        public static void SelectCoreFromList(string coreName)
        {
            SelectFromDropDownByText(SelectCore, coreName);
        }
    }
}
