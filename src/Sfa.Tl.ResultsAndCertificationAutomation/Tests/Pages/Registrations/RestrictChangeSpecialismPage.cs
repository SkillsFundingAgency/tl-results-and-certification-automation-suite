using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Registrations
{
    public class RestrictChangeSpecialismPage : ElementHelper
    {
        private static string pageTitle { get; } = "Specialism change restriction - Registration – Manage T Level results – GOV.UK";
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "registration-specialism-change-restriction");
        private static By pageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static string pageHeader { get; } = "Change occupational specialism";
        private static By removeSpecialismBtn { get; } = By.Id("removeAssessmentEntryButton");
        public static void VerifyRestrictChangeSpecialismPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(pageTitle, WebDriver.Title);
            Assert.AreEqual(pageHeader, WebDriver.FindElement(pageHeaderElement).Text);
        }
        public static void ClickRemoveSpecialismBtn()
        {
            ClickButton(removeSpecialismBtn);
        }
    }
}
