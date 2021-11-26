using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class AssessmentEntriesLearnersDetailsPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "assessment-entry-learner-details");
        private const string PageTitle = "Learner details - Assessment entries – Manage T Level results – GOV.UK";
        private const string ExpectedPageHeader = "Learner's assessment entries";
        private const string ExpectedSubPageHeader = "Learner's details";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By SubHeader { get; } = By.XPath("//*[@id='main-content']/div/div/h2");

        private static By LearnerDetailsElement { get; } = By.XPath("//*[@id='main-content']/div/div/dl");
        private static By CoreSpecialismTextElement { get; } = By.Id("add-entries");

        private static By SearchAgainButton { get; } = By.Id("searchAgainButton");

        private static By AddAnOccupationalSpecialismLink { get; } = By.LinkText("Add an occupational specialism to this learner's record");
        private static By HomeBreadcrumb { get; } = By.Id("breadcrumb0");
        private static By AssessmentsBreadcrumb { get; } = By.Id("breadcrumb1");
        private static By SearchForALearnerBreadcrumb { get; } = By.Id("breadcrumb2");

        public static void VerifyAssessmentEntriesDetailsPage()
        {
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.IsTrue(WebDriver.FindElement(SubHeader).Text.Contains(ExpectedSubPageHeader));
        }

        public static void VerifyLearnerDetails(string ULN)
        {
            string ExpectedName = "Db FirstName Db LastName";
            string ExpectedProvider = "Automation Test1";
            string ExpectedDOB = "01 January 2001";
            string ExpectedTLevel = "T Level in Agriculture, Environmental and Animal Care";

            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(ULN));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(ExpectedName));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(ExpectedDOB));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(ExpectedProvider));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(ExpectedTLevel));
        }

        public static void VerifyCoreDetailsText(string CoreText)
        {
            Assert.IsTrue(WebDriver.FindElement(CoreSpecialismTextElement).Text.Contains(CoreText));
        }

        public static void VerifySpecialismDetailsText(string SpecialismText)
        {
            Assert.IsTrue(WebDriver.FindElement(CoreSpecialismTextElement).Text.Contains(SpecialismText));
        }


        public static void PressSearchAgainButton()
        {
            ClickElement(SearchAgainButton);
        }

        public static void PressAddOccupationalSpecialismLink()
        {
            ClickElement(AddAnOccupationalSpecialismLink);
        }

        public static void PressHomeBreadcrumb()
        {
            ClickElement(HomeBreadcrumb);
        }
        public static void PressAssessmentsBreadcrumb()
        {
            ClickElement(AssessmentsBreadcrumb);
        }
        public static void PressSearchForALearnerBreadcrumb()
        {
            ClickElement(SearchForALearnerBreadcrumb);
        }

        public static void VerifyAddOccupationalSpecialismLinkText()
        {
            Assert.IsTrue(WebDriver.FindElement(AddAnOccupationalSpecialismLink).Text.Contains("Add an occupational specialism to this learner's record"));

        }
    }
}
