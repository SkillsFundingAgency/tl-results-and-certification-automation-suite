using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement
{
    public class SOACheckAndSubmitPage : ElementHelper
    {
       
        private static string SOACheckAndSubmitPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "request-statement-of-achievement-check-and-submit");
        private static string SOACheckAndSubmitPageHeader { get; } = "Check the learner's details before sending your request";
        private static string SOACheckAndSubmitPageTitle { get; } = "Request statement of achievement – Check the learner’s details page – Manage T Level results – GOV.UK";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");

        private static By AcceptAndRequestBtn { get; } = By.ClassName("govuk-button");
        private static By CheckAndSubmitTextArea = By.ClassName("govuk-grid-column-two-thirds-from-desktop");

        public static void VerifySOACheckAndSubmitPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(SOACheckAndSubmitPageUrl));
            Assert.AreEqual(SOACheckAndSubmitPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(SOACheckAndSubmitPageTitle, WebDriver.Title);
        }

        public static void ClickAcceptAndRequestBtn()
        {
            ClickElement(AcceptAndRequestBtn);
        }

        public static void VerifyLearnersTLevelComponentAchievements(string EngAndMathAchievementStatus, string IndustryPlacementStatus)
        {
            Assert.IsTrue(WebDriver.FindElement(CheckAndSubmitTextArea).Text.Contains(EngAndMathAchievementStatus));
            Assert.IsTrue(WebDriver.FindElement(CheckAndSubmitTextArea).Text.Contains(IndustryPlacementStatus));
        }

    }
}
