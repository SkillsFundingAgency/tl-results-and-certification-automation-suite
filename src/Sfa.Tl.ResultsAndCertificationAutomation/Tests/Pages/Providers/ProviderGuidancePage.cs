using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;

public class ProviderGuidancePage : ElementHelper
{
    private static string PageUrl { get; } = string.Concat(StartPage.StartPageUrl, "provider-guidance");
    private static string PageTitle { get; } = "About Manage T Level results – Manage T Level results – GOV.UK";
    private static By PageHeadElement { get; } = By.XPath("//*[@id='main-content']//h1");
    private static string PageHeader = "About Manage T Level results";

    protected static void VerifyProviderGuidancePage()
    {
        Assert.AreEqual(PageUrl, WebDriver.Url);
        Assert.AreEqual(PageTitle, WebDriver.Title);
        Assert.AreEqual(PageHeader, WebDriver.FindElement(PageHeadElement).Text);
    }
}