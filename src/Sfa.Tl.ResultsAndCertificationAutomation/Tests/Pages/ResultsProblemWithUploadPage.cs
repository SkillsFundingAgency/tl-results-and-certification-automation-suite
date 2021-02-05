using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class ResultsProblemWithUploadPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "results-file-upload-service-problem");
        private const string PageTitle = "Results file upload - Problem with the service page – Manage T Level results – GOV.UK";
        private const string ExpectedPageHeader = "Sorry, there is a problem with the service";
        public static string ExpectedSubHeaderText = "Submit your file again. If you keep getting this message contact the Manage T Level results team.";
        public static string BackToUploadFileButtonText = "Back to upload file";
        public static string BackToResultsButtonText = "Back to results";

        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By SubHeader { get; } = By.XPath("//*[@id='main-content']//p[1]");
      
        public static By BackToUploadFileButton { get; } = By.Id("uploadFileButton");
        public static By BackToResultsButton { get; } = By.Id("resultsButton");
        

        public static void VerifyAssesmenEntryUploadProblemPage()
        {
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(ExpectedSubHeaderText, WebDriver.FindElement(SubHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(BackToUploadFileButtonText, WebDriver.FindElement(BackToUploadFileButton).Text);
            Assert.AreEqual(BackToResultsButtonText, WebDriver.FindElement(BackToResultsButton).Text);
        }


        public static void PressBackToUploadButton()
        {
            ClickElement(BackToUploadFileButton);
        }

        public static void PressBackToResultsButton()
        {
            ClickElement(BackToResultsButton);
        }

        public static void NavigateToResultsUploadProblemPage()
        {
            NavigateToUrl(PageUrl);
        }
    }
}
