using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement
{
    public class SOAChangeLearnersTLevelComponentAchievementsPage : ElementHelper
    {

        private static string PageUrl { get; } = string.Concat(StartPage.StartPageUrl, "request-statement-of-achievement-change-learner-components");
        private static string PageHeader { get; } = "Change learner’s T Level component achievements";
        private static string PageTitle { get; } = "Request statement of achievement – Change learner's T Level component achievements page – Manage T Level results – GOV.UK";
        private static By PageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By PageCaptionElement { get; } = By.ClassName("govuk-caption-xl");
        private static string PageCaption { get; } = "Request statement of achievement";

        private static By BackLink { get; } = By.Id("backLink");
        private static By ManageLearnerTLevelRecordBtn = By.Id("manageTlevelRecordButton");


        public static void VerifySOAChangeLearnerComponentsPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(PageHeader, WebDriver.FindElement(PageHeaderElement).Text);
            Assert.AreEqual(PageTitle, WebDriver.Title);
        }

        public static void ClickManageLearnerTLevelRecordBtn()
        {
            ClickElement(ManageLearnerTLevelRecordBtn);
        }

        public static void ClickBackLink()
        {
            ClickElement(BackLink);
        }

    }
}
