using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class ResultsLearnersResultsPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "learner-results");
        private static readonly string PageTitle = "Learner's results – Manage T Level results – GOV.UK";
        
        public static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        public static readonly string ExpectedPageHeaderText = "Db FirstName Db LastName's results";
        public static By ULNTextLabel { get; } = By.XPath("//*[@id='main-content']");
        public static By pageContent { get; } = By.XPath("//*[@id='main-content']");
        public static By NameTextLabel { get; } = By.XPath("//*[@id='main-content']//p[1]");
        public static By ProviderTextLabel { get; } = By.XPath("//*[@id='main-content']//p[2]");
        public static By CoreTextLabel { get; } = By.XPath("//*[contains(text(),'Core:')]");
        public static By SpecialismTextLabel { get; } = By.XPath("//*[contains(text(),'Specialism:')]");
        public static By CoreAssessmentEntryTextLabel { get; } = By.XPath("//*[contains(text(),'Core result cannot')]");
        private static By summaryList { get; } = By.XPath("//*[@class='govuk-summary-list']");
        private static string appealedTxt = "Being Appealed";
        private static string appealHeaderTxt = "This learner's results cannot be changed because they are appealing a grade.";
        private static string finalHeaderTxt = "This result is final as the outcome of an appeal has been recorded. If you need to change the grade please contact us.";


        public static By SpecialismAssessmentEntryTextLabel { get; } = By.XPath("//*[contains(text(),'Specialism result cannot be entered')]");
        public static By SearchAgainLink { get; } = By.XPath("//*[contains(text(),'Search again')]");
        public static By searchAgainBtn { get; } = By.Id("buttonSearchAgain");

        public static By AssessmentSeriesLabel { get; } = By.XPath("//*[contains(text(),'Summer')]");
        public static By GradeLabel { get; } = By.XPath("//*[contains(text(),'Grade')]");
        public static By AddResultLink = By.Id("pathwaygrade");
        public static readonly string ExpectedResultLabelText = "Result";

        public static By HomeBreadcrumb { get; } = By.Id("breadcrumb0");
        public static By ResultsBreadcrumb { get; } = By.Id("breadcrumb1");
        public static By SearchForLearnerBreadcrumb { get; } = By.Id("breadcrumb2");
        private static By contactUsLink = By.Id("contactusLink");

        public static By ChangeLink = By.Id("pathwaygrade");
        public static new void ClickButton(By locator)
        {
            WebDriver.FindElement((locator)).Click();
        }
        public static void VerifyLearnersResultsPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedPageHeaderText, WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyLearnerResultPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedPageHeaderText, WebDriver.FindElement(PageHeader).Text);
        }

        public static void VerifyCore(string CoreText)
        {
            Assert.IsTrue(WebDriver.FindElement(pageContent).Text.Contains(CoreText));
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
            Assert.IsTrue(WebDriver.FindElement(pageContent).Text.Contains(Series));
            Assert.IsTrue(WebDriver.FindElement(pageContent).Text.Contains(Grade));
        }

        public static void VerifyAssessmenSeriesTextFINALState()
        {
            Assert.IsTrue(WebDriver.FindElement(pageContent).Text.Contains("A"));
            Assert.IsTrue(WebDriver.FindElement(pageContent).Text.Contains("Summer 2021"));
            Assert.IsTrue(WebDriver.FindElement(pageContent).Text.Contains("FINAL"));
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

        public static void ClickChangeResultLink()
        {
            ClickElement(ChangeLink);
        }

        public static void VerifyGradeText(string Grade)
        {
            Assert.IsTrue(WebDriver.FindElement(pageContent).Text.Contains(Grade));
        }
        public static void VerifyBeingAppealed()
        {
            //Assert.IsTrue(WebDriver.FindElement(summaryList).Text.Contains(appealedTxt));
            Assert.IsTrue(WebDriver.FindElement(pageContent).Text.Contains(appealHeaderTxt));
        }
        public static void VerifyFinalHeader()
        {
            Assert.IsTrue(WebDriver.FindElement(pageContent).Text.Contains(finalHeaderTxt));
        }
        public static void ClickSearchAgainBtn()
        {
            ClickButton(searchAgainBtn);
            ResultsSearchForALearnerPage.VerifyResultsSearchLearnerPage();
        }

        public static void ClickContactUsLink()
        {
            ClickButton(contactUsLink);
        }

    }
}
