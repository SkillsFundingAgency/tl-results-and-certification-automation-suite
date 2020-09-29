using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class RegistrationReactivate : ElementHelper
    {
        private static readonly string AmendWithdrawnPageUrl = string.Concat(StartPage.StartPageUrl, "amend-withdrawn-registration");
        private const string AmendWithdrawnPageTitle = "What would you like to do with this withdrawn registration page – Manage T Level results – GOV.UK";
        private static readonly string AmendWithdrawnPageHeader = "What would you like to do with this withdrawn registration?";
        private const string AmendWithdrawnPageErrorTitle = "Error: What would you like to do with this withdrawn registration page – Manage T Level results – GOV.UK";
        private const string AmendWithdrawnErrorMsg = "Select if you would like to reactivate this registration with the same course or register a different course";
        private static By AmendWithdrawnError { get; } = By.XPath("//a[@href='#changestatus']");
        private static readonly string ReactivateConfirmPageUrl = string.Concat(StartPage.StartPageUrl, "reactivate-registration-same-course");
        private const string ReactivateConfirmPageTitle = "Reactivate registration with the same course page – Manage T Level results – GOV.UK";
        private static readonly string ReactivateConfirmPageHeader = "Are you sure you want to reactivate the registration with the same course?";
        private static readonly string RegisterDifferentProviderPageUrl = string.Concat(StartPage.StartPageUrl, "register-learner-new-course-select-provider");
        private const string ReactivateConfirmErrorPageTitle = "Error: Reactivate registration with the same course page – Manage T Level results – GOV.UK";
        private const string ReactivateConfirmErrorMsg = "Select yes if you want to reactivate registration";
        private static By ReactivateConfirmError { get; } = By.XPath("//a[@href='#canrejoin']");
        private const string RegisterDifferentProviderPageTitle = "Register learner on a new course - Select the provider page – Manage T Level results – GOV.UK";
        private static readonly string RegisterDifferentProviderPageHeader = "Select the provider";
        private static readonly string ReactivateSuccessPageUrl = string.Concat(StartPage.StartPageUrl, "registration-reactivated-confirmation");
        private const string ReactivateSuccessPageTitle = "Registration reactivated confirmation page – Manage T Level results – GOV.UK";
        private static readonly string ReactivateSuccessPageHeader = "Registration reactivated successfully";
        private static By Profile { get; } = By.Id("ProfileId");
        private const string RegisterNewCourseTxt = "Register learner on a new course";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        public static By ChangeStatusLink { get; } = By.Id("learnerstatus");
        public static By ReactivateRegistration { get; } = By.Id("changestatus");
        public static By RegisterDifferentCourse { get; } = By.Id("tl-change-status-no");
        private static By WithdrawConfirmYes { get; } = By.Id("canwithdraw");
        public static By ReactivateConfirmYes { get; } = By.Id("canrejoin");
        public static By ReactivateConfirmNo { get; } = By.Id("tl-can-rejoin-no");
        public static By SubmitBtn { get; } = By.Id("submitButton");
        public static By ContinueBtn { get; } = By.Id("continueButton");
        private static By SelectProvider { get; } = By.Id("selectedproviderukprn");
        public static By HomeBtn { get; } = By.Id("dashboardButton");
        public static By ViewRegBtn { get; } = By.Id("viewRegButton");
        private static By ViewWithdrawReg { get; } = By.Id("viewWithdrawRegButton");
        private static By MainBody { get; } = By.Id("main-content");
        private static By SpecialismLegal { get; } = By.XPath("//label[contains(text(),'Legal (50000001)')]");
        private static By SpecialismAccountancy { get; } = By.XPath("//label[contains(text(),'Accountancy (50000003)')]");
        private static By SpecialismFinanacial { get; } = By.XPath("//label[contains(text(),'Financial (50000002)')]");

        public static void CreateWithdrawnReg()
        {
            RegistrationsPage.ClickRegLink();
            RegistrationsManualPage.AddRegistrations();
            RegistrationsManualPage.EnterUln("9900000001");
            RegistrationsManualPage.ClickContiune();
            RegistrationsManualPage.EnterLearnerName("FirstName1", "LastName1");
            RegistrationsManualPage.ClickContiune();
            RegistrationsManualPage.EnterDob("01", "01", "2010");
            RegistrationsManualPage.ClickContiune();
            RegistrationsManualPage.SelectProviderFromList("Automation Test2 (99999902)");
            RegistrationsManualPage.ClickContiune();
            RegistrationsManualPage.SelectCoreFromList("Legal, Finance and Accounting (55555555)");
            RegistrationsManualPage.ClickContiune();
            ClickElement(RegistrationsManualPage.DecideYes);
            RegistrationsManualPage.ClickContiune();
            ClickElement(By.XPath("//label[contains(text(),'Legal')]"));
            RegistrationsManualPage.ClickContiune();
            RegistrationsManualPage.ClickContiune();
            RegistrationsManualPage.ClickSubmit();
            RegistrationsManualPage.ClickBackToRegistrations();
            ClickElement(RegistrationsSearchPage.SearchRegistrationLink);
            EnterText(RegistrationsSearchPage.SearchBox, "9900000001");
            ClickElement(RegistrationsSearchPage.SearchBtn);
            VerifyRegDetails();
            ClickElement(ChangeStatusLink);
            ClickElement(ReactivateRegistration);
            ClickElement(ContinueBtn);
            ClickElement(WithdrawConfirmYes);
            ClickElement(SubmitBtn);
            ClickElement(ViewWithdrawReg);
            VerifyRegDetails();
        }

        public static void VerifyRegDetails()
        {
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains("9900000001"));
            RegistrationsSearchPage.VerifyName("FirstName1 LastName1");
            RegistrationsSearchPage.VerifyDob("01/01/2010");
            RegistrationsSearchPage.VerifyProvider("Automation Test2 (99999902)");
            RegistrationsSearchPage.VerifyCore("Legal, Finance and Accounting (55555555)");
            RegistrationsSearchPage.VerifySpecialism("Legal (50000001)");
        }

        public static void VerifyAmendWithdrawnPage()
        {
            Assert.AreEqual(AmendWithdrawnPageTitle, WebDriver.Title);
            Assert.AreEqual(AmendWithdrawnPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(AmendWithdrawnPageUrl));
            
        }
        public static void VerifyAreYouSureReactivatePage()
        {
            Assert.AreEqual(ReactivateConfirmPageTitle, WebDriver.Title);
            Assert.AreEqual(ReactivateConfirmPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(ReactivateConfirmPageUrl));
        }
        public static void VerifyReactivateWithAnotherProviderPage()
        {
            Assert.AreEqual(RegisterDifferentProviderPageTitle,WebDriver.Title);
            Assert.AreEqual(RegisterDifferentProviderPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(RegisterDifferentProviderPageUrl));
        }

        public static void VerifyReactivateSuccessPage()
        {
            Assert.AreEqual(ReactivateSuccessPageTitle, WebDriver.Title);
            Assert.AreEqual(ReactivateSuccessPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(ReactivateSuccessPageUrl, WebDriver.Url);
        }
        public static void VerifyAreYouSureReactivateErrorPage()
        {
            Assert.AreEqual(ReactivateConfirmErrorPageTitle, WebDriver.Title);
            Assert.AreEqual(ReactivateConfirmErrorMsg, WebDriver.FindElement(ReactivateConfirmError).Text);
        }
        public static void VerifyWithdrawnOptionsErrorPage()
        {
            Assert.AreEqual(AmendWithdrawnPageErrorTitle, WebDriver.Title);
            Assert.AreEqual(AmendWithdrawnErrorMsg, WebDriver.FindElement(AmendWithdrawnError).Text);
        }
    }
}
