using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using System.Threading;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.DataExport;

public class DataExportAssessmentsPage : ElementHelper
{
    private static string NoResultsPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "assessments-no-records-found");
    private static string NoResultsPageHeader { get; } = "No records found";
    private static string NoResultsPageTitle { get; } = "No records found - Assessments – Manage T Level results – GOV.UK";
    private static By PageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
    private static string DownloadAssessmentsPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "assessments-download-data");
    private static string DownloadAssessmentsPageHeader { get; } = "Download assessments data";
    private static string DownloadAssessmentsPageTitle { get; } = "Download data - Assessments – Manage T Level results – GOV.UK";
    private static By BackToHomeBtn { get; } = By.Id("backToHomeButton");
    private static By AddAssessmentsBtn { get; } = By.Id("backToAddAssessments");
    private static By DownloadCoreAssessmentsLink { get; } = By.XPath("//a[contains(text(),'Core assessments data')]");
    private static By DownloadSpecialismAssessmentsLink { get; } = By.XPath("//a[contains(text(),'Specialism assessments data')]");
    private static By ManageTlevelLink { get; } = By.XPath("//a[contains(text(),'Manage T Level results')]");
    protected static readonly string CoreAssessmentDownloadFile = string.Concat("Data\\", "4895_DownloadedCoreAssessmentsData.csv");
    protected static readonly string SpecialismAssessmentDownloadFile = string.Concat("Data\\", "4895_DownloadedSpecialismAssessmentsData.csv");

    protected static void VerifyNoAssessmentsRecordPage()
    {
        Assert.AreEqual(NoResultsPageUrl, WebDriver.Url);
        Assert.AreEqual(NoResultsPageHeader, WebDriver.FindElement(PageHeaderElement).Text);
        Assert.AreEqual(NoResultsPageTitle, WebDriver.Title);
    }

    protected static void VerifyDownloadAssessmentPage()
    {
        Assert.AreEqual(DownloadAssessmentsPageUrl, WebDriver.Url);
        Assert.AreEqual(DownloadAssessmentsPageHeader, WebDriver.FindElement(PageHeaderElement).Text);
        Assert.AreEqual(DownloadAssessmentsPageTitle, WebDriver.Title);
    }
    public static void BackToHome()
    {
        ClickButton(BackToHomeBtn);
        TlevelDashboardPage.VerifyDashboardpage();
    }

    protected static void AddAssessments()
    {
        ClickButton(AddAssessmentsBtn);
        AssessmentEntriesPage.VerifyAssessmentEntriesPage();
    }

    protected static void ClickBanner()
    {
        ClickElement(ManageTlevelLink);
    }

    protected static void DownloadCoreAssessmentFile()
    {
        ClickElement(DownloadCoreAssessmentsLink);
        Thread.Sleep(5000);
    }

    protected static void DownloadSpecialismAssessmentFile()
    {
        ClickElement(DownloadSpecialismAssessmentsLink);
        Thread.Sleep(5000);
    }
}