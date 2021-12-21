using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class AssessmentEntriesAddCoreAssessmentEntryPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "assessment-entry-add-core");
        private const string PageTitle = "Add core - Assessment entries – Manage T Level results – GOV.UK";
        private const string ErrorPageTitle = "Error: Add core - Assessment entries – Manage T Level results – GOV.UK";
        private const string ExpectedPageHeader = "Add core component assessment entry to ";
        private const string ExpectedSubPageHeader = "Is this learner entering an assessment for their core component in ";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By SubHeader { get; } = By.XPath("//*[contains(text(),'Is this learner entering an assessment for their core component in')]");
        private static By YesRadioButton { get; } = By.XPath("//*[contains(text(),'Yes, add entry to')]");
        private static By NoRadioButton { get; } = By.XPath("//*[contains(text(),'No, do not add entry to')]");
        private static By SubmitButton { get; } = By.Id("submitButton");
        public static By BackLink { get; } = By.Id("backLink");
        public static string ExpectedSubmitButtonText = "Submit";
        public static string ExpectedYesRadioText = "Yes, add entry to ";
        public static string ExpectedNoRadioText = "No, do not add entry to ";

        public static string NoRadioSelectedErrorMessage = "Select whether the learner is entering an assessment";
        public static By MainNoRadioButtonSelectedError = By.XPath("//*[@id='addCoreAssessmentForm']//a");
        public static By SubNoRadioButtonSelectedError = By.XPath("//*[@id='main-content']//div[2]//span");
        private static By LearnerDetailsElement { get; } = By.Id("addCoreAssessmentForm");


        public static void VerifyAddCoreComponentAssessmentEntryPage()
        {
            string CurrentAssessmentSeries = SqlQueries.GetAssessmentSeries();
            string ExpectedPageHeader1 = ExpectedPageHeader + CurrentAssessmentSeries.ToLower();
            string ExpectedSubPageHeader1 = ExpectedSubPageHeader + CurrentAssessmentSeries.ToLower() + "?";
            string ExpectedYesRadioText1 = ExpectedYesRadioText + CurrentAssessmentSeries.ToLower();
            string ExpectedNoRadioText1 = ExpectedNoRadioText + CurrentAssessmentSeries.ToLower();
         

            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedPageHeader1, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(ExpectedSubmitButtonText, WebDriver.FindElement(SubmitButton).Text);
            Assert.AreEqual(ExpectedYesRadioText1, WebDriver.FindElement(YesRadioButton).Text);
            Assert.AreEqual(ExpectedNoRadioText1, WebDriver.FindElement(NoRadioButton).Text);
            Assert.AreEqual(ExpectedSubPageHeader1, WebDriver.FindElement(SubHeader).Text);
        }

        public static void VerifyLearnerDetails(string ULN)
        {
            string ExpectedName = "4714 Name 1 Name 2";
            string ExpectedProvider = "Barnsley College";
            string ExpectedDOB = "10 January 2006";
            string ExpectedTLevel = "T Level in Building Services Engineering for Construction";
            string ExpectedUKPRN = "10000536";

            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(ULN));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(ExpectedName));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(ExpectedDOB));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(ExpectedProvider));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(ExpectedUKPRN));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(ExpectedTLevel));
        }

        public static void VerifyRadioButtonsNotPrepopulated()
        {
            Assert.AreEqual(false, WebDriver.FindElement(YesRadioButton).Selected);
            Assert.AreEqual(false, WebDriver.FindElement(NoRadioButton).Selected);
        }

        public static void PressSubmitButton()
        {
            ClickElement(SubmitButton);
        }

        public static void PressYesRadioButton()
        {
            ClickElement(YesRadioButton);
            ClickElement(SubmitButton);
        }

        public static void PressNoRadioButton()
        {
            ClickElement(NoRadioButton);
            ClickElement(SubmitButton);
        }

        public static void PressBackLink()
        {
            ClickElement(BackLink);
        }

        public static void VerifyNoRadioButtonSelectedError()
        {
            Assert.IsTrue(WebDriver.FindElement(MainNoRadioButtonSelectedError).Text.Contains(NoRadioSelectedErrorMessage));
            Assert.IsTrue(WebDriver.FindElement(SubNoRadioButtonSelectedError).Text.Contains(NoRadioSelectedErrorMessage));
            Assert.AreEqual(ErrorPageTitle, WebDriver.Title);
        }
    }
}
