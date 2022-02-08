using System.Threading;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using NUnit.Framework;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;

public class StartPage : ElementHelper
{
    private static string Folder => FileHelper.GetDownloadFolder();
    public static string StartPageUrl => WebDriverFactory.Config["BaseUrl"];
    private static string HelpUrl => string.Concat(StartPageUrl, "Help");
    public static string CookieUrl => string.Concat(StartPageUrl, "cookies");
    public static string CookieDetailsUrl => string.Concat(StartPageUrl, "cookie-details");
    public static string PrivacyUrl => string.Concat(HelpUrl, "/Privacy");
    protected static string Expected404 => string.Concat(WebDriverFactory.Config["BaseUrl"], "page-not-found");
    protected static string Error404 => string.Concat(StartPageUrl, "test");
    protected static string Error401 => string.Concat(StartPageUrl, "access-denied-wrong-role");
    protected static string Error500 => string.Concat(StartPageUrl, "Error/500");
    public static string ExpectedError500 => string.Concat(StartPageUrl, "problem-with-service");
    public static string Error403 => string.Concat(StartPageUrl, "service-access-denied");
    public static string TermsUrl => string.Concat(StartPageUrl, "terms-and-conditions");
    protected static string TechSpecPageUrl => string.Concat(StartPageUrl, "tlevel-data-format-and-rules-guides");
    private static IWebElement CheckPageTitle => WebDriver.FindElement(By.TagName("h1"));
    private static By CookieTitle { get; } = By.XPath("//*[@id='main-content']//h1");
    public static By TlevelCookies { get; } = By.XPath("//*[@id='main-content']/div/div/h1");
    protected readonly By CookieLink = By.LinkText("Cookies");
    protected readonly By TcLink = By.XPath("//a[contains(text(),'Terms and conditions')]");
    protected readonly By PageHeader = By.XPath("//*[@id='main-content']//h1");
    private const string TechSpecPageTitle = "T Levels data format and rules – Manage T Level results – GOV.UK";
    private const string TechSpecPageHeader = "T Levels data format and rules";
    public const string CookiePageTitle = "Details about cookies on Manage T Level results – Manage T Level results – GOV.UK";
    private static readonly By RegistrationDownloadLink = By.PartialLinkText("registrations data format and rules");
    private static readonly By AssessmentEntriesDownloadLink = By.PartialLinkText("assessment entries data format and rules");
    private static readonly By ResultsDownloadLink = By.PartialLinkText("results data format and rules");
    private static readonly By DataFormatLink = By.XPath("//a[contains(text(),'T Level data format and rules')]");
    private static readonly By ContactLink = By.XPath("//a[contains(text(),'Contact')]");
    public void CheckCookies()
    {
        PageHelper.VerifyPageUrl(WebDriver.Url, CookieUrl);
        Assert.AreEqual(Constants.CookieHeader, CheckPageTitle.Text);
    }

    protected static void VerifyTechSpecPage()
    {
        Assert.AreEqual(TechSpecPageTitle, WebDriver.Title);
        Assert.AreEqual(TechSpecPageUrl,WebDriver.Url);
        Assert.AreEqual(TechSpecPageHeader, WebDriver.FindElement(CookieTitle).Text);
    }

    protected static void ClickDataFormatLink()
    {
        ClickElement(DataFormatLink);
    }

    public static void ClickContactLink()
    {
        ClickElement(ContactLink);
    }

    protected static void VerifyRegistrationDataFormat()
    {
        ClickElement(RegistrationDownloadLink);
        Thread.Sleep(5000);
        const string file = "tlevels-registrations-data-format-and-rules.xlsx";
        var actualFile = PageHelper.GetLatestFile(Folder, "*.xlsx");
        Assert.AreEqual(file,actualFile);
    }
    protected static void VerifyAssessmentDataFormat()
    {
        ClickElement(AssessmentEntriesDownloadLink);
        Thread.Sleep(5000);
        const string file = "tlevels-assessment-entry-data-format-and-rules.xlsx";
        var actualFile = PageHelper.GetLatestFile(Folder, "*.xlsx");
        Assert.AreEqual(file, actualFile);
    }
    protected static void VerifyResultDataFormat()
    {
        ClickElement(ResultsDownloadLink);
        Thread.Sleep(5000);
        const string file = "tlevels-results-data-format-and-rules.xlsx";
        var actualFile = PageHelper.GetLatestFile(Folder, "*.xlsx");
        Assert.AreEqual(file, actualFile);
    }
}