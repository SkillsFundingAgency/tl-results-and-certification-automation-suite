using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class RegistrationsSearchPage : ElementHelper
    {
        private static readonly string SearchResultUrl = string.Concat(StartPage.StartPageUrl, "search-for-registration-registration-details");
        private static readonly string CancelRegUrl = string.Concat(StartPage.StartPageUrl, "delete-registration");
        private static readonly string UlnNotFoundUrl = string.Concat(StartPage.StartPageUrl, "search-for-registration-ULN-not-found");
        public static readonly By SearchRegistrationLink = By.XPath("//a[contains(text(),'Manage existing registrations')]");
        public static readonly By SearchBox = By.Id("searchuln");
        public static readonly By SearchBtn = By.XPath("//button[contains(text(),'Search')]");
        private static readonly By CancelRegBtn = By.XPath("//a[contains(text(),'Cancel this registration')]");
        public static By BackToRegistrationDetailsBtn { get; } = By.XPath("//a[contains(text(),'Back to registration details')]");
        public static By CancelRegNo { get; } = By.Id("cancel-registration-no");
        private static readonly By SearchAnotherRegBtn = By.XPath("//a[contains(text(),'Search for another registration')]");
        private static readonly string UlnNotFoundTitle = "ULN cannot be found page – Manage T Level results – GOV.UK";
        public static string ConfirmRegCancelErrorTitle = "Error: Delete registration page – Manage T Level results – GOV.UK";
        public const string ChangeProviderPageTitle = "Change registration - Select the provider page – Manage T Level results – GOV.UK";
        public static readonly string ChangeProviderUrl = string.Concat(StartPage.StartPageUrl, "change-registration-provider");
        public static readonly string ChangeProviderPageHeader = "Select the provider";
        public const string CannotChangeProviderPageTitle = "Cannot change provider page – Manage T Level results – GOV.UK";
        public static readonly string CannotChangeProviderPageUrl = string.Concat(StartPage.StartPageUrl, "cannot-change-provider");
        private const string ChangeSpecialismDecidePageTitle = "Change registration - Has the learner decided on the specialism page – Manage T Level results – GOV.UK";
        private static readonly string ChangeSpecialismDecidePageUrl = string.Concat(StartPage.StartPageUrl, "change-registration-learner-decided-specialism-question");
        private static readonly string ChangeSpecialismDecidePageHeader = "Has the learner decided on the specialism?";
        private static readonly string SpecialismDecideChangePageHeader = "Do you want to change or remove your specialism?";
        public const string SelectSpecialismPageTitle = "Select specialisms page – Manage T Level results – GOV.UK";
        public const string ChangeSpecialismPageTitle = "Change registration - Select specialism page – Manage T Level results – GOV.UK";
        public static readonly string SelectSpecialismPageUrl = string.Concat(StartPage.StartPageUrl, "change-registration-select-specialism");
        private const string AcademicYearCantChangePageTitle = "Academic year cannot be changed page – Manage T Level results – GOV.UK";
        private static readonly string AcademicYearCantChangePageHeader = "Academic year cannot be changed";
        private static readonly string AcademicYearCantChangePageUrl = string.Concat(StartPage.StartPageUrl, "academic-year-cannot-change");
        public static readonly string ChangeProvider4 = "Automation Test4 (99999904)";
       public static string DoYouWantToChangeCorePageErrorTitle = "Error: Change registration - Do you also want to change the core page – Manage T Level results – GOV.UK";
        public static readonly string CanChangeCodeErrorMsg = "Select yes if you want to change the core";
         private const string ChangeSpecialismErrorPageTitle = "Error: Change registration - Select specialism page – Manage T Level results – GOV.UK";
        public static By ChangeCoreError { get; } = By.XPath("//a[@href='#canchangecore']");
        public static By DecideSpecialismYes { get; } = By.Id("haslearnerdecidedspecialism");
        public static By DecideSpecialismNo { get; } = By.Id("specialismdecided-no");
        private static By ChangeSpecialismError { get; } = By.XPath("//a[@href='#hasspecialismselected']");
        private static readonly string ChangeSpecialismErrorMsg = "Select a specialism";
        public static By ContinueBtn { get; } = By.Id("continueButton");
        public static By CancelRegError { get; } = By.XPath("//a[@href='#deleteregistration']");
        public static string CancelRegErrorDeails { get; } = "Select yes if you want to cancel this registration";
        public static By ChangeBtn { get; } = By.XPath("//button[contains(text(),'Change')]");
        public static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By ULNStatus { get; } = By.XPath("//*[@id='main-content']//strong");
        private static By NameChangeLink { get; } = By.Id("learnername");
        private static By DOBChangeLink { get; } = By.Id("dateofbirth");
        public static By ProviderChangeLink { get; } = By.Id("provider");
        public static By CoreChangeLink { get; } = By.Id("core");
        public static By SpecialismChangeLink { get; } = By.Id("specialisms");
        public static By AcademicYearChangeLink { get; } = By.Id("academicyear");
        public static By CanChangeCoreYes { get; } = By.Id("canchangecore");
        public static By CanChangeCoreNo { get; } = By.Id("tl-change-core-no");
        public static By WithDrawRegistrationBtn { get; } = By.Id("withdrawRegistrationButton");
        private static By DOB { get; } = By.XPath("//*[@id='main-content']//div[3]/dd[1]/p");
        private static By Name { get; } = By.XPath("//*[@id='main-content']//dl/div[2]/dd[1]/p");
        private static By ChangeStatusLink { get; } = By.Id("learnerstatus");
        private static By RegistrationDetailsPageSubheading = By.XPath("//*[@id='main-content']//h2");
        private static By RegistrationDetailsheading = By.XPath("//*[@id='main-content']//h1");
        private static By ActiveYear { get; } = By.XPath("//*[@id='main-content']//div[7]/dd[1]/p");
        private static string ExpectedActiveYear = "{AcademicYear}";
        public static By HomeBreadcrumb { get; } = By.Id("breadcrumb0");
        private static By ViewAndAmendLearnersEntriesLink { get; } = By.Id("AssessmentEntriesLink");

        public static new void ClickButton(By locator)
        {
            WebDriver.FindElement((locator)).Click();
        }
        public static void VerifySearchResultPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(SearchResultUrl));
            Assert.AreEqual(Constants.SearchDetailsTitle, WebDriver.Title);
            Assert.AreEqual(Constants.SearchDetailsHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyName(string name) 
        {
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(name));
        }
        public static void VerifyDob(string Dob)
        {
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(Dob));
        }
        public static void VerifyProvider(string Provider)
        {
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(Provider));
        }
        public static void VerifyCore(string Core)
        {
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(Core));
        }
        public static void VerifySpecialism(string Specialism)
        {
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(Specialism));
        }

        //is this still required?
        public static void ClickCancelRegistration()
        {
            ClickButton(CancelRegBtn);
        }

        public static void SearchAnotherReg()
        {
            ClickButton(SearchAnotherRegBtn);
        }
        public static void VerifyUlnNotFoundPage(string uln)
        {
            Assert.AreEqual(UlnNotFoundTitle, WebDriver.Title);
            Assert.AreEqual(UlnNotFoundUrl, WebDriver.Url);
            Assert.AreEqual("ULN (" + uln + ") cannot be found", WebDriver.FindElement(By.XPath("//*[@id='main-content']//h1")).Text);
        }
        public static void VerifySearchFromBulkUpload()
        {
            VerifyName("First Name 1 Last Name 1");
            VerifyDob("10/01/2006");
            VerifyProvider("Automation Test1 (99999901)");
            VerifyCore("Agriculture, Environmental and Animal Care (77777777)");
            VerifySpecialism("Animal Care and Management (70000001)");
        }


        public static void ValidateUlnStatus(string ExpectedStatus)
        {
            Assert.AreEqual(ExpectedStatus, WebDriver.FindElement(ULNStatus).Text);
        }

        public static void ValidateChangeStatusLink()
        {
            Assert.IsTrue(WebDriver.FindElement(ChangeStatusLink).Text.Contains("Change status"));
        }

        public static void ValidateChangeLinks()
        {
            Assert.IsTrue(WebDriver.FindElement(NameChangeLink).Text.Contains("Change"));
            Assert.IsTrue(WebDriver.FindElement(DOBChangeLink).Text.Contains("Change"));
            Assert.IsTrue(WebDriver.FindElement(ProviderChangeLink).Text.Contains("Change"));
            Assert.IsTrue(WebDriver.FindElement(CoreChangeLink).Text.Contains("Change"));
            Assert.IsTrue(WebDriver.FindElement(SpecialismChangeLink).Text.Contains("Change"));
            Assert.IsTrue(WebDriver.FindElement(AcademicYearChangeLink).Text.Contains("Change"));
        }

        public static void VerifyChangeSpecialismErrorPage()
        {
            Assert.AreEqual(ChangeSpecialismErrorPageTitle, WebDriver.Title);
            Assert.AreEqual(ChangeSpecialismErrorMsg, WebDriver.FindElement(ChangeSpecialismError).Text);
        }

        public static void ClickNameChangeLink()
        {
            ClickButton(NameChangeLink);
        }

        public static void ClickDOBChangeLink()
        {
            ClickButton(DOBChangeLink);
        }

        public static void SearchForULN()
        {
            EnterText(RegistrationsSearchPage.SearchBox, Constants.ManualRegULN);
            ClickElement(RegistrationsSearchPage.SearchBtn);
        }

        public static void SearchForULN(string ULN)
        {
            EnterText(RegistrationsSearchPage.SearchBox, ULN);
            ClickElement(RegistrationsSearchPage.SearchBtn);
        }

        public static void VerifyDOBChangesAreDisplayed(string DD, string MM, string YYYY)
        {
            string ExpectedDOB = DD + "/" + MM + "/" + YYYY;
            Assert.AreEqual(ExpectedDOB, WebDriver.FindElement(DOB).Text);
        }

        public static void VerifyNameChangesAreDisplayed(string FirstName, string LastName)
        {
            string ExpectedName = FirstName + " " + LastName;
            Assert.AreEqual(ExpectedName, WebDriver.FindElement(Name).Text);
        }

        public static void ClickChangeStatusLink()
        {
            ClickButton(ChangeStatusLink);
        }

        public static void ClickChangeCoreLink()
        {
            ClickElement(CoreChangeLink);
        }

        public static void ClickChangeProviderLink()
        {
            ClickElement(ProviderChangeLink);
        }

        public static void VerifyRegistrationDetailsPageSubHeading()
        {
            string ExpectedSubHeading = "ULN: " + Constants.ManualRegULN;
            Assert.AreEqual(ExpectedSubHeading, WebDriver.FindElement(RegistrationDetailsPageSubheading).Text);
        }

        public static void ValidateChangeLinksAreNotDisplayed()
        {
            bool expectedResponse = false;
            Assert.AreEqual(expectedResponse, IsPresent(NameChangeLink));
            Assert.AreEqual(expectedResponse, IsPresent(DOBChangeLink));
            Assert.AreEqual(expectedResponse, IsPresent(ProviderChangeLink));
            Assert.AreEqual(expectedResponse, IsPresent(CoreChangeLink));
            Assert.AreEqual(expectedResponse, IsPresent(SpecialismChangeLink));
            Assert.AreEqual(expectedResponse, IsPresent(AcademicYearChangeLink));
        }

        public static void VerifyActiveYear()
        {
            Assert.AreEqual(ExpectedActiveYear, WebDriver.FindElement(ActiveYear).Text);
        }

        public static void PressHomeBreadcrumb()
        {
            ClickElement(HomeBreadcrumb);
        }

        //Verify Decide Specialism Page Methods

        public static void VerifyDecideSpecialismPage()
        {
            Assert.AreEqual(ChangeSpecialismDecidePageTitle, WebDriver.Title);
            Assert.AreEqual(ChangeSpecialismDecidePageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(ChangeSpecialismDecidePageUrl));
        }

        public static void VerifyDecideSpecialismChangePage()
        {
            Assert.AreEqual(ChangeSpecialismDecidePageTitle, WebDriver.Title);
            Assert.AreEqual(SpecialismDecideChangePageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(ChangeSpecialismDecidePageUrl));
        }

        //Verify Change Academic Year Page Methods

        public static void VerifyAcademicYearChangePage()
        {
            Assert.AreEqual(AcademicYearCantChangePageTitle, WebDriver.Title);
            Assert.AreEqual(AcademicYearCantChangePageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(AcademicYearCantChangePageUrl));
        }

        public static void VerifyRegistrationDetailsPageULNSubHeading(string ULN)
        {
            string ExpectedSubHeading = "ULN: " + ULN;
            Assert.AreEqual(ExpectedSubHeading, WebDriver.FindElement(RegistrationDetailsPageSubheading).Text);
        }

        public static void VerifyViewLearnersAssessmentEntriesLinkNotPresent()
        {
            bool expectedResponse = false;
            Assert.AreEqual(expectedResponse, IsPresent(ViewAndAmendLearnersEntriesLink));
           
        }

        public static void ClickViewAndAmendLearnersAssessmentEntriesLink()
        {
            ClickElement(ViewAndAmendLearnersEntriesLink);
        }
    }
}
