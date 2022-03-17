using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;

public class CheckRommOutcomePage : ElementHelper
{
    private static string PageUrl { get; } = "post-results-romm-check";
    private static string PageTitle { get; } = "Check ROMM outcome - Post-results – Manage T Level results – GOV.UK";
    private static string PageHeader { get; } = "Check the ROMM outcome";
    private static readonly By PageHeaderElement = By.XPath("//*[@id='main-content']//h1");
    private static readonly By BackLink = By.Id("backLink");
    private static readonly By SubmitBtn = By.Id("submitButton");

    protected static void VerifyCheckRommOutcomePage()
    {
        Assert.AreEqual(PageTitle,WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        Assert.AreEqual(PageHeader,WebDriver.FindElement(PageHeaderElement).Text);
    }

    protected static void BackLinkToAddRommOutcomePage()
    {
        ClickElement(BackLink);
        AddRommOutcomePage.VerifyAddRommOutcomePage();
    }

    public static void ClickSubmitBtn() => ClickButton(SubmitBtn);
}