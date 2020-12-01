using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class AssessmentEntriesWithdrawnLearnerPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "learners-assessment-entries-withdrawn-learner");
        private const string PageTitle = "Learner's assessment entries - Withdrawn learner page – Manage T Level results – GOV.UK";
        private const string WithdrawnText =  "This learner's registration has been withdrawn";
        private const string ExpectedPageHeader = "Learner's assessment entries";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By SubHeaderULN { get; } = By.XPath("//*[@id='main-content']//h2");
        private static By SubHeaderName { get; } = By.XPath("//*[@id='main-content']//p[1]");
        private static By SubHeaderProvider { get; } = By.XPath("//*[@id='main-content']//p[2]");
        private static By SubHeaderWithdrawnText { get; } = By.XPath("//*[@id='main-content']//p[3]");
        public static By SearchAgainLink { get; } = By.XPath("//*[@id='main-content']//p[5]/a");
        public static By ViewLearnerDetailsLink { get; } = By.XPath("//*[@id='main-content']//p[4]/a");
        public static By HomeBreadcrumb { get; } = By.Id("breadcrumb0");
        public static By AssessMentEntriesBreadcrumb { get; } = By.Id("breadcrumb1");
        public static By SearchForALearnerBreadcrumb { get; } = By.Id("breadcrumb2");


        public static void VerifyAssessmentEntriesWithdrawnLearnerPage()
        {
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(WithdrawnText, WebDriver.FindElement(SubHeaderWithdrawnText).Text);
        }

        public static void VerifyDynamicHeaders()
        {
            //The registration being asserted has been created using data from the Constants class
            string ExpectedULNString = "ULN: " + Constants.ManualRegULN;
            Assert.AreEqual(ExpectedULNString, WebDriver.FindElement(SubHeaderULN).Text);
            string ExpectedNameString = "Name: " + Constants.ManualRegFirstName + " " + Constants.ManualRegLastName;
            Assert.AreEqual(ExpectedNameString, WebDriver.FindElement(SubHeaderName).Text);
            string ExpectedProvider = "Provider: " + RegistrationsManualPage.InputPovider;
            Assert.AreEqual(ExpectedProvider, WebDriver.FindElement(SubHeaderProvider).Text);
        }

        public static void PressViewLearnersRegistrationDetailsLink()
        {
            ClickElement(ViewLearnerDetailsLink);
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


    }
}
