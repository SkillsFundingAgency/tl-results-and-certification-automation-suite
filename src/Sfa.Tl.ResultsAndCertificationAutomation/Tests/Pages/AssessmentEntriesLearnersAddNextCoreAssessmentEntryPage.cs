using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class AssessmentEntriesLearnersAddNextCoreAssessmentEntryPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "add-core-assessment-entry-next-available-series");
        private const string PageTitle = "Do you want to add a core assessment entry to the next available series page – Manage T Level results – GOV.UK";
        private const string ExpectedPageHeader = "Do you want to add a core assessment entry to the next available series?";
        private const string ExpectedSubPageHeader = "Summer 2021 is the only series available.";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By SubHeader { get; } = By.XPath("//*[contains(text(),'Summer 2021 is the only')]");
        private static By YesRadioButton { get; } = By.XPath("//*[contains(text(),'Yes, add to Summer 2021')]");
        private static By NoRadioButton { get; } = By.XPath("//*[contains(text(),'No, do not add to Summer 2021')]");
        private static By SubmitButton { get; } = By.Id("submitButton");
        public static By BackLink { get; } = By.Id("backLink");
        public static string ExpectedSubmitButtonText = "Submit";
        public static string ExpectedYesRadioText = "Yes, add to Summer 2021";
        public static string ExpectedNoRadioText = "No, do not add to Summer 2021";

        public static string NoRadioSelectedErrorMessage = "Select yes to add to Summer 2021";
        public static By MainNoRadioButtonSelectedError = By.XPath("//*[@id='addCoreAssessmentForm']//a");
        public static By SubNoRadioButtonSelectedError = By.XPath("//*[@id='main-content']//div[2]//span");

        public static void VerifyAddCoreAssessmentEntriesPage()
        {
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(ExpectedSubmitButtonText, WebDriver.FindElement(SubmitButton).Text);
            Assert.AreEqual(ExpectedYesRadioText, WebDriver.FindElement(YesRadioButton).Text);
            Assert.AreEqual(ExpectedNoRadioText, WebDriver.FindElement(NoRadioButton).Text);
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
        }
    }
}
