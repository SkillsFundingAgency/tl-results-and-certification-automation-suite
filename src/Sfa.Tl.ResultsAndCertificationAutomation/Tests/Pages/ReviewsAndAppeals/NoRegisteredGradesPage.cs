using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals
{
    public class NoRegisteredGradesPage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "reviews-and-appeals-no-registered-grades");
        private static string pageTitle { get; } = "No registered grades – Manage T Level results – GOV.UK";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static readonly string ExpectedPageHeaderText = "Learner does not have any registered grades for Summer 2021";
        private static By addResultLink { get; } = By.Id("addResultLink");
        public static void VerifyNoRegisteredGradesPage()
        {
            Assert.AreEqual(pageUrl, WebDriver.Url);
            Assert.AreEqual(pageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedPageHeaderText, WebDriver.FindElement(PageHeader).Text);
        }
        public static void ClickAddResultLink()
        {
            ClickElement(addResultLink);
        }
    }
}
