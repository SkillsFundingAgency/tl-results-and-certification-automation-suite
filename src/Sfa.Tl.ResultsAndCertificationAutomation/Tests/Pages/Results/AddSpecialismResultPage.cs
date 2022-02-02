using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Results
{
    public class AddSpecialismResultPage : ElementHelper
    {
        private static string PageUrl { get; } = "select-specialism-result";
        private static string PageTitle { get; } = "Select specialism result – Manage T Level results – GOV.UK";
        private static string ErrorPageTitle { get; } = "Error: Select specialism result – Manage T Level results – GOV.UK";
        private static By SelectGradeDistinction { get; } = By.Id("selectedgradecode");
        private static By SelectGradeMerit { get; } = By.Id("selectedgradecode-1");
        private static By SelectGradePass { get; } = By.Id("selectedgradecode-2");
        private static By SelectGradeUnclassified { get; } = By.Id("selectedgradecode-3");

        protected static void VerifyLearnerSpecialismResultPage()
        {
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        }

        protected static void VerifyLearnerSpecialismResultErrorPage()
        {
            Assert.AreEqual(ErrorPageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        }

        protected static void VerifyAddGradesUnchecked()
        {
            Assert.False(WebDriver.FindElement(SelectGradeDistinction).Selected);
            Assert.False(WebDriver.FindElement(SelectGradeMerit).Selected);
            Assert.False(WebDriver.FindElement(SelectGradePass).Selected);
            Assert.False(WebDriver.FindElement(SelectGradeUnclassified).Selected);
        }
        protected static void VerifyChangeGradesUnchecked()
        {
            Assert.False(WebDriver.FindElement(SelectGradeDistinction).Selected);
            Assert.False(WebDriver.FindElement(SelectGradeMerit).Selected);
            Assert.False(WebDriver.FindElement(SelectGradePass).Selected);
            Assert.False(WebDriver.FindElement(SelectGradeUnclassified).Selected);
        }

        public static void SelectGrade(string grade)
        {
            switch (grade)
            {
                case "Grade Distinction":
                    ClickElement(SelectGradeDistinction);
                    break;
                case "Grade Merit":
                    ClickElement((SelectGradeMerit));
                    break;
                case "Grade PAss":
                    ClickElement(SelectGradePass);
                    break;
                case "Grade Unclassified":
                    ClickElement(SelectGradeUnclassified);
                    break;
            }
        }
    }
}
