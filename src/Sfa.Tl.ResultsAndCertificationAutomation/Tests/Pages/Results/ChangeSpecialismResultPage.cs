using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Results;

public class ChangeSpecialismResultPage : ElementHelper
{
    private static string PageUrl { get; } = "change-specialism-result";
    private static string PageTitle { get; } = "Change specialism result – Manage T Level results – GOV.UK";
    private static string ErrorPageTitle { get; } = "Error: Change specialism result – Manage T Level results – GOV.UK";

    protected static void VerifyChangeAssessmentResultsPage()
    {
        Assert.AreEqual(PageTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
    }

    protected static void VerifyChangeAssessmentResultsErrorPage()
    {
        Assert.AreEqual(ErrorPageTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
    }
}