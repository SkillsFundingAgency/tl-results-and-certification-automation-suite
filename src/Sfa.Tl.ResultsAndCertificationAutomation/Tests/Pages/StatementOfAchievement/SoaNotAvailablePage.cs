using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement
{
    public class SoaNotAvailablePage : ElementHelper
    {
        private static string SoaNotAvailableNoIpPageUrl { get; } = "request-statement-of-achievement-not-available-no-ip-status";
        private static string SoaNotAvailableNoIpPageTitle { get; } = "Request statement of achievement - Statement of achievement not available page – Manage T Level results – GOV.UK";
        private static string SoaNotAvailableNoIpPageHeader { get; } = "Statement of achievement not available - we need more information";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By AddTlevelBtn { get; } = By.Id("addLearnerTlevelRecordButton");
        private static By SearchForLearnerBreadcrumb { get; } = By.Id("breadcrumb2");
        private static By RequestSoaBreadcrumb { get; } = By.Id("breadcrumb1");
        private static By HomeBreadcrumb { get; } = By.Id("breadcrumb0");
        public static void VerifySoaNotAvailablePage()
        {
            Assert.AreEqual(SoaNotAvailableNoIpPageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(SoaNotAvailableNoIpPageUrl));
            Assert.AreEqual(SoaNotAvailableNoIpPageHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public static void ClickAddTlevelRecordBtn()
        {
            ClickButton(AddTlevelBtn);
        }
        public static void ClickBreadCrumb(string name)
        {
            switch (name)
            {
                case "Search for a learner":
                    ClickElement(SearchForLearnerBreadcrumb);
                    break;
                case "Request statement of achievement":
                    ClickElement(RequestSoaBreadcrumb);
                    break;
                case "Home":
                    ClickElement(HomeBreadcrumb);
                    break;
            }
        }
    }
}
