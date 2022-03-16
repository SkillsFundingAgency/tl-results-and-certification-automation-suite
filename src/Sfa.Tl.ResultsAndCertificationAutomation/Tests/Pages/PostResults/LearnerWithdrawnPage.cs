using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;

public class LearnerWithdrawnPage : ElementHelper
{
    private static string PageUrl { get; } = string.Concat(StartPage.StartPageUrl, "post-results-learner-withdrawn");
    private static string PageTitle { get; } = "Learner withdrawn - Post-results – Manage T Level results – GOV.UK";
    private static string PageHeader { get; } = "withdrawn";
    private static readonly By PageHeaderElement = By.XPath("//*[@id='main-content']//h1");
    private static By BackToHomeBtn { get; } = By.Id("backToHomeButton");
    private static By BackLink { get; } = By.Id("backLink");

    protected static void VerifyLearnerWithdrawnPage()
    {
        Assert.AreEqual(PageTitle,WebDriver.Title);
        Assert.AreEqual(PageUrl,WebDriver.Url);
        Assert.IsTrue(WebDriver.FindElement(PageHeaderElement).Text.Contains(PageHeader));
    }

    public static void ClickBackToHomeBtn()
    {
        ClickButton(BackToHomeBtn);
    }

    protected static void VerifyBackLink(string uln)
    {
        ClickElement(BackLink);
        Assert.AreEqual(uln, WebDriver.FindElement(By.Id("searchuln")).GetAttribute("value"));
    }
}