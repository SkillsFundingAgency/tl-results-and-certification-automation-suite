using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class AssessmentEntriesLearnersAssessmentEntriesPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "assessment-entry-learner-details");
        private const string PageTitle = "Learner details - Assessment entries – Manage T Level results – GOV.UK";
        private const string ExpectedPageHeader = "Learner's assessment entries";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By SubHeaderUln { get; } = By.XPath("//*[@id='main-content']/div/div/dl/div[2]");
        private static By SubHeaderName { get; } = By.XPath("//*[@id='main-content']/div/div/dl/div[1]");
        private static By CoreDetails { get; } = By.XPath("//*[@id='main-content']/div/div/h3[1]");
        private static By SpecialismDetails { get; } = By.XPath("//*[@id='main-content']/div/div/h3[2]");
        private static By SearchAgainLink { get; } = By.XPath("//*[contains(text(),'Search again')]");
        private static By ViewAndAmendLearnerDetailsLink { get; } = By.XPath("//*[contains(text(),'View and amend')]");
        private static By HomeBreadcrumb { get; } = By.Id("breadcrumb0");
        private static By AssessMentEntriesBreadcrumb { get; } = By.Id("breadcrumb1");
        private static By SearchForALearnerBreadcrumb { get; } = By.Id("breadcrumb2");
        private const string ExpectedCoreText = "Core: Agriculture, Environmental and Animal Care (77777777)";
        private const string ExpectedSpecialismText = "Specialism: Agriculture, Land Management and Production (70000002)";
        private const string ExpectedCoreAssessmentEntry = "Summer 2021";
        private const string ExpectedNoCoreAssessmentEntry = "Not specified";

        private static readonly string ExpectedNoSpecialismAssessmentEntry = "Available to add after Autumn 2021 series has passed";
        //public static string ExpectedSpecialismAssessmentEntry = "Autumn 2022";
        private const string ExpectedSpecialismAssessmentEntry = "Available to add after Autumn 2021 series has passed";
        private const string ExpectedCoreAndSpecialismHeader = "First assessment entry";
        private const string ExpectedSpecialismAsessmentEntryText = "Available to add after Autumn 2021 series has passed";
        private static readonly By CoreAssessmentEntryHeading = By.XPath("//*[@id='main-content']//dl[1]/div/dt");
        private static readonly By SpecialismAssessmentEntryHeading = By.XPath("//*[@id='main-content']//dl[2]/div/dt");
        public static By CoreAssessmentDetails { get; } = By.XPath("//*[@id='main-content']//dl[1]//p");
        private static By SpecialismAssessmentDetails { get; } = By.XPath("//*[@id='main-content']//dl[2]//p");
        public static readonly By AddRemoveEntryLink = By.Id("coreassessmententry");

        public static void VerifyLearnersAssessmentEntriesPage()
        {
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        }

        public static void VerifyCoreSpecialismTableHeaders()
        {
            Assert.AreEqual(ExpectedCoreAndSpecialismHeader, WebDriver.FindElement(SpecialismAssessmentEntryHeading).Text);
            Assert.AreEqual(ExpectedCoreAndSpecialismHeader, WebDriver.FindElement(CoreAssessmentEntryHeading).Text);
        }

        public static void VerifyAddRemoveLinkText(string LinkText)
        {
            //Assert.AreEqual(LinkText, WebDriver.FindElement(AddRemoveEntryLink).Text);
            Assert.IsTrue(WebDriver.FindElement(AddRemoveEntryLink).Text.Contains(LinkText));
        }

        public static void VerifySpecialismAssessmentEntryText()
        {
            Assert.AreEqual(ExpectedSpecialismAsessmentEntryText, WebDriver.FindElement(SpecialismAssessmentDetails).Text);
        }

        public static void VerifyDynamicHeaders(string uln)
        {
            //The registration being asserted has been created using data from the Constants class
            var expectedUlnString = "ULN\r\n" + uln;
            Assert.AreEqual(expectedUlnString, WebDriver.FindElement(SubHeaderUln).Text);
            const string expectedNameString = "Name\r\n" + Constants.ManualRegFirstName + " " + Constants.ManualRegLastName;
            Assert.AreEqual(expectedNameString, WebDriver.FindElement(SubHeaderName).Text);
            //string ExpectedProvider = "Provider\r\n" + RegistrationsManualPage.InputPovider;
            //Assert.AreEqual(ExpectedProvider, WebDriver.FindElement(SubHeaderProvider).Text);
        }

        public static void VerifyDataCreatedFromDb(string uln)
        {
            var expectedUlnString = "ULN\r\n" + uln;
            Assert.AreEqual(expectedUlnString, WebDriver.FindElement(SubHeaderUln).Text);
            const string expectedNameString = "Name\r\n" + Constants.DbFirstName + " " + Constants.DbLastName;
            Assert.AreEqual(expectedNameString, WebDriver.FindElement(SubHeaderName).Text);
            //string ExpectedProvider = "Provider: " + Constants.DbProviderName;
            //Assert.AreEqual(ExpectedProvider, WebDriver.FindElement(SubHeaderProvider).Text);
        }

        public static void VerifyCoreAndSpecialismText()
        {     
            Assert.AreEqual(ExpectedCoreText, WebDriver.FindElement(CoreDetails).Text);
            Assert.AreEqual(ExpectedSpecialismText, WebDriver.FindElement(SpecialismDetails).Text);
        }

        public static void VerifyCoreAssessmentEntryDisplayed()
        {
            Assert.AreEqual(ExpectedCoreAssessmentEntry, WebDriver.FindElement(CoreAssessmentDetails).Text);
        }

        public static void VerifySummer2021CoreAssessmentEntryDisplayed(string AssessmentEntry)
        {
            Assert.AreEqual(AssessmentEntry, WebDriver.FindElement(CoreAssessmentDetails).Text);
        }

        public static void VerifyNoCoreAssessmentEntryDisplayed()
        {
            Assert.AreEqual(ExpectedNoCoreAssessmentEntry, WebDriver.FindElement(CoreAssessmentDetails).Text);
        }

        public static void VerifySpecialismAssessmentEntryDisplayed()
        {
            Assert.AreEqual(ExpectedSpecialismAssessmentEntry, WebDriver.FindElement(SpecialismAssessmentDetails).Text);
        }

        public static void VerifyNoSpecialismAssessmentEntryDisplayed()
        {
            Assert.AreEqual(ExpectedNoSpecialismAssessmentEntry, WebDriver.FindElement(SpecialismAssessmentDetails).Text);
        }

        public static void PressViewAmendLearnersRegistrationDetailsLink()
        {
            ClickElement(ViewAndAmendLearnerDetailsLink);
        }

        public static void PressSearchAgain()
        {
            ClickElement(SearchAgainLink);
        }

        public static void PressHomeBreadcrumb()
        {
            ClickElement(HomeBreadcrumb);
        }

        public static void PressAssessmentEntriesBreadcrumb()
        {
            ClickElement(AssessMentEntriesBreadcrumb);
        }

        public static void PressSearchForALearnerBreadcrumb()
        {
            ClickElement(SearchForALearnerBreadcrumb);
        }

        public static void ClickAddEntryLink()
        {
            ClickElement(AddRemoveEntryLink);
        }
    }
}
