using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;

public class AssessmentEntriesPage : ElementHelper
{
    //Urls
    private static string AssessmentEntriesPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "assessment-entries");
    private static string AssessmentEntriesUploadPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "upload-assessment-entries-file");
    private static string AssessmentUploadUnsuccessPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "assessment-entries-upload-unsuccessful");
    private static string AssessmentUploadSuccessPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "assessment-entries-upload-confirmation");
    //Page Titles
    private static string AssessmentEntriesPageTitle { get; } = "Assessments – Manage T Level results – GOV.UK";
    private static string AssessmentEntriesUploadPageTitle { get; } = "Upload multiple assessments – Manage T Level results – GOV.UK";
    private static string AssessmentUploadUnsucccessTitle { get; } = "Assessments upload error – Manage T Level results – GOV.UK";
    private static string AssessmentUploadSucccessTitle { get; } = "Assessments upload success – Manage T Level results – GOV.UK";
    private static string AssessmentEntriesUploadPageErrorTitle { get; } = "Error: Upload multiple assessments – Manage T Level results – GOV.UK";
    //Page Headers
    private static string AssessmentEntriesPageHeader { get; } = "Assessments";
    private static string AssessmentEntriesUploadPageHeader { get; } = "Upload multiple assessments";
    private static string AssessmentUploadUnsuccessPageHeader { get; } = "There is a problem";
    private static string AssessmentUploadSuccessPageHeader { get; } = "Assessments uploaded successfully";

    // Objects
    public static By AssessmentEntriesLink { get; } = By.LinkText("Assessments");
    private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
    public static By UploadAssessmentEntryLink { get; } = By.LinkText("Upload multiple assessments");
    public static By SearchForLearnerLink { get; } = By.LinkText("Manage an assessment");
    public static By AssessmentFileUploadError { get; } = By.XPath("//a[@href='#file']");
    public static By AddOrRemoveAssessmentEntry { get; } = By.Id("coreassessmententry");
    private static By ManageIndividualAssessmentsLink { get; } = By.XPath("//*[contains (text(),'manage individual assessments')]");
    private static By UploadAnotherMultipleAssessmentsFileLink { get; } = By.XPath("//*[contains (text(),'upload another multiple assessments file')]");
    private static By AddResultsLink { get; } = By.XPath("//*[contains (text(),'add results')]");
    private static By BackToHomeBtn { get; } = By.Id("backToHomeButton");
    private static readonly By UploadAnotherFileBtn = By.Id("uploadAnotherFileButton");


    //Upload files
    public static string AssessmentStage1InvalidFile = "AssessmentEntryStage1InvalidFileType.xslx";
    public static string AssessmentStage1MaxRows = "AssessmentEntryStage1MaxNoOfRows.csv";
    protected static readonly string AssessmentUploadStage2Errors = string.Concat("Data\\", "AssessmentStage2ErrorReport.csv");
    protected static readonly string AssessmentUploadStage2InvalidHeaderErrors = string.Concat("Data\\", "AssessmentStage2InvalidHeaderError.csv");
    protected static readonly string AssessmentUploadStage2NoDataErrors = string.Concat("Data\\", "AssessmentStage2NoDataError.csv");
    protected static readonly string AssessmentUploadStage3Errors = string.Concat("Data\\", "AssessmentStage3Errors.csv");
    protected static readonly string AssessmentUploadStage3WithdrawnRegError = string.Concat("Data\\", "AssessmentStage3WithdrawnRegError.csv");
    protected static readonly string AssessmentUploadAddFirstAssessEntry = string.Concat("Data\\", "AssessmentAddFirstAssessSeriesErrors.csv");
    protected static readonly string AssessmentUploadMultipleSpecialismErrors = string.Concat("Data\\", "AssessmentMultipleSpecialismErrors.csv");
    //protected static readonly string TLRC4695AssessmentUploadErrors = string.Concat("Data\\", "4695ExpectedErrorReport.csv");

    //Buttons
    private static readonly By BackToAssessmentEntriesButton = By.XPath("//*[contains(text(),'Back to assessment')]");



    public static void VerifyAssessmentEntriesPage()
    {
        Assert.AreEqual(AssessmentEntriesPageTitle, WebDriver.Title);
        Assert.AreEqual(AssessmentEntriesPageUrl, WebDriver.Url);
        Assert.AreEqual(AssessmentEntriesPageHeader, WebDriver.FindElement(PageHeader).Text);
    }

    protected static void CheckLinksOnAssessmentEntriesPage()
    {
        Assert.IsTrue(IsPresent(UploadAssessmentEntryLink));
        Assert.IsTrue(IsPresent(SearchForLearnerLink));
    }

    public static void VerifyAssessmentEntriesUploadPage()
    {
        Assert.AreEqual(AssessmentEntriesUploadPageUrl, WebDriver.Url);
        Assert.AreEqual(AssessmentEntriesUploadPageTitle, WebDriver.Title);
        Assert.AreEqual(AssessmentEntriesUploadPageHeader, WebDriver.FindElement(PageHeader).Text);
    }

    protected static void VerifyAssessmentEntriesUploadErrorPage()
    {
        Assert.AreEqual(AssessmentEntriesUploadPageUrl, WebDriver.Url);
        Assert.AreEqual(AssessmentEntriesUploadPageErrorTitle, WebDriver.Title);
        Assert.AreEqual(AssessmentEntriesUploadPageHeader, WebDriver.FindElement(PageHeader).Text);
    }

    protected static void VerifyAssessmentUploadUnsuccessPage()
    {
        Assert.AreEqual(AssessmentUploadUnsuccessPageUrl, WebDriver.Url);
        Assert.AreEqual(AssessmentUploadUnsucccessTitle, WebDriver.Title);
        Assert.AreEqual(AssessmentUploadUnsuccessPageHeader, WebDriver.FindElement(PageHeader).Text);
    }
    public static void VerifyAssessmentUploadSuccessPage()
    {
        Assert.AreEqual(AssessmentUploadSuccessPageUrl, WebDriver.Url);
        Assert.AreEqual(AssessmentUploadSucccessTitle, WebDriver.Title);
        Assert.AreEqual(AssessmentUploadSuccessPageHeader, WebDriver.FindElement(PageHeader).Text);
    }

    public static void ClickBacktoAssessmentEntriesButton()
    {
        ClickElement(BackToAssessmentEntriesButton);
    }
    public static void SearchAssessmentEntry(string uln)
    {
        ClickElement(TlevelDashboardPage.DashboardHeadLink);
        ClickElement(AssessmentEntriesLink);
        VerifyAssessmentEntriesPage();
        ClickElement(SearchForLearnerLink);
        AssessmentEntriesSearchForLearnerPage.VerifyAssessmentEntriesSearchForLearnerPage();
        WebDriver.FindElement(AssessmentEntriesSearchForLearnerPage.SearchField).SendKeys(uln);
        ClickElement(AssessmentEntriesSearchForLearnerPage.SearchBtn);
        AssessmentEntriesLearnersAssessmentEntriesPage.VerifyLearnersAssessmentEntriesPage();
    }

    public static void ClickBacktoHomeBtn()
    {
        ClickElement(BackToHomeBtn);
    }

    protected static void ClickUploadAnotherFileBtn()
    {
        ClickElement(UploadAnotherFileBtn);
    }

    protected static void ClickAddResultsLink()
    {
        ClickElement(AddResultsLink);
    }

    protected static void ClickUploadAnotherFileLink()
    {
        ClickElement(UploadAnotherMultipleAssessmentsFileLink);
    }

    protected static void ClickManageIndividualAssessmentsLink()
    {
        ClickElement(ManageIndividualAssessmentsLink);
    }
}