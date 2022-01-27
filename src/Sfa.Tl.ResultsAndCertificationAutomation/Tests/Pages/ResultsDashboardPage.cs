using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class ResultsDashboardPage : ElementHelper
    {
        private static string ResultsDashoardUrl { get; } = string.Concat(StartPage.StartPageUrl, "results");
        private static By ResultsLink { get; } = By.LinkText("Results");
        private static By BreadCrumb0 { get; } = By.Id("breadcrumb0");
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By SuccessMsg { get; } = By.XPath("//*[@id='main-content']");
        private static string ResultsDashboardPageTitle { get; } = "Results – Manage T Level results – GOV.UK";
        public static By UploadResultLink { get; } = By.LinkText("Upload multiple results");
        public static By SearchLearnerLink { get; } = By.LinkText("Manage a result");
        // Upload results page
        private static string UploadResultsUrl { get; } = string.Concat(StartPage.StartPageUrl, "upload-results-file");
        private static string UploadResultsPageTitle { get; } = "Upload multiple results – Manage T Level results – GOV.UK";
        private static string UploadResultsErrorPageTitle { get; } = "Error: Upload multiple results – Manage T Level results – GOV.UK";
        private static string ResultsUploadUnsuccessUrl { get; } = string.Concat(StartPage.StartPageUrl, "results-upload-unsuccessful");
        private static string ResultsUploadUnsuccessTitle { get; } = "Results upload error – Manage T Level results – GOV.UK";
        public static string ResultsUploadStage2InvalidHeaderErrors = string.Concat("Data\\", "ResultsErrorInvalidHeader.csv");
        public static string ResultsUploadStage2NoDataErrors = string.Concat("Data\\", "ResultsErrorNoData.csv");
        public static string ResultsUploadStage2Errors = string.Concat("Data\\", "ResultsErrorStage2Validations.csv");
        public static string ResultsUploadStage3Errors = string.Concat("Data\\", "ResultsErrorStage3Validations.csv");
        public static string ResultsUploadStage3WithdrawnErrors = string.Concat("Data\\", "ResultsErrorStage3Withdrawn.csv");
        public static string ResultsUploadBlockAppealErrors = string.Concat("Data\\", "BlockResultUpdateForAppeal.csv");
        public static string ResultsUploadBlockFinalErrors = string.Concat("Data\\", "BlockResultUpdateForFinal.csv");
        // Upload Results success page
        private static string ResultsUploadSuccessMsg { get; } = "Results uploaded";
        private static string ResultsUploadSuccessPageTitle { get; } = "Results upload success – Manage T Level results – GOV.UK";
        private static string ResultsUploadSuccessUrl { get; } = string.Concat(StartPage.StartPageUrl, "results-upload-confirmation");
        public static By BackToResultsBtn { get; } = By.Id("backToResultsButton");
        public static string ResultsSuccessCountMsg { get; } = "You successfully sent results for 3 registrations.";
        public static string ResultSingleSuccessMsg { get; } = "You successfully sent results data for one registration.";
        public static By manageIndividualResultsLink { get; } = By.XPath("//*[contains (text(),'manage individual results')]");
        public static By uploadAnotherMultipleResultsFileLink { get; } = By.XPath("//*[contains (text(),'upload another multiple results file')]");
        public static By appealLink { get; } = By.XPath("//*[contains (text(),'appeal')]");
        public static By BackToHomeBtn { get; } = By.Id("backToHomeButton");
        public static By uploadAnotherFileBtn = By.Id("uploadAnotherFileButton");

        //Learner result page
        private static string LearnerResultPageTitle { get; } = "Learner's results – Manage T Level results – GOV.UK";
        private static string LearnerResultUrl { get; } = "learners-results";
        private static By addResult { get; } = By.XPath("//a[@id='pathwaygrade' and contains(text(),'Add result')]");
        public static By changeResult { get; } = By.XPath("//a[@id='pathwaygrade' and contains(text(),'Change')]");
        //Learner Withdrawn
        private static string LearnerResultWithdrawnPageTitle { get; } = "Learner withdrawn – Manage T Level results – GOV.UK";
        private static string LearnerResultWithdrawnUrl { get; } = "learners-results-withdrawn-learner";
        //Core result page
        private static string coreResultPageTitle { get; } = "Change core result page – Manage T Level results – GOV.UK";
        private static string coreResultPageUrl { get; } = "change-core-result";
        public static By changeBtn { get; } = By.Id("changeButton");
        public static By selectResultB { get; } = By.Id("hasgradeselected-3");
        public static By notreceivedGrade { get; } = By.Id("hasgradeselected");
        //Change confirmation page
        private static string changeConfirmationPageUrl { get; } = "result-change-confirmation";
        private static string changeConfirmationPageTitle { get; } = "Result changed confirmation page – Manage T Level results – GOV.UK";
        private static string changeConfirmationHeader { get; } = "Change successful";



        public static By BackBtn { get; } = By.Id("backButton");

        public static void VerifyResultsDashboardPage()
        {
            Assert.AreEqual(ResultsDashoardUrl, WebDriver.Url);
            Assert.AreEqual(ResultsDashboardPageTitle, WebDriver.Title);
            Assert.AreEqual("Results", WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyLinksInResultsPage()
        {
            Assert.IsTrue(WebDriver.FindElement(UploadResultLink).Displayed);
            Assert.IsTrue(WebDriver.FindElement(SearchLearnerLink).Displayed);
        }
        public static void ClickResultsLink()
        {
            WebDriver.FindElement(ResultsLink).Click();
        }
        public static void ClickHomeBreadcrumb()
        {
            WebDriver.FindElement(BreadCrumb0).Click();
        }
        public static void VerifyUploadResultsPage()
        {
            Assert.AreEqual(UploadResultsUrl, WebDriver.Url);
            Assert.AreEqual(UploadResultsPageTitle, WebDriver.Title);
            Assert.AreEqual("Upload multiple results", WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyUploadResultsErrorPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(UploadResultsUrl));
            Assert.AreEqual(UploadResultsErrorPageTitle, WebDriver.Title);
        }
        public static void VerifyUploadResultsUnsuccessPage()
        {
            Assert.AreEqual(ResultsUploadUnsuccessUrl, WebDriver.Url);
            Assert.AreEqual(ResultsUploadUnsuccessTitle, WebDriver.Title);
            Assert.AreEqual("There is a problem", WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyUploadResultsSuccessPage()
        {
            Assert.AreEqual(ResultsUploadSuccessUrl, WebDriver.Url);
            Assert.AreEqual(ResultsUploadSuccessPageTitle, WebDriver.Title);
            Assert.AreEqual(ResultsUploadSuccessMsg, WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyBackToResultsBtn()
        {
            WebDriver.FindElement(BackToResultsBtn).Click();
            VerifyResultsDashboardPage();
        }
        public static void VerifyResultsUploadCount(string msgCount)
        {
            Assert.IsTrue(WebDriver.FindElement(SuccessMsg).Text.Contains(msgCount));
        }

        public static void searchResult(string uln)
        {
            WebDriver.FindElement(SearchLearnerLink).Click();
            WebDriver.FindElement(By.Id("searchuln")).SendKeys(uln);
            WebDriver.FindElement(By.Id("searchButton")).Click();
        }
        public static void VerifyResultChangeSuccessPage()
        {
            Assert.AreEqual(changeConfirmationPageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(changeConfirmationPageUrl));
            Assert.AreEqual(changeConfirmationHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public static void VerifyLearnerResultPage()
        {
            Assert.AreEqual(LearnerResultPageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(LearnerResultUrl));
        }
        public static void VerifyLearnerResultWithdrawnPage()
        {
            Assert.AreEqual(LearnerResultWithdrawnPageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(LearnerResultWithdrawnUrl));
        }

        public static void ClickSearchForALearnerLink()
        {
            ClickElement(SearchLearnerLink);
        }

        public static void ClickBacktoHomeBtn()
        {
            ClickElement(BackToHomeBtn);
        }

        public static void ClickUploadAnotherFileBtn()
        {
            ClickElement(uploadAnotherFileBtn);
        }
        public static void ClickAppealLink()
        {
            ClickElement(appealLink);
        }
        public static void ClickUploadAnotherFileLink()
        {
            ClickElement(uploadAnotherMultipleResultsFileLink);
        }
        public static void ClickManageIndividualResultsLink()
        {
            ClickElement(manageIndividualResultsLink);
        }
    }
}
