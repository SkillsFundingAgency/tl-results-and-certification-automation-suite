using NUnit.Framework;
using OpenQA.Selenium;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class ReregisterCreateSpecialismPage : ReregisterHasLearnerDecidePage
    {
        private static string ExpectedCreateSpecialismTitle { get; } = "Register learner on a new course - Select the specialism page – Manage T Level results – GOV.UK";
        private static string ExpectedCreateSpecialismUrl { get; } = "register-learner-new-course-select-specialism";
        public static By SelectSpecialism { get; } = By.XPath("//label[contains(text(),'Animal Care and Management (70000001)')]");
        public static By SelectSpecialism2 { get; } = By.XPath("//label[contains(text(),'Agriculture, Land Management and Production (70000002)')]");
        public static By UpdatedSpecialism { get; } = By.XPath("//label[contains(text(),'Design, Development and Control (60000002)')]");
        private static new By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static string ExpectedError { get; } = "Select a specialism";
        private static By ErrorElement { get; } = By.XPath("//a[@href='#hasspecialismselected']");
        private static string CreateSpecialismErrorTitle { get; } = "Error: Register learner on a new course - Select the specialism page – Manage T Level results – GOV.UK";
        public static By ContinueButton { get; } = By.Id("submitButton");
        public static By AcademicYearPageContinueButton { get; } = By.Id("continueButton");

        // Academic  year page
        private static string ExpectedAcademicYearPageTitle { get; } = "Register learner on a new course - Select the academic year page – Manage T Level results – GOV.UK";
        private static string ExpectedAcademicYearPageUrl { get; } = "register-learner-new-course-select-academic-year";
        private static string ExpectedAcademicYearHeader { get; } = "Select the academic year";
        public static void VerifyReregisterSelectSpecialismPage()
        {
            Assert.AreEqual(ExpectedCreateSpecialismTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(ExpectedCreateSpecialismUrl));
        }

        public static void VerifyReregisterSelectSpecialismErrorPage()
        {
            Assert.AreEqual(CreateSpecialismErrorTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedError, WebDriver.FindElement(ErrorElement).Text);
        }
        public static void VerifyReregisterAcademicYearPage()
        {
            Assert.AreEqual(ExpectedAcademicYearPageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedAcademicYearHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(ExpectedAcademicYearPageUrl));
        }

        public static void UpdateSpecialism()
        {
            ClickElement(UpdatedSpecialism);
            ClickElement(ContinueButton);
            ClickElement(AcademicYearPageContinueButton);

        }
    }
}
