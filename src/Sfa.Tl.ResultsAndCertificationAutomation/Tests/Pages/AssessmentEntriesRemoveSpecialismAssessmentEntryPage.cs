using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class AssessmentEntriesRemoveSpecialismAssessmentEntryPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "assessment-entry-remove-specialisms");
        private const string PageTitle = "Remove specialism(s) - Assessment entry – Manage T Level results – GOV.UK";
        private const string ErrorPageTitle = "Error: Remove specialism(s) - Assessment entry – Manage T Level results – GOV.UK";
        private const string ExpectedPageHeader = "Remove occupational specialism(s) assessment entry from ";
        private const string ExpectedSubPageHeader = "Would you like to remove the ";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By SubHeader { get; } = By.XPath("//*[contains(text(),'Would you like to remove the')]");
        private static By YesRadioButton { get; } = By.XPath("//*[contains(text(),'Yes, remove the entry from')]");
        private static By NoRadioButton { get; } = By.XPath("//*[contains(text(),'No, do not remove the entry from')]");
        private static By SubmitButton { get; } = By.Id("submitButton");
        public static By BackLink { get; } = By.Id("backLink");
        public static string ExpectedSubmitButtonText = "Submit";
        public static string ExpectedYesRadioText = "Yes, remove the entry from ";
        public static string ExpectedNoRadioText = "No, do not remove the entry from ";

        public static string NoRadioSelectedErrorMessage = "Select whether the assessment entry is being removed";
        public static By MainNoRadioButtonSelectedError = By.XPath("//*[@id='main-content']/form/div/div/div[1]/div/ul/li/a");
        public static By SubNoRadioButtonSelectedError = By.XPath("//*[@id='main-content']//div[2]//span");
        private static By LearnerDetailsElement { get; } = By.XPath("//*[@id='main-content']/form");


        public static void VerifyRemoveSpecialismAssessmentEntryPage(string Specialism)
        {
            string CurrentAssessmentSeries = SqlQueries.GetSpecialismAssessmentSeries();
            string ExpectedPageHeader1 = ExpectedPageHeader + CurrentAssessmentSeries.ToLower();
            string ExpectedSubPageHeader1 = ExpectedSubPageHeader + Specialism + " from " + CurrentAssessmentSeries.ToLower() + " for this learner?";
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
