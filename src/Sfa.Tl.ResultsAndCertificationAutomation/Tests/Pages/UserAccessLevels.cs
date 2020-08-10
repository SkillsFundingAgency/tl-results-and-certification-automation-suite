using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class UserAccessLevels : ElementHelper
    {
        private static readonly By ManageTlevelBanner = By.XPath("//a[contains(text(),'Manage T Level results')]");
        private static readonly By PageHeader = By.TagName("h1");
        private const string AccessDenied = "Access denied";
        private const string AccessDeniedTitle = "Access denied due to wrong role page – Manage T Level results – GOV.UK";
        private const string AccessNoServiceTitle = "Service access denied page – Manage T Level results – GOV.UK";
        private static readonly By TLevelLink = By.XPath("//a[contains(text(),'T Levels')]");
        private static readonly By ProviderLink = By.XPath("//a[contains(text(),'Providers')]");
        private static readonly By RegistrationsLink = By.XPath("//a[contains(text(),'Registrations')]");
        private static readonly By AccountLink = By.XPath("//a[contains(text(),'Account')]");
        private const string ExpectedUrl = "https://pp-profile.signin.education.gov.uk/";
        private const string ProfilePageHeader = "Profile";

        private void VerifyAccessDeniedPage()
        {
            Assert.AreEqual(AccessDeniedTitle, WebDriver.Title);
            Assert.AreEqual(AccessDenied, WebDriver.FindElement(PageHeader).Text);
        }
        private void ClickOnLink(By locator)
        {
            ClickElement(locator);
        }
        public void VerifyTLevelPage()
        {
            ClickOnLink(TLevelLink);
            //Assert.AreEqual(Constants.TLevelsPageTitle, WebDriver.Title);
            //Assert.AreEqual(Constants.TLevelsPageHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public void VerifyProviderPage()
        {
            ClickOnLink(ProviderLink);
            Assert.AreEqual(Constants.ProviderPageTitle, WebDriver.Title);
            Assert.AreEqual(Constants.ProviderPageHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public void VerifyRegistrationsPage()
        {
            ClickOnLink(RegistrationsLink);
            Assert.AreEqual(Constants.RegistrationsPageTitle, WebDriver.Title);
            Assert.AreEqual(Constants.RegistationPageHeader, WebDriver.FindElement(PageHeader).Text);
        }
        private void VarifyProfilePage()
        {
            ClickOnLink(AccountLink);
            Assert.AreEqual(ExpectedUrl, WebDriver.Url);
            Assert.AreEqual(ProfilePageHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public void AccessLevelAdmin()
        {
            VerifyTLevelPage();
            ClickOnLink(ManageTlevelBanner);
            VerifyProviderPage();
            ClickOnLink(ManageTlevelBanner);
            VerifyRegistrationsPage();
            ClickOnLink(ManageTlevelBanner);
            VarifyProfilePage();
        }
        public void AccessLevelTLevelReviewer()
        {
            VerifyTLevelPage();
            ClickOnLink(ManageTlevelBanner);
            ClickOnLink(ProviderLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            ClickOnLink(RegistrationsLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            VarifyProfilePage();
        }
        public void AccessLevelProvidersEditor()
        {
            ClickOnLink(TLevelLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            VerifyProviderPage();
            ClickOnLink(ManageTlevelBanner);
            ClickOnLink(RegistrationsLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            VarifyProfilePage();
        }
        public void AccessLevelRegistrationEditor()
        {
            ClickOnLink(TLevelLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            ClickOnLink(ProviderLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            VerifyRegistrationsPage();
            ClickOnLink(ManageTlevelBanner);
            VarifyProfilePage();
        }
        public void AccessLevelNoRoles()
        {
            ClickOnLink(TLevelLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            ClickOnLink(ProviderLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            ClickOnLink(RegistrationsLink);
            VerifyAccessDeniedPage();
            ClickOnLink(ManageTlevelBanner);
            VarifyProfilePage();
        }
        public void AccessLevelNoService()
        {
            Assert.AreEqual(AccessNoServiceTitle, WebDriver.Title);
            Assert.AreEqual(AccessDenied, WebDriver.FindElement(PageHeader).Text);
        }
    }
}
