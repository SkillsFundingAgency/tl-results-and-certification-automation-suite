using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;

public class ProviderTimelinePage : ElementHelper
{
    private static string PageUrl { get; } = string.Concat(StartPage.StartPageUrl, "provider-timeline");
    private static string PageTitle { get; } = "2020 to 2021 Manage T Level results timeline – Manage T Level results – GOV.UK";
    private static By PageHeadElement { get; } = By.XPath("//*[@id='main-content']//h1");
    private static string PageHeader = "Manage T Level results timeline";

    protected static void VerifyProviderTimelinePage()
    {
        Assert.AreEqual(PageUrl, WebDriver.Url);
        Assert.AreEqual(PageTitle, WebDriver.Title);
        Assert.AreEqual(PageHeader, WebDriver.FindElement(PageHeadElement).Text);
    }
}