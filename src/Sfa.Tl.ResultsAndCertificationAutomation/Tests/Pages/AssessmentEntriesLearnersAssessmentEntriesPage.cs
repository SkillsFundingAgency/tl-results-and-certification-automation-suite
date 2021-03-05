using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class AssessmentEntriesLearnersAssessmentEntriesPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "learners-assessment-entries");
        private const string PageTitle = "Learner’s assessment entries page – Manage T Level results – GOV.UK";
        private const string ExpectedPageHeader = "Learner's assessment entries";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By SubHeaderULN { get; } = By.XPath("//*[@id='main-content']//h2");
        private static By SubHeaderName { get; } = By.XPath("//*[@id='main-content']/div/div/p[1]");
        private static By SubHeaderProvider { get; } = By.XPath("//*[contains(text(),'Provider')]");
        private static By CoreDetails { get; } = By.XPath("//*[@id='main-content']/div/div/h3[1]");
        private static By SpecialismDetails { get; } = By.XPath("//*[@id='main-content']/div/div/h3[2]");
        public static By SearchAgainLink { get; } = By.XPath("//*[contains(text(),'Search again')]");
        public static By ViewAndAmendLearnerDetailsLink { get; } = By.XPath("//*[contains(text(),'View and amend')]");
        public static By HomeBreadcrumb { get; } = By.Id("breadcrumb0");
        public static By AssessMentEntriesBreadcrumb { get; } = By.Id("breadcrumb1");
        public static By SearchForALearnerBreadcrumb { get; } = By.Id("breadcrumb2");
        public static string ExpectedCoreText = "Core: Agriculture, Environmental and Animal Care (77777777)";
        public static string ExpectedSpecialismText = "Specialism: Agriculture, Land Management and Production (70000002)";
        public static string ExpectedCoreAssessmentEntry = "Summer 2021";
        public static string ExpectedNoCoreAssessmentEntry = "Not specified";
        public static string ExpectedNoSpecialismAssessmentEntry = "Available to add after Autumn 2021 series has passed";
        //public static string ExpectedSpecialismAssessmentEntry = "Autumn 2022";
        public static string ExpectedSpecialismAssessmentEntry = "Available to add after Autumn 2021 series has passed";
        public static string ExpectedCoreAndSpecialismHeader = "First assessment entry";
        public static string ExpectedSpecialismAsessmentEntryText = "Available to add after Autumn 2021 series has passed";
        public static By CoreAssessmentEntryHeading = By.XPath("//*[@id='main-content']//dl[1]/div/dt");
        public static By SpecialismAssessmentEntryHeading = By.XPath("//*[@id='main-content']//dl[2]/div/dt");
        public static By CoreAssessmentDetails { get; } = By.XPath("//*[@id='main-content']//dl[1]//p");
        private static By SpecialismAssessmentDetails { get; } = By.XPath("//*[@id='main-content']//dl[2]//p");
        public static By AddRemoveEntryLink = By.Id("coreassessmententry");



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

        public static void VerifyDynamicHeaders(string ULN)
        {
            //The registration being asserted has been created using data from the Constants class
            string ExpectedULNString = "ULN: " + ULN;
            Assert.AreEqual(ExpectedULNString, WebDriver.FindElement(SubHeaderULN).Text);
            string ExpectedNameString = "Name: " + Constants.ManualRegFirstName + " " + Constants.ManualRegLastName;
            Assert.AreEqual(ExpectedNameString, WebDriver.FindElement(SubHeaderName).Text);
            string ExpectedProvider = "Provider: " + RegistrationsManualPage.InputPovider;
            Assert.AreEqual(ExpectedProvider, WebDriver.FindElement(SubHeaderProvider).Text);
        }

        public static void VerifyDataCreatedFromDb(string uln)
        {
            string ExpectedULNString = "ULN: " + uln;
            Assert.AreEqual(ExpectedULNString, WebDriver.FindElement(SubHeaderULN).Text);
            string ExpectedNameString = "Name: " + Constants.DbFirstName + " " + Constants.DbLastName;
            Assert.AreEqual(ExpectedNameString, WebDriver.FindElement(SubHeaderName).Text);
            string ExpectedProvider = "Provider: " + Constants.DbProviderName;
            Assert.AreEqual(ExpectedProvider, WebDriver.FindElement(SubHeaderProvider).Text);
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
