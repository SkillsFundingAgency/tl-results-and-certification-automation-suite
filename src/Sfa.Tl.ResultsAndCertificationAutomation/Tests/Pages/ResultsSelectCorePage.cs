using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class ResultsSelectCorePage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "select-core-result");
        private static readonly string PageTitle = "Select the core result page – Manage T Level results – GOV.UK";
        
        public static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        public static readonly string ExpectedPageHeaderText = "Select the core result";
        public static By SubmitButton { get; } = By.XPath("//p/button");
        public static readonly string ExpectedSubmitButtonText = "Submit";
        public static By BackLink { get; } = By.Id("backLink");
        public static By SubHeader { get; } = By.XPath("//h1/p");
        public static By NotReceivedRadioButton { get; } = By.Id("hasgradeselected");
        public static By NotReceivedLabel { get; } = By.XPath("//div[1]/label");
        public static readonly string ExpectedNotRecievedText = "Not received";
        public static By GradeAStarLabel { get; } = By.XPath("//div[2]/label");
        public static readonly string ExpectedAStarGradeText = "A*";
        public static By GradeALabel { get; } = By.XPath("//div[3]/label");
        public static readonly string ExpectedAGradeText = "A";
        public static By GradeBLabel { get; } = By.XPath("//div[4]/label");
        public static readonly string ExpectedBGradeText = "B";
        public static By GradeCLabel { get; } = By.XPath("//div[5]/label");
        public static readonly string ExpectedCGradeText = "C";
        public static By GradeDLabel { get; } = By.XPath("//div[6]/label");
        public static readonly string ExpectedDGradeText = "D";
        public static By GradeELabel { get; } = By.XPath("//div[7]/label");
        public static readonly string ExpectedEGradeText = "E";
        public static By GradeUnclassifiedLabel { get; } = By.XPath("//div[8]/label");
        public static readonly string ExpectedUnclassifiedGradeText = "Unclassified";

 


        public static new void ClickButton(By locator)
        {
            WebDriver.FindElement((locator)).Click();
        }
        public static void VerifyAddCorePage(string Core, string AssessmentSeries)
        {
            string SubHeaderText = Core + " for " + AssessmentSeries;
           
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.FindElement(PageHeader).Text.Contains(ExpectedPageHeaderText));
            Assert.AreEqual(SubHeaderText, WebDriver.FindElement(SubHeader).Text);
            Assert.AreEqual(ExpectedNotRecievedText, WebDriver.FindElement(NotReceivedLabel).Text);
            Assert.AreEqual(ExpectedAStarGradeText, WebDriver.FindElement(GradeAStarLabel).Text);
            Assert.AreEqual(ExpectedAGradeText, WebDriver.FindElement(GradeALabel).Text);
            Assert.AreEqual(ExpectedBGradeText, WebDriver.FindElement(GradeBLabel).Text);
            Assert.AreEqual(ExpectedCGradeText, WebDriver.FindElement(GradeCLabel).Text);
            Assert.AreEqual(ExpectedDGradeText, WebDriver.FindElement(GradeDLabel).Text);
            Assert.AreEqual(ExpectedEGradeText, WebDriver.FindElement(GradeELabel).Text);
            Assert.AreEqual(ExpectedUnclassifiedGradeText, WebDriver.FindElement(GradeUnclassifiedLabel).Text);
            Assert.AreEqual(ExpectedSubmitButtonText, WebDriver.FindElement(SubmitButton).Text);
            Assert.AreEqual(true, WebDriver.FindElement(NotReceivedRadioButton).Selected);
        }

        public static void ClickSubmitButton()
        {
           ClickElement(SubmitButton);
        }
        public static void ClickBackLink()
        {
            ClickElement(BackLink);
        }

        public static void SelectAStarResult()
        {
            ClickElement(GradeAStarLabel);
            ClickElement(SubmitButton);
        }


    }
}
