using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class UserAccessLevels : ElementHelper
    {
        private static readonly By ManageTlevelBanner = By.XPath("//a[contains(text(),'Manage T Level results')]");
        private static readonly By PageHeader = By.XPath("//*[@id='main-content']//h1");
        private const string AccessDenied = "Access denied";
        private const string AccessDeniedTitle = "Access denied due to wrong role page – Manage T Level results – GOV.UK";
        private const string AccessNoServiceTitle = "Service access denied page – Manage T Level results – GOV.UK";
        private static readonly By LevelLink = By.XPath("//a[contains(text(),'T Levels')]");
        private static readonly By ProviderLink = By.XPath("//a[contains(text(),'Providers')]");
        private static readonly By RegistrationsLink = By.XPath("//a[contains(text(),'Registrations')]");
        private static By ResultsLink { get; } = By.LinkText("Results");
        private static By AppealsLink { get; } = By.LinkText("Post-results");
        private static readonly By AccountLink = By.XPath("//a[contains(text(),'Account')]");
        private const string ExpectedUrl = "https://pp-profile.signin.education.gov.uk/";
        private const string ProfilePageHeader = "Profile";
        private const string ProviderDashboardUrl = "manage-learner-records";
        private const string AoSelectTlevelUrl = "select-tlevel";

        protected static void NavigateProviderDashboard()
        {
            NavigateTo(ProviderDashboardUrl);
        }

        protected static void NavigateAoDashboard()
        {
            NavigateTo(AoSelectTlevelUrl);
        }

        private static void VerifyAccessDeniedPage()
        {
            Assert.AreEqual(AccessDeniedTitle, WebDriver.Title);
            Assert.AreEqual(AccessDenied, WebDriver.FindElement(PageHeader).Text);
        }

        protected static void VerifyAccessDeniedWithWrongRolePage()
        {
            WaitForElement(DfESignInPage.ManageTlevelHeader, 10);
            Assert.AreEqual(AccessDeniedTitle, WebDriver.Title);
            Assert.AreEqual(AccessDenied, WebDriver.FindElement(PageHeader).Text);
        }
        private static void ClickOnLink(By locator)
        {
            ClickElement(locator);
        }

        private static void VerifyTLevelPage()
        {
            ClickOnLink(LevelLink);
            //Assert.AreEqual(Constants.TLevelsPageTitle, WebDriver.Title);
            //Assert.AreEqual(Constants.TLevelsPageHeader, WebDriver.FindElement(PageHeader).Text);
        }

        private static void VerifyProviderPage()
        {
            ClickOnLink(ProviderLink);
            Assert.AreEqual(Constants.ProviderPageTitle, WebDriver.Title);
            Assert.AreEqual(Constants.ProviderPageHeader, WebDriver.FindElement(PageHeader).Text);
        }

        private static void VerifyRegistrationsPage()
        {
            ClickOnLink(RegistrationsLink);
            Assert.AreEqual(Constants.RegistrationsPageTitle, WebDriver.Title);
            Assert.AreEqual(Constants.RegistationPageHeader, WebDriver.FindElement(PageHeader).Text);
        }
        private static void VerifyProfilePage()
        {
            ClickOnLink(AccountLink);
            Assert.AreEqual(ExpectedUrl, WebDriver.Url);
            Assert.AreEqual(ProfilePageHeader, WebDriver.FindElement(By.TagName("h1")).Text);
        }

        protected static void AccessLevelAdmin()
        {
            VerifyTLevelPage();
            ClickOnLink(ManageTlevelBanner);
            VerifyProviderPage();
            ClickOnLink(ManageTlevelBanner);
            VerifyRegistrationsPage();
            ClickOnLink(ManageTlevelBanner);
            ClickElement(AssessmentEntriesPage.AssessmentEntriesLink);
            AssessmentEntriesPage.VerifyAssessmentEntriesPage();
            ClickOnLink(ManageTlevelBanner);
            ClickOnLink(ResultsLink);
            ResultsDashboardPage.VerifyResultsDashboardPage();
            ClickOnLink(ManageTlevelBanner);
            ClickOnLink(AppealsLink);
            PostResultsStartPage.VerifyReviewAndAppealsStartPage();
            ClickOnLink(ManageTlevelBanner);
            VerifyProfilePage();
        }

        protected static void AccessLevelTLevelReviewer()
        {
            VerifyTLevelPage();
            ClickOnLink(ManageTlevelBanner);
            ClickOnLink(ProviderLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            ClickOnLink(RegistrationsLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            ClickElement(AssessmentEntriesPage.AssessmentEntriesLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            ClickOnLink(ResultsLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            ClickOnLink(AppealsLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            VerifyProfilePage();
        }

        protected static void AccessLevelProvidersEditor()
        {
            ClickOnLink(LevelLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            VerifyProviderPage();
            ClickOnLink(ManageTlevelBanner);
            ClickOnLink(RegistrationsLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            ClickElement(AssessmentEntriesPage.AssessmentEntriesLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            ClickOnLink(ResultsLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            ClickOnLink(AppealsLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            VerifyProfilePage();
        }

        protected static void AccessLevelRegistrationEditor()
        {
            ClickOnLink(LevelLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            ClickOnLink(ProviderLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            VerifyRegistrationsPage();
            ClickOnLink(ManageTlevelBanner);
            ClickElement(AssessmentEntriesPage.AssessmentEntriesLink);
            AssessmentEntriesPage.VerifyAssessmentEntriesPage();
            ClickOnLink(ManageTlevelBanner);
            ClickOnLink(ResultsLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            ClickOnLink(AppealsLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            VerifyProfilePage();
        }

        protected static void AccessLevelResultsEditor()
        {
            ClickOnLink(LevelLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            ClickOnLink(ProviderLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            ClickOnLink(RegistrationsLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            ClickElement(AssessmentEntriesPage.AssessmentEntriesLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            ClickOnLink(ResultsLink);
            ResultsDashboardPage.VerifyResultsDashboardPage();
            ClickOnLink(ManageTlevelBanner);
            ClickOnLink(AppealsLink);
            ReviewAndAppealsStartPage.VerifyReviewAndAppealsStartPage();
            ClickOnLink(ManageTlevelBanner);
            VerifyProfilePage();
        }

        protected static void AccessLevelNoRoles()
        {
            ClickOnLink(LevelLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            ClickOnLink(ProviderLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            ClickOnLink(RegistrationsLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            ClickElement(AssessmentEntriesPage.AssessmentEntriesLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            ClickOnLink(ResultsLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            ClickOnLink(AppealsLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            VerifyProfilePage();
        }

        protected static void AccessLevelNoService()
        {
            Assert.AreEqual(AccessNoServiceTitle, WebDriver.Title);
            Assert.AreEqual(AccessDenied, WebDriver.FindElement(PageHeader).Text);
        }
    }
}
