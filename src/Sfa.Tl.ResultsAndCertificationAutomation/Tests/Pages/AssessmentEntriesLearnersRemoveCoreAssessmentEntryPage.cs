using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class AssessmentEntriesLearnersRemoveCoreAssessmentEntryPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "remove-core-assessment-entry");
        private const string PageTitle = "Are you sure you want to remove this core assessment entry page – Manage T Level results – GOV.UK";
        private const string ExpectedPageHeader = "Are you sure you want to remove this core assessment entry from Summer 2021?";
        private const string PageTitleError = "Error: Are you sure you want to remove this core assessment entry page – Manage T Level results – GOV.UK";

        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
       
        private static By YesRadioButton { get; } = By.XPath("//*[contains(text(),'Yes, remove the core entry')]");
        private static By NoRadioButton { get; } = By.XPath("//*[contains(text(),'No, do not remove the core entry')]");
        private static By SubmitButton { get; } = By.Id("submitButton");
        public static By BackLink { get; } = By.Id("backLink");
        public static string ExpectedSubmitButtonText = "Submit";
        public static string ExpectedYesRadioText = "Yes, remove the core entry";
        public static string ExpectedNoRadioText = "No, do not remove the core entry";

        public static string NoRadioSelectedErrorMessage = "Select yes to remove the core entry";
        public static By MainNoRadioButtonSelectedError = By.XPath("//*[@id='main-content']//div[1]//a");
        public static By SubNoRadioButtonSelectedError = By.XPath("//*[@class='govuk-error-message']");

        public static void VerifyRemoveCoreAssessmentEntryPage()
        {
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(ExpectedSubmitButtonText, WebDriver.FindElement(SubmitButton).Text);
            Assert.AreEqual(ExpectedYesRadioText, WebDriver.FindElement(YesRadioButton).Text);
            Assert.AreEqual(ExpectedNoRadioText, WebDriver.FindElement(NoRadioButton).Text);
        }
        public static void VerifyRemoveCoreAssessmentEntryErrorPage()
        {
            Assert.AreEqual(PageTitleError, WebDriver.Title);
            Assert.AreEqual(ExpectedPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
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
