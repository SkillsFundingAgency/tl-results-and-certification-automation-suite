using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class TLevelJourneyDashboardPage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "tlevels");
        private static string pageTitle { get; } = "T Levels – Manage T Level results – GOV.UK";
        private static string pageHeader { get; } = "T Levels";
        private static readonly By pageHeaderElement = By.XPath("//*[@id='main-content']//h1");
        private static By homeBreadcrumb { get; } = By.Id("breadcrumb0");
        private static By RegistrationDetailsElement = By.ClassName("govuk-grid-column-three-quarters");
        private static By reviewNewTlevelsLink { get; } = By.Id("reviewTlevelsLink");
        private static By confirmedTlevelsLink { get; } = By.Id("confirmedTlevelsLink");
        private static By queriedTlevelsLink { get; } = By.Id("queriedTlevelsLink");
        private static By paragraphTextElement = By.ClassName("govuk-body-l");
        private static string ExpectedParagraphText = "Check and confirm T Level details are correct before adding them to your providers";

        public static void VerifyTLevelsDashboardPage()
        {          
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(WebDriver.Title, pageTitle);
            Assert.AreEqual(WebDriver.FindElement(pageHeaderElement).Text, pageHeader);
            Assert.AreEqual(WebDriver.FindElement(paragraphTextElement).Text, ExpectedParagraphText);
        }

        public static void ClickHomeBreadcrumb()
        {
            ClickElement(homeBreadcrumb);
        }


    }
}
