using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Hooks;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class TlevelDashboardPage : Hooks
    {
        public static string StartPageUrl => WebDriverFactory.Config["BaseUrl"];
        public static string DashBoadrdUrl => string.Concat(StartPageUrl, "/Help/Dashboard");
        public static string DashboardUrl => string.Concat(StartPageUrl, "/Dashboard");
        public IWebElement StartNowButton => WebDriver.FindElement(By.XPath("//a[@role='button' and contains(text(),'Start now')]"));
        public IWebElement CookiesLink => WebDriver.FindElement(By.LinkText("Cookies"));
        public static string HelpUrl => string.Concat(StartPageUrl, "/Help");
        public static string CookieUrl => string.Concat(HelpUrl, "/Cookies");
        public static By BannerInfo = By.XPath("//span[@class='govuk-phase-banner__text']");
        public static string BannerText = "This is a new service – your feedback will help us to improve it.";
        public static By SignOutLink = By.LinkText("Sign out");
        protected readonly By PageHeader = By.TagName("h1");
        public static By SelectOrgNcfe = By.Id("848D7FB9-ADBD-47EC-A975-3FF9314323EA");
        public static By OrgContinueBtn = By.XPath("//input[@value='Continue']");
        private By DashboardHeadLink = By.XPath("//a[@href='/Dashboard']");
        private By ManageCentresLink = By.XPath("//a[contains(text(), 'Manage centres')]");
        private By ViewQualificationLink = By.XPath("//a[contains(text(), 'View qualifications')]");
        private By ManageStudentRegLink = By.XPath("//a[contains(text(), 'Manage student')]");
        private By SubmitResultsLink = By.XPath("//a[contains(text(), 'Submit assessment')]");
        private By MenuBtn = By.XPath("//button[contains(text(),'Menu')]");
        private By PageTitle = By.TagName("h1");
        private static string ManageCentresPageHeader = "Your T Levels";

        public void ViewQualifications()
        {
            WebDriver.FindElement(ViewQualificationLink).Click();
            //TODO: Add Check Point
        }

        public void ManageCentres()
        {
            WebDriver.FindElement(ManageCentresLink).Click();
            PageHelper.WaitForPageLoad(WebDriver, 2);
            Assert.AreEqual(WebDriver.FindElement(PageTitle).Text, ManageCentresPageHeader);
        }

        public void ManageStudentReg()
        {
            WebDriver.FindElement(ManageStudentRegLink).Click();
            //TODO: Add Check Point
        }

        public void SubmitAssessmentResult()
        {
            WebDriver.FindElement(SubmitResultsLink).Click();
            //TODO: Add Check Point
        }

        public void SignoutFromMenu()
        {
            WebDriver.FindElement(MenuBtn).Click();
            WebDriver.FindElement(SignOutLink).Click();
        }
    }
}
