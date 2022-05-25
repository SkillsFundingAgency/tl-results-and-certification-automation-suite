using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;

public class SearchLearnerPage : ElementHelper
{
    private static string PageUrl { get; } = "search-learner-record-unique-learner-number";
    private static string PageTitle { get; } = "Search ULN - Manage learner – Manage T Level results – GOV.UK";
    private static string ErrorPageTitle { get; } = "Error: Search ULN - Manage learner – Manage T Level results – GOV.UK";
    private static By PageHeadElement { get; } = By.XPath("//*[@id='main-content']//h1");
    private static string PageHeader = "Search for a learner";
    private static readonly By EnterUln = By.Id("searchuln");
    private static readonly By SearchBtn = By.Id("searchButton");

    public static void VerifySearchLearnerPage()
    {
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        Assert.AreEqual(PageTitle, WebDriver.Title);
        Assert.AreEqual(PageHeader, WebDriver.FindElement(PageHeadElement).Text);
    }
    public static void VerifySearchLearnerErrorPage()
    {
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        Assert.AreEqual(ErrorPageTitle, WebDriver.Title);
    }
    public static void SearchUln(string uln)
    {
        EnterText(EnterUln,uln);
        ClickButton(SearchBtn);
    }
}