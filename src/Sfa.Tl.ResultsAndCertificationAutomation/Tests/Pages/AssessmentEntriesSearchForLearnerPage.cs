using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class AssessmentEntriesSearchForLearnerPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "assessment-entries-learner-search");
        private const string SearchForLearnerPageTitle = "Assessment entries - Search for a learner page – Manage T Level results – GOV.UK";
        private static readonly string SearchForLearnerPageHeader = "Search for a learner";
        private const string SearchForLearnerPageSubHeading = "You can add, view and amend a learner's assessment entries.";
        private const string SearchForLearnerPageSubHeading1 = "ULN must be 10 digits long";
        //private const string InvalidULNErrorMessage = "You can add, view and amend a learner's assessment entries";
        private const string ErrorPageTitle = "Error: Assessment entries - Search for a learner page – Manage T Level results – GOV.UK";
        private const string ErrorMessageInvalidULN = "Enter a valid ULN";
        private const string ErrorMessageNullULN = "Enter a ULN";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By SubHeader { get; } = By.XPath("//*[@id='main-content']//fieldset/p");
        private static By SubHeader1 { get; } = By.XPath("//*[@id='main-content']//span[1]");
       
        public static By SearchBtn { get; } = By.Id("searchButton");
        public static By SearchField { get; } = By.Id("searchuln");
        public static By MainErrorMessageInvalidULN = By.XPath("//*[@id='main-content']//ul/li/a");
        public static By SubErrorMessage = By.XPath("//*[@id='main-content']//div/span[2]");
        public static By MainErrorMessage = By.XPath("//*[@id='main-content']//ul/li/a");
        public static By SubErrorMessageMissingULN = By.XPath("//*[@id='main-content']//div/span[2]");
        public static By HomeBreadcrumb { get; } = By.Id("breadcrumb0");
        public static By AssessMentEntriesBreadcrumb { get; } = By.Id("breadcrumb1");

     
        public static void VerifyAssessmentEntriesSearchForLearnerPage()
        {
            Assert.AreEqual(SearchForLearnerPageTitle, WebDriver.Title);
            Assert.AreEqual(SearchForLearnerPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        }

        public static void VerifyAssessmentEntriesSearchForLearnerPageText()
        {
            Assert.AreEqual(SearchForLearnerPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(SearchForLearnerPageSubHeading, WebDriver.FindElement(SubHeader).Text);
            Assert.AreEqual(SearchForLearnerPageSubHeading1, WebDriver.FindElement(SubHeader1).Text);
        }

        public static void EnterULN(string ULN)
        {
            WebDriver.FindElement(SearchField).SendKeys(ULN);
            ClickElement(SearchBtn);
        }

        public static void PressSearch()
        {
            ClickElement(SearchBtn);
        }

        public static void PressHomeBreadcrumb()
        {
            ClickElement(HomeBreadcrumb);
        }

        public static void PressAssessmentEntriesBreadcrumb()
        {
            ClickElement(AssessMentEntriesBreadcrumb);
        }


        public static void VerifyInvalidULNErrorMessage()
        {
            Assert.AreEqual(ErrorPageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.FindElement(MainErrorMessage).Text.Contains(ErrorMessageInvalidULN));
            Assert.IsTrue(WebDriver.FindElement(SubErrorMessage).Text.Contains(ErrorMessageInvalidULN));
        }


        public static void VerifyNullULNErrorMessage()
        {
            Assert.AreEqual(ErrorPageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.FindElement(MainErrorMessage).Text.Contains(ErrorMessageNullULN));
            Assert.IsTrue(WebDriver.FindElement(SubErrorMessage).Text.Contains(ErrorMessageNullULN));
        }

        public static void VerifyULNSearchFieldValue(string ULN)
        {
            Assert.AreEqual(ULN, WebDriver.FindElement(SearchField).GetAttribute("value"));
        }

        public static void VerifyULNSearchFieldIsEmpty()
        {
            string NullString = "";
            Assert.AreEqual(NullString, WebDriver.FindElement(SearchField).GetAttribute("value"));
        }




    }
}
