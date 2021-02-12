using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class ResultsLearnersResultsPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "learners-results");
        private static readonly string PageTitle = "Learner’s results page – Manage T Level results – GOV.UK";
        
        public static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        public static readonly string ExpectedPageHeaderText = "Learner’s results";
        public static By ULNTextLabel { get; } = By.XPath("//*[@id='main-content']//h2");

        public static By NameTextLabel { get; } = By.XPath("//*[@id='main-content']//p[1]");
        public static By ProviderTextLabel { get; } = By.XPath("//*[@id='main-content']//p[2]");
        public static By CoreTextLabel { get; } = By.XPath("//*[contains(text(),'Core:')]");
        public static By SpecialismTextLabel { get; } = By.XPath("//*[contains(text(),'Specialism:')]");
        public static By CoreAssessmentEntryTextLabel { get; } = By.XPath("//*[contains(text(),'Core result cannot')]");
                                                           
        public static By SpecialismAssessmentEntryTextLabel { get; } = By.XPath("//*[contains(text(),'Specialism result cannot be entered')]");
        public static By SearchAgainLink { get; } = By.XPath("//*[contains(text(),'Search again')]");

        public static By AssessmentSeriesLabel { get; } = By.XPath("//*[contains(text(),'Summer')]");
        public static By GradeLabel { get; } = By.XPath("//*[contains(text(),'Grade')]");
        public static By ResultLabel = By.XPath("//*[@id='main-content']//dt");
        public static By AddResultLink = By.Id("coreresult");
        public static readonly string ExpectedResultLabelText = "Result";

        public static By HomeBreadcrumb { get; } = By.Id("breadcrumb0");
        public static By ResultsBreadcrumb { get; } = By.Id("breadcrumb1");
        public static By SearchForLearnerBreadcrumb { get; } = By.Id("breadcrumb2");


        public static new void ClickButton(By locator)
        {
            WebDriver.FindElement((locator)).Click();
        }
        public static void VerifyLearnersResultsPage(string ULN)
        {
            string ULNText = "ULN: " + ULN;
            string ProviderText = "Provider: " + "Automation Test2 (99999902)";
            string NameText = "Name: " + "Test Analyst";

            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedPageHeaderText, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(NameText, WebDriver.FindElement(NameTextLabel).Text);
            Assert.AreEqual(ULNText, WebDriver.FindElement(ULNTextLabel).Text);
            Assert.AreEqual(ProviderText, WebDriver.FindElement(ProviderTextLabel).Text);
        }

        public static void VerifyCore(string CoreText)
        {
            Assert.AreEqual(CoreText, WebDriver.FindElement(CoreTextLabel).Text);
        }

        public static void VerifySpecialismAdded(string SpecialismText)
        {
            Assert.AreEqual(SpecialismText, WebDriver.FindElement(SpecialismTextLabel).Text);
        }

        public static void VerifyCoreAssessmentEntryText(string NoAssessessmentAddedText)
        {
            Assert.AreEqual(NoAssessessmentAddedText, WebDriver.FindElement(CoreAssessmentEntryTextLabel).Text);
        }

        public static void VerifySpecialismAssessmentEntryText(string SpecialismText)
        {
            Assert.AreEqual(SpecialismText, WebDriver.FindElement(SpecialismAssessmentEntryTextLabel).Text);
        }

        public static void VerifyAssessmenSeriesText(string Series, string Grade)
        {
            Assert.AreEqual(Series, WebDriver.FindElement(AssessmentSeriesLabel).Text);
            Assert.AreEqual(Grade, WebDriver.FindElement(GradeLabel).Text);
            Assert.AreEqual(ExpectedResultLabelText, WebDriver.FindElement(ResultLabel).Text);
        }

        public static void VerifyAddEntryLink(string AddEntryLink)
        {
            Assert.IsTrue(WebDriver.FindElement(AddResultLink).Text.Contains(AddEntryLink));
        }



        public static void VerifyAssessmentEntryTextNotPresent()
        {
            bool expectedResponse = false;
            Assert.AreEqual(expectedResponse, IsPresent(SpecialismAssessmentEntryTextLabel));
            
        }

        public static void ClickHomeBreadcrumb()
        {
            WebDriver.FindElement((HomeBreadcrumb)).Click();
        }

        public static void ClickResultsBreadcrumb()
        {
            WebDriver.FindElement((ResultsBreadcrumb)).Click();
        }

        public static void ClickSearchAgainBreadcrumb()
        {
            WebDriver.FindElement((SearchForLearnerBreadcrumb)).Click();
        }

        public static void MaximiseWindow()
        {
            WebDriver.Manage().Window.Maximize();
        }
        public static void ClickSearchAgainLink()
        {
            WebDriver.FindElement((SearchAgainLink)).Click();
        }

        public static void ClickAddResultLink()
        {
            ClickElement(AddResultLink);
        }

    }
}
