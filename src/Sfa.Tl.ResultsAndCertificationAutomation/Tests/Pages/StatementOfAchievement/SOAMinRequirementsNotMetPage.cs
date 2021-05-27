using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement
{
    public class SOAMinRequirementsNotMetPage : ElementHelper
    {
       
        private static string SOANotAvailablePageUrl { get; } = string.Concat(StartPage.StartPageUrl, "request-statement-of-achievement-not-available-no-results");
        private static string SOANotAvailablePageHeader { get; } = "Statement of achievement not available - minimum requirements not met";
        private static string SOANotAvailablePageTitle { get; } = "Request statement of achievement – Statement of achievement not available page – Manage T Level results – GOV.UK";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By HomeBreadcrumb { get; } = By.Id("breadcrumb0");
        private static By RequestSOABreadcrumb { get; } = By.Id("breadcrumb1");
        private static By SearchForALearnerBreadcrumb { get; } = By.Id("breadcrumb2");
        private static By RegistrationDetailsElement { get; } = By.ClassName("govuk-grid-column-three-quarters");
        private static By BackToHomeBtn { get; } = By.Id("backButton");
        private static By UpdateLearnerRecordLink { get; } = By.XPath("//a[@href='/search-learner-record-unique-learner-number']");

        public static void VerifySOANotAvailablePage(string ULN, string Name, string DOB, string Provider, string TLevelTitle)
        {
            Assert.AreEqual(SOANotAvailablePageUrl, WebDriver.Url);
            Assert.AreEqual(SOANotAvailablePageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(SOANotAvailablePageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.FindElement(RegistrationDetailsElement).Text.Contains(ULN));
            Assert.IsTrue(WebDriver.FindElement(RegistrationDetailsElement).Text.Contains(Name));
            Assert.IsTrue(WebDriver.FindElement(RegistrationDetailsElement).Text.Contains(DOB));
            Assert.IsTrue(WebDriver.FindElement(RegistrationDetailsElement).Text.Contains(Provider));
            Assert.IsTrue(WebDriver.FindElement(RegistrationDetailsElement).Text.Contains(TLevelTitle));
        }

        public static void ClickBreadCrumb(string BreadCrumbName)
        {
            switch (BreadCrumbName)
            {
                case "Home":
                    ClickElement(HomeBreadcrumb);
                    break;
                case "Request statement of achievement":
                    ClickElement(RequestSOABreadcrumb);
                    break;
                case "Search for a learner":
                    ClickElement(SearchForALearnerBreadcrumb);
                    break;
            }
        }

        public static void ClickBackToHomeButton()
        {
            ClickElement(BackToHomeBtn);
        }

        public static void ClickUpdateTheirLearnerTLevelRecordLink()
        {
            ClickElement(UpdateLearnerRecordLink);
        }


    }
}
