using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class AssessmentEntriesProblemWithUploadPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "assessment-entries-file-upload-service-problem");
        private static readonly string PartialPageUrl = "assessment-entries-file-upload-service-problem";
        private const string PageTitle = "Assessment entries file upload - Problem with the service page – Manage T Level results – GOV.UK";
        private const string ExpectedPageHeader = "Sorry, there is a problem with the service";
        public static string ExpectedSubHeaderText = "Enter your assessment entry details again. If you keep getting this message contact the Manage T Level results team.";
        public static string StartAgainButtonText = "Start again";
        public static string BackToAssessmentEntriesButtonText = "Back to assessment entries";

        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By SubHeader { get; } = By.XPath("//*[@id='main-content']//p[1]");
      
        public static By StartAgainButton { get; } = By.XPath("//*[@id='main-content']//p[2]/a");
        public static By BackToAssessmentEntriesButton { get; } = By.XPath("//*[@id='main-content']//p[3]/a");
        

        public static void VerifyAssesmenEntryUploadProblemPage()
        {
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(ExpectedSubHeaderText, WebDriver.FindElement(SubHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(StartAgainButtonText, WebDriver.FindElement(StartAgainButton).Text);
            Assert.AreEqual(BackToAssessmentEntriesButtonText, WebDriver.FindElement(BackToAssessmentEntriesButton).Text);
        }


        public static void PressStartAgainButton()
        {
            ClickElement(StartAgainButton);
        }

        public static void PressBackToAssessmentEntriesButtonButton()
        {
            ClickElement(BackToAssessmentEntriesButton);
        }

        public static void NavigateToAssessmentEntriesUploadProblemPage()
        {
            NavigateTo(PartialPageUrl);
        }
    }
}
