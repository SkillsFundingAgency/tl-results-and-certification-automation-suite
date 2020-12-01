using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class RegistrationsManualPage : ElementHelper
    {
        public static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static readonly By BackLink = By.Id("backLink");
        private static By ContinueBtn { get; } = By.XPath("//button[contains(text(),'Continue')]");
        private static By SubmitBtn { get; } = By.XPath("//button[contains(text(),'Submit')]");
        private static By AddRegistrationLink { get; } = By.XPath("//a[contains(text(),'Add a new registration')]");
        // ULN Page
        public static string UlnUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-registration-unique-learner-number");
        public static By UlnInput { get; } = By.Id("uln");
        public static readonly string UlnPageHeader = "Enter the Unique Learner Number (ULN)";
        public static By UlnError { get; } = By.XPath("//a[@href='#uln']");
        //Learner Name Page
        public static string LearnerNameUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-registration-learners-name");
        public static readonly string LearnerPageHeader = "Enter the learner's name";
        public static By FirstName { get; } = By.Id("firstname");
        public static By LastName { get; } = By.Id("lastname");
        public static By FirstNameError { get; } = By.XPath("//a[@href='#firstname']");
        public static By LastNameError { get; } = By.XPath("//a[@href='#lastname']");
        public static string FirstNameErrorMsg { get; } = "First name must be 100 characters or fewer";
        public static string LastNameErrorMsg { get; } = "Last name must be 100 characters or fewer";
        //DOB Page
        public static string DobPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-registration-date-of-birth");
        public static readonly string DobPageHeader = "Enter the learner's date of birth";
        public static By Day { get; } = By.Name("Day");
        public static By Month { get; } = By.Name("Month");
        public static By Year { get; } = By.Name("Year");
        public static By DayError { get; } = By.XPath("//a[@href='#day']");
        //Select Provider Page
        public static string ProviderPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-registration-provider");
        public static readonly string ProviderHeader = "Select the provider";
        private static By SelectProvider { get; } = By.Id("selectedproviderukprn");
        public const string InputPovider = "Automation Test2 (99999902)";
        public const string InputProvider1 = "Automation Test1 (99999901)";
        public const string InputPearsonPovider = "Automation Test3 (99999903)";
        //Select Core Page
        public static string CorePageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-registration-core");
        public static readonly string CoreHeader = "Select the core";
        private static By SelectCore { get; } = By.Id("selectedcorecode");
        public const string InputCore = "Legal, Finance and Accounting (55555555)";
        public const string InputCore1 = "Digital Support Services (10623456)";
        public const string InputPearsonCore = "Creative and Design (10101010)";
        //Specialism Page
        public static By SelectSpecialismPageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        public static string SpecialismDecidePageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-registration-learner-decided-specialism-question");
        public static readonly string SpecialismDecideHeader = "Has the learner decided on the specialism?";
        public static By DecideYes { get; } = By.Id("haslearnerdecidedspecialism");
        public static By DecideNo { get; } = By.Id("specialismdecided-no");
        public static string SpecialismSelectPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-registration-specialism");
        public static By SelectSpecialismLegal = By.XPath("//label[contains(text(),'Legal')]");
        public static By SelectSpecialismAgg = By.XPath("//label[contains(text(),'Agriculture, Land')]");
        public static By SelectSpecialismFinancial = By.XPath("//label[contains(text(),'Financial')]");
        public static By SelectSpecialismCraft = By.XPath("//label[contains(text(),'Craft and Design')]");
        public static string AcademicYearPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-registration-academic-year");
        private static string RegistrationSummaryPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-registration-check-and-submit");
        private static readonly string SummaryPageHeader = "Check and submit";
        private static readonly string RegistrationSuccessHeader = "Registration successful";
        private static string RegistrationSuccessPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-registration-confirmation");
        private static readonly By ViewULNDetails = By.XPath("//a[contains(text(),'View this ULN')]");
        private static string UlnRegSameAOUrl { get; } = string.Concat(StartPage.StartPageUrl, "ULN-cannot-be-registered");
        //Change Registration
        private static By ChangeBtn { get; } = By.XPath("//button[contains(text(),'Change')]");
        private static By ChangeUln { get; } = By.Id("uln");
        private static By ChangeLearner { get; } = By.Id("learnername");
        private static By ChangeDob { get; } = By.Id("dateofbirth");
        private static By ChangeProvider { get; } = By.Id("provider");
        private static By ChangeCore { get; } = By.Id("core");
        private static By ChangeSpecialism { get; } = By.Id("specialisms");
        private static By ChangeAcademicYear { get; } = By.Id("academicyear");

        //Registration Search Page
        public static By BackToRegistrationsBtn { get; } = By.XPath("//a[contains(text(),'Back to registrations')]");
        public static By BackToRegDetailsBtn { get; } = By.Id("registrationDetailsButton");
        private static By SearchForRegistrationLink { get; } = By.XPath("//a[contains(text(),'Search for a registration')]");
        private static string RegistrationSearchPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "search-for-registration");
        private static readonly string RegistrationSearchHeader = "Search for a registration";
        private static By SearchPageUlnInput { get; } = By.Id("searchuln");
        private static string URLNotFoundPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "search-for-registration-ULN-not-found");
        private static readonly string ExpectedInvalidULNError = "Enter a valid ULN";
        public static By ActualInvalidULNError = By.XPath("//*[@id='main-content']//span[2]");
        private static By SearchBtn { get; } = By.XPath("//*[@id='main-content']//button");
        public static By ActualNullULNError = By.XPath("//*[@id='main-content']//span[2]");
        private static readonly string ExpectedNullULNError = "Enter a ULN";
        public static By ULNNotFoundPageBackLink = By.Id("backLink");
        private static readonly string RegistrationDetailsHeader = "Registration details";
        private static readonly String ExpectedSearchRegistrationSearchBtnText = "Search";
        public static By BCRegistrations = By.XPath("//*[@id='breadcrumb1']");
        public static By BCHome = By.XPath("//*[@id='breadcrumb0']");

        //Search Registration Details Page
        private static readonly string ExpectedSearchAgainBtnText = "Search again";

        public static void AddRegistrations()
        {
            ClickElement(AddRegistrationLink);
        }

        public static void AddNewRegistrations()
        {
            RegistrationsPage.ClickRegLink();
            ClickElement(AddRegistrationLink);
        }
        public static void ClickContiune()
        {
            ClickElement(ContinueBtn);
        }
        public static void ClickChangeBtn()
        {
            ClickElement(ChangeBtn);
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
        public static void ClickChangeUlnLink()
        {
            WebDriver.FindElement(ChangeUln).Click();
        }
        public static void ClickChangeLearnerLink()
        {
            WebDriver.FindElement(ChangeLearner).Click();
        }
        public static void ClickChangeDobLink()
        {
            WebDriver.FindElement(ChangeDob).Click();
        }
        public static void ClickChangePoviderLink()
        {
            WebDriver.FindElement(ChangeProvider).Click();
        }
        public static void ClickChangeCoreLink()
        {
            WebDriver.FindElement(ChangeCore).Click();
        }
        public static void ClickChangeSpecialismLink()
        {
            WebDriver.FindElement(ChangeSpecialism).Click();
        }
        public static void ClickChangeAcademicYearLink()
        {
            WebDriver.FindElement(ChangeAcademicYear).Click();
        }

        //Registration Search Page Methods
        public static void ClickBackToRegistrations()
        {
            ClickElement(BackToRegistrationsBtn);
        }

        public static void ClickSearchForRegistrationLink()
        {
            ClickElement(SearchForRegistrationLink);
        }

        public static void ClickSearchButton()
        {
            ClickElement(SearchBtn);
        }

        public static void VerifyRegistrationSearchPage()
        {
            Assert.AreEqual(RegistrationSearchPageUrl, WebDriver.Url);
            Assert.AreEqual(Constants.SearchRegistrationsPageTitle, WebDriver.Title);
            Assert.AreEqual(RegistrationSearchHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(ExpectedSearchRegistrationSearchBtnText, WebDriver.FindElement(By.XPath("//button[contains(text(),'Search')]")).Text);
        }

        public static void EnterSearchUln(string uln)
        {
            WebDriver.FindElement(SearchPageUlnInput).SendKeys(uln);
        }

        public static void VerifyURLNotFoundPage(string ULN)
        {
            //Construct dynamic page header
            string ExpectedURLNotFoundPageHeader = "ULN (" + ULN + ") cannot be found";

            Assert.AreEqual(URLNotFoundPageUrl, WebDriver.Url);
            Assert.AreEqual(Constants.SearchRegistrationURLNotFoundPagePageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedURLNotFoundPageHeader, WebDriver.FindElement(PageHeader).Text);
        }


        public static void VerifyInvalidULNError()
        {
            PageHelper.VerifyText(ActualInvalidULNError, ExpectedInvalidULNError);
        }

        public static void VerifyNullULNError()
        {
            PageHelper.VerifyText(ActualNullULNError, ExpectedNullULNError);
        }

        public static void ClickBackLink_ULNNotFoundPage()
        {
            ClickElement(ULNNotFoundPageBackLink);
        }

        public static void VerifyULNFieldIsPopulated(string ULN)
        {
            string ULNInputValue = WebDriver.FindElement(SearchPageUlnInput).GetAttribute("value");
            Console.WriteLine(ULNInputValue);
            PageHelper.VerifyText(ULN, ULNInputValue);
        }

        public static void VerifyRegistrationDetailsPage()
        {
            Assert.AreEqual(RegistrationDetailsHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(ExpectedSearchAgainBtnText, WebDriver.FindElement(By.XPath("//*[contains(text(),'Search again')]")).Text);
        }

        public static void SearchReg_ClickRegistrationsBCLink()
        {
            ClickElement(BCRegistrations);
        }

        public static void SearchReg_ClickHomeBCLink()
        {
            ClickElement(BCHome);
        }
        public static void CreateRegistrationWithSpecialism(string uln, string firstName, string lastname, string day, string month, string year)
        {
            VerifyUlnPage();
            EnterUln(uln);
            ClickContiune();
            VerifyLearnersPage();
            EnterLearnerName(firstName, lastname);
            ClickContiune();
            VerifyDobPage();
            EnterDob(day, month, year);
            ClickContiune();
            VerifyProviderPage();
            SelectProviderFromList(InputPovider);
            ClickContiune();
            VerifyCorePage();
            SelectCoreFromList(InputCore);
            ClickContiune();
            VerifySpecialismDecidePage();
            ClickElement(DecideYes);
            ClickContiune();
            VerifySpecialismPage();
            VerifySpecialismPageDynamicHeader();
            ClickElement(SelectSpecialismLegal);
            ClickContiune();
            VerifyAcademicYearPage();
            ClickContiune();
            VerifyRegistrationSummaryPage();
        }

        public static void CreateRegistrationWithoutSpecialism(string uln, string firstName, string lastname, string day, string month, string year)
        {
            VerifyUlnPage();
            EnterUln(uln);
            ClickContiune();
            VerifyLearnersPage();
            EnterLearnerName(firstName, lastname);
            ClickContiune();
            VerifyDobPage();
            EnterDob(day, month, year);
            ClickContiune();
            VerifyProviderPage();
            SelectProviderFromList(InputPovider);
            ClickContiune();
            VerifyCorePage();
            SelectCoreFromList(InputCore);
            ClickContiune();
            VerifySpecialismDecidePage();
            ClickElement(DecideNo);
            ClickContiune();
            VerifyAcademicYearPage();
            ClickContiune();
            VerifyRegistrationSummaryPage();
        }
        public static void CreateRegistrationForPearson(string uln, string firstName, string lastname, string day, string month, string year)
        {
            VerifyUlnPage();
            EnterUln(uln);
            ClickContiune();
            VerifyLearnersPage();
            EnterLearnerName(firstName, lastname);
            ClickContiune();
            VerifyDobPage();
            EnterDob(day, month, year);
            ClickContiune();
            VerifyProviderPage();
            SelectProviderFromList(InputPearsonPovider);
            ClickContiune();
            VerifyCorePage();
            SelectCoreFromList(InputPearsonCore);
            ClickContiune();
            VerifySpecialismDecidePage();
            ClickElement(DecideNo);
            ClickContiune();
            VerifyAcademicYearPage();
            ClickContiune();
            VerifyRegistrationSummaryPage();
        }
        public static void CreateManualRegistrationWithSpecialism(string uln)
        {
            RegistrationsPage.ClickRegLink();
            AddRegistrations();
            VerifyUlnPage();
            EnterUln(uln);
            ClickContiune();
            VerifyLearnersPage();
            EnterLearnerName("FirstName1", "LastName1");
            ClickContiune();
            VerifyDobPage();
            EnterDob("01", "01", "2010");
            ClickContiune();
            VerifyProviderPage();
            SelectProviderFromList(InputPovider);
            ClickContiune();
            VerifyCorePage();
            SelectCoreFromList(InputCore);
            ClickContiune();
            VerifySpecialismDecidePage();
            ClickElement(DecideYes);
            ClickContiune();
            VerifySpecialismPage();
            VerifySpecialismPageDynamicHeader();
            ClickElement(SelectSpecialismLegal);
            ClickContiune();
            VerifyAcademicYearPage();
            ClickContiune();
            VerifyRegistrationSummaryPage();
            ClickSubmit();
            ClickBackToRegistrations();
        }
        public static void CreateRegistrationWithoutSpecialism(string uln)
        {
            RegistrationsPage.ClickRegLink();
            AddRegistrations();
            VerifyUlnPage();
            EnterUln(uln);
            ClickContiune();
            VerifyLearnersPage();
            EnterLearnerName("FirstName1", "LastName1");
            ClickContiune();
            VerifyDobPage();
            EnterDob("01", "01", "2010");
            ClickContiune();
            VerifyProviderPage();
            SelectProviderFromList(InputPovider);
            ClickContiune();
            VerifyCorePage();
            SelectCoreFromList(InputCore);
            ClickContiune();
            VerifySpecialismDecidePage();
            ClickElement(DecideNo);
            ClickContiune();
            VerifyAcademicYearPage();
            ClickContiune();
            VerifyRegistrationSummaryPage();
            ClickSubmit();
            ClickBackToRegistrations();
        }


        public static void CreateRegistrationWithSpecialismForPearson(string uln, string firstName, string lastname, string day, string month, string year)
        {
            VerifyUlnPage();
            EnterUln(uln);
            ClickContiune();
            VerifyLearnersPage();
            EnterLearnerName(firstName, lastname);
            ClickContiune();
            VerifyDobPage();
            EnterDob(day, month, year);
            ClickContiune();
            VerifyProviderPage();
            SelectProviderFromList(InputPearsonPovider);
            ClickContiune();
            VerifyCorePage();
            SelectCoreFromList(InputPearsonCore);
            ClickContiune();
            VerifySpecialismDecidePage();
            ClickElement(DecideYes);
            ClickContiune();
            VerifySpecialismPage();
            ClickElement(SelectSpecialismCraft);
            ClickContiune();
            VerifyAcademicYearPage();
            ClickContiune();
            VerifyRegistrationSummaryPage();
        }

        public static void ClickHomeBreadcrumb()
        {
            ClickElement(BCHome);
        }

        public static void VerifySpecialismPageDynamicHeader()
        {
            //Construct dynamic page header
            string SelecSpecialismPageHeader = "Select the specialism for " + InputCore;
            string ExpectedSelecSpecialismPageHeader = SelecSpecialismPageHeader.Substring(0, SelecSpecialismPageHeader.Length - 11);
            Assert.AreEqual(ExpectedSelecSpecialismPageHeader, WebDriver.FindElement(SelectSpecialismPageHeader).Text);
        }

    }
}
