using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;

public class ResultsDashboardPage : ElementHelper
{
    private static string ResultsDashoardUrl { get; } = string.Concat(StartPage.StartPageUrl, "results");
    private static By ResultsLink { get; } = By.LinkText("Results");
    private static By BreadCrumb0 { get; } = By.Id("breadcrumb0");
    private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
    private static By SuccessMsg { get; } = By.XPath("//*[@id='main-content']");
    private static string ResultsDashboardPageTitle { get; } = "Results – Manage T Level results – GOV.UK";
    protected static By UploadResultLink { get; } = By.LinkText("Upload multiple results");

    private static By SearchLearnerLink { get; } = By.LinkText("Manage a result");
    // Upload results page
    private static string UploadResultsUrl { get; } = string.Concat(StartPage.StartPageUrl, "upload-results-file");
    private static string UploadResultsPageTitle { get; } = "Upload multiple results – Manage T Level results – GOV.UK";
    private static string UploadResultsErrorPageTitle { get; } = "Error: Upload multiple results – Manage T Level results – GOV.UK";
    private static string ResultsUploadUnsuccessUrl { get; } = string.Concat(StartPage.StartPageUrl, "results-upload-unsuccessful");
    private static string ResultsUploadUnsuccessTitle { get; } = "Results upload error – Manage T Level results – GOV.UK";
    protected static readonly string ResultsUploadStage2InvalidHeaderErrors = string.Concat("Data\\", "ResultsErrorInvalidHeader.csv");
    protected static readonly string ResultsUploadStage2NoDataErrors = string.Concat("Data\\", "ResultsErrorNoData.csv");
    protected static readonly string ResultsUploadStage2Errors = string.Concat("Data\\", "ResultsErrorStage2Validations.csv");
    protected static readonly string ResultsUploadStage3Errors = string.Concat("Data\\", "ResultsErrorStage3Validations.csv");
    protected static readonly string ResultsUploadStage3WithdrawnErrors = string.Concat("Data\\", "ResultsErrorStage3Withdrawn.csv");
    public static readonly string ResultsUploadBlockAppealErrors = string.Concat("Data\\", "BlockResultUpdateForAppeal.csv");
    public static readonly string ResultsUploadBlockFinalErrors = string.Concat("Data\\", "BlockResultUpdateForFinal.csv");
    
    public static readonly string AssessmentResultStage2ValidationErrors = string.Concat("Data\\", "5047_ResultsErrorReport.csv");
    public static readonly string AssessmentResultStage2NoDataValidationError = string.Concat("Data\\", "5047_ResultsErrorReportNoData.csv");

    protected static readonly string AssessmentResultStage3ValidationError = string.Concat("Data\\", "5048_AssessmentResultsErrorReportStage3.csv");
    // Upload Results success page
    private static string ResultsUploadSuccessMsg { get; } = "Results uploaded";
    private static string ResultsUploadSuccessPageTitle { get; } = "Results upload success – Manage T Level results – GOV.UK";
    private static string ResultsUploadSuccessUrl { get; } = string.Concat(StartPage.StartPageUrl, "results-upload-confirmation");
    public static By BackToResultsBtn { get; } = By.Id("backToResultsButton");
    protected static string ResultsSuccessCountMsg { get; } = "You successfully sent results for 3 registrations.";
    protected static string ResultSingleSuccessMsg { get; } = "You successfully sent results data for one registration.";
    private static By ManageIndividualResultsLink { get; } = By.XPath("//*[contains (text(),'manage individual results')]");
    private static By UploadAnotherMultipleResultsFileLink { get; } = By.XPath("//*[contains (text(),'upload another multiple results file')]");
    private static By AppealLink { get; } = By.XPath("//*[contains (text(),'appeal')]");
    private static By BackToHomeBtn { get; } = By.Id("backToHomeButton");
    private static readonly By UploadAnotherFileBtn = By.Id("uploadAnotherFileButton");

    //Learner result page
    private static string LearnerResultPageTitle { get; } = "Learner's results – Manage T Level results – GOV.UK";
    private static string LearnerResultUrl { get; } = "learner-results";

    public static By ChangeResult { get; } = By.XPath("//a[@id='pathwaygrade' and contains(text(),'Change')]");
    //Learner Withdrawn
    private static string LearnerResultWithdrawnPageTitle { get; } = "Learner withdrawn - Results – Manage T Level results – GOV.UK";
    private static string LearnerResultWithdrawnUrl { get; } = "results-learner-withdrawn";
    //Core result page
    protected static By ChangeBtn { get; } = By.Id("changeButton");
    public static By SelectResultB { get; } = By.Id("hasgradeselected-3");
    public static By NotreceivedGrade { get; } = By.Id("hasgradeselected");
    //Change confirmation page
    private static string ChangeConfirmationPageUrl { get; } = "result-change-confirmation";
    private static string ChangeConfirmationPageTitle { get; } = "Result changed confirmation page – Manage T Level results – GOV.UK";
    private static string ChangeConfirmationHeader { get; } = "Change successful";


    protected static By BackBtn { get; } = By.Id("backButton");

    public static void VerifyResultsDashboardPage()
    {
        Assert.AreEqual(ResultsDashoardUrl, WebDriver.Url);
        Assert.AreEqual(ResultsDashboardPageTitle, WebDriver.Title);
        Assert.AreEqual("Results", WebDriver.FindElement(PageHeader).Text);
    }

    protected static void VerifyLinksInResultsPage()
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

    protected static void VerifyUploadResultsErrorPage()
    {
        Assert.IsTrue(WebDriver.Url.Contains(UploadResultsUrl));
        Assert.AreEqual(UploadResultsErrorPageTitle, WebDriver.Title);
    }

    protected static void VerifyUploadResultsUnsuccessPage()
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

    protected static void VerifyBackToResultsBtn()
    {
        WebDriver.FindElement(BackToResultsBtn).Click();
        VerifyResultsDashboardPage();
    }

    protected static void VerifyResultsUploadCount(string msgCount)
    {
        Assert.IsTrue(WebDriver.FindElement(SuccessMsg).Text.Contains(msgCount));
    }

    public static void SearchResult(string uln)
    {
        WebDriver.FindElement(SearchLearnerLink).Click();
        WebDriver.FindElement(By.Id("searchuln")).SendKeys(uln);
        WebDriver.FindElement(By.Id("searchButton")).Click();
    }
    public static void VerifyResultChangeSuccessPage()
    {
        Assert.AreEqual(ChangeConfirmationPageTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(ChangeConfirmationPageUrl));
        Assert.AreEqual(ChangeConfirmationHeader, WebDriver.FindElement(PageHeader).Text);
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

    protected static void ClickUploadAnotherFileBtn()
    {
        ClickElement(UploadAnotherFileBtn);
    }

    protected static void ClickAppealLink()
    {
        ClickElement(AppealLink);
    }

    protected static void ClickUploadAnotherFileLink()
    {
        ClickElement(UploadAnotherMultipleResultsFileLink);
    }
    public static void ClickManageIndividualResultsLink()
    {
        ClickElement(ManageIndividualResultsLink);
    }
}