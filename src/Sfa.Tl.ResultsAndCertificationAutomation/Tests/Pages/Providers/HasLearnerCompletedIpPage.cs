using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;

public class HasLearnerCompletedIpPage : ElementHelper
{
    private static string PageUrl { get; } = "industry-placement-completion";
    private static string PageTitle { get; } = "Industry placement completion - Manage learner – Manage T Level results – GOV.UK";
    private static string ErrorPageTitle { get; } = "Error: Industry placement completion - Manage learner – Manage T Level results – GOV.UK";
    private static readonly By IpCompletedRadio = By.Id("industryplacementstatus");
    private static readonly By IpWithSpecialConsideration = By.Id("industryplacementstatus-cwspc");
    private static readonly By IpNotCompleted = By.Id("industryplacementstatus-notcompleted");
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
    public static void SelectIpCompletedOption(string option)
    {
        switch (option)
        {
            case "Yes, Completed":
                ClickElement(IpCompletedRadio);
                ClickButton(ContinueBtn);
                break;
            case "Yes, completed with special consideration":
                ClickElement(IpWithSpecialConsideration);
                ClickButton(ContinueBtn);
                break;
            case "No, still to be completed":
                ClickElement(IpNotCompleted);
                ClickButton(ContinueBtn);
                break;
        }
    }
    protected static void ClickContinueBtn() => ClickButton(ContinueBtn);
}