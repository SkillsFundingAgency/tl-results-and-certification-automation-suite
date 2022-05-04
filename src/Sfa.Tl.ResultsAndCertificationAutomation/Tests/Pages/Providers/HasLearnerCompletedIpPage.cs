using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;

public class HasLearnerCompletedIpPage : ElementHelper
{
    private static string PageUrl { get; } = "industry-placement-completion";
    private static string PageTitle { get; } = "Industry placement completion - Manage learner – Manage T Level results – GOV.UK";
    private static string ErrorPageTitle { get; } = "Error: Industry placement completion - Manage learner – Manage T Level results – GOV.UK";
    private static readonly By ContinueBtn = By.Id("continueButton");

    protected static void VerifyHasLearnerCompletedIpPage()
    {
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        Assert.AreEqual(PageTitle, WebDriver.Title);
    }

    protected static void VerifyHasLearnerCompletedIpErrorPage()
    {
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        Assert.AreEqual(ErrorPageTitle, WebDriver.Title);
    }

    protected static void VerifyBackLink()
    {
        ClickElement(By.Id("backLink"));
        LearnerDetailPage.VerifyLearnerRecordPage();
    }

    protected static void ClickContinueBtn() => ClickButton(ContinueBtn);
}