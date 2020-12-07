using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class AssessmentEntriesAssessmentRemovedSuccessfullyPage : ElementHelper
    {
        private static string ExpectedChangeNamePageUrl => string.Concat(StartPage.StartPageUrl, "assessment-entry-removed-confirmation");
        public static By BackToLearnersAssessmentEntriesButton = By.Id("backButton");
        private static string ExpectedPageHeading = "Assessment entry removed successfully";
        private static string ExpectedPageTitle = "Assessment entry removed confirmation page – Manage T Level results – GOV.UK";
        private static string ExpectedButtonText = "Back to learner's assessment entries";
        
        private static readonly By PageHeader = By.XPath("//*[@id='main-content']//h1");
        private static readonly By PageSubHeader = By.XPath("//*[@class='govuk-panel__body']");

        public static void ClickBackToAssessmentEntriesButton()
        {
            ClickElement(BackToLearnersAssessmentEntriesButton);
        }
                
        public static void VerifyRemoveAssessmentEntrySuccessPage(string ULN)
        {
            string ExpectedPageSubHeading = "ULN: " + ULN;
            Assert.AreEqual(ExpectedChangeNamePageUrl, WebDriver.Url);
            Assert.AreEqual(ExpectedPageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedPageHeading, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(ExpectedPageSubHeading, WebDriver.FindElement(PageSubHeader).Text);
            Assert.AreEqual(ExpectedButtonText, WebDriver.FindElement(BackToLearnersAssessmentEntriesButton).Text);
         
        }

        
    }
}
