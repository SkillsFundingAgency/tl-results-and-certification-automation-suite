using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;

public class SearchForLearnerPage : ElementHelper
{
    private static string SearchLearnerPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "post-results-search-uln");
    private static string SearchLearnerPageTitle { get; } = "Search ULN - Post-results – Manage T Level results – GOV.UK";
    private static string SearchLearnerPageHeader { get; } = "Search for a learner";
    private static readonly By PageHeaderElement = By.XPath("//*[@id='main-content']//h1");
    private static string SearchLearnerPageErrorTitle { get; } = "Error: Search ULN - Post-results – Manage T Level results – GOV.UK";
    private static By SearchUln { get; } = By.Id("searchuln");
    private static By SearchBtn { get; } = By.Id("searchButton");
    private static By PostResultsBreadcrumb { get; } = By.Id("breadcrumb1");

    //Uln no found page
    private static string UlnNotFoundPageUrl { get; } = string.Concat(StartPage.StartPageUrl, "post-results-uln-not-found");
    private static string UlnNotFoundPageTitle { get; } = "ULN not found - Post-results – Manage T Level results – GOV.UK";
    private static By BackLink { get; } = By.Id("backLink");
    private static By SearchAgainBtn { get; } = By.Id("buttonSearchAgain");
    private static By ContinueBtn { get; } = By.Id("continueButton");

    public static void VerifySearchLearnerPage()
    {
        Assert.AreEqual(SearchLearnerPageUrl,WebDriver.Url);
        Assert.AreEqual(SearchLearnerPageTitle, WebDriver.Title);
        Assert.AreEqual(SearchLearnerPageHeader, WebDriver.FindElement(PageHeaderElement).Text);
    }

    protected static void VerifySearchLearnerErrorPage()
    {
        Assert.AreEqual(SearchLearnerPageErrorTitle, WebDriver.Title);
    }

    protected static void ClickPostResultBreadcrumb()
    {
        ClickElement(PostResultsBreadcrumb);
        PostResultsStartPage.VerifyReviewAndAppealsStartPage();
    }

    protected static void ClickSearchBtn() => ClickButton(SearchBtn);
    protected static void EnterUln(string text) => EnterText(SearchUln, text);

    protected static void VerifyUlnNotFoundPage(string uln)
    {
        Assert.AreEqual(UlnNotFoundPageUrl, WebDriver.Url);
        Assert.AreEqual(UlnNotFoundPageTitle, WebDriver.Title);
        Assert.AreEqual(uln + " not found", WebDriver.FindElement(PageHeaderElement).Text);
    }

    protected static void VerifyBackLink(string uln)
    {
        ClickElement(BackLink);
        Assert.AreEqual(uln, WebDriver.FindElement(By.Id("searchuln")).GetAttribute("value"));
    }

    protected static void VerifySearchAgainBtn()
    {
        ClickButton(SearchAgainBtn);
        VerifySearchLearnerPage();
    }

    public static void PressContinueBtn() => ClickButton(ContinueBtn);
    
}