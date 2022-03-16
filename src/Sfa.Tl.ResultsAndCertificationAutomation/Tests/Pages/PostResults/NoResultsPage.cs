using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;

public class NoResultsPage : ElementHelper
{
    private static string PageUrl { get; } = string.Concat(StartPage.StartPageUrl, "post-results-no-results");
    private static string PageTitle { get; } = "No results - Post-results – Manage T Level results – GOV.UK";
    private static string PageHeader { get; } = "Learner does not have any results";
    private static readonly By PageHeaderElement = By.XPath("//*[@id='main-content']//h1");

    protected static void VerifyNoResultsPage()
    {
        Assert.AreEqual(PageUrl,WebDriver.Url);
        Assert.AreEqual(PageTitle,WebDriver.Title);
        Assert.AreEqual(PageHeader,WebDriver.FindElement(PageHeaderElement).Text);
    }
}