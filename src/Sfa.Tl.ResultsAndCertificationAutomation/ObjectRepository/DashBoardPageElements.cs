using System.Configuration;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Hooks;

namespace Sfa.Tl.ResultsAndCertificationAutomation.ObjectRepository
{
    public class DashBoardPageElements
    {
        private readonly IWebDriver _webDriver;

        public DashBoardPageElements(IWebDriver webDriver)
        {
            this._webDriver = webDriver;
        }

        public static string StartPageUrl => ConfigurationManager.AppSettings["BaseUrl"];
        public static string DashboardUrl => string.Concat(StartPageUrl, "/dashboard");
        public static string HelpUrl => string.Concat(StartPageUrl, "/Help");
        public static string CookieUrl => string.Concat(HelpUrl, "/Cookies");
        public static string PrivacyUrl => string.Concat(HelpUrl, "/Privacy");
        public static string TermsUrl => string.Concat(HelpUrl, "/TermsAndConditions");

        public IWebElement SignOutLink => this._webDriver.FindElement(By.LinkText("Sign out"));

        public IWebElement CookiesLink => this._webDriver.FindElement(By.LinkText("Cookies"));

        public IWebElement PrivacyLink => this._webDriver.FindElement(By.LinkText("Privacy"));
        public IWebElement TermsLink => this._webDriver.FindElement(By.LinkText("Terms and conditions"));
        public IWebElement ServicesLink => this._webDriver.FindElement(By.LinkText("Services"));
        public IWebElement OrganisationsLink => this._webDriver.FindElement(By.LinkText("Organisations"));
        public IWebElement ProfileLink => this._webDriver.FindElement(By.LinkText("Profile"));
        public IWebElement HelpLink => this._webDriver.FindElement(By.LinkText("Help"));
        public IWebElement ViewQualificationLink => this._webDriver.FindElement(By.LinkText("View qualifications you're assessing"));
        public IWebElement ManageCentresLink => this._webDriver.FindElement(By.LinkText("Manage centres running T Levels"));
        public IWebElement ManageStudentsLink => this._webDriver.FindElement(By.LinkText("Manage student registrations"));
        public IWebElement SubmitAssessmentResultLink => this._webDriver.FindElement(By.LinkText("Submit assessment results"));
        public IWebElement Banner => this._webDriver.FindElement(By.XPath("//p[@class='govuk-phase-banner__content']"));
        public static string PageTitle = "Manage T Levels";
        public static IWebElement CheckPageTitle => Hooks.WebDriver.FindElement(By.TagName("h1"));
    }
}
