using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;

public class ChangeTheGradeAfterAppealPage : ElementHelper
{
    private static string PageUrl { get; } = "post-results-appeal-change-grade";
    private static string PageTitle { get; } = "Appeal grade change - Post-results – Manage T Level results – GOV.UK";
    private static string PageErrorTitle { get; } = "Error: Appeal grade change - Post-results – Manage T Level results – GOV.UK";
    private static string PageHeader { get; } = "Change the grade after an appeal";
    private static readonly By PageHeaderElement = By.XPath("//*[@id='main-content']//h1");
    private static readonly By LearnerDetailsElement = By.XPath("//*[@id='main-content']/div[1]");
    private static readonly By BackLink = By.Id("backLink");

    public static void VerifyChangeTheGradeAfterAppealPage()
    {
        Assert.AreEqual(PageTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        Assert.AreEqual(PageHeader, WebDriver.FindElement(PageHeaderElement).Text);
    }

    protected static void VerifyChangeTheGradeAfterAppealErrorPage()
    {
        Assert.AreEqual(PageErrorTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
    }

    protected static void BackLinkToAddAppealOutcomePage()
    {
        ClickElement(BackLink);
        AddAppealOutcomePage.VerifyAddAppealOutcomePage();
    }
    protected static void BackLinkToDoYouKnowAppealOutcomePage()
    {
        ClickElement(BackLink);
        DoYouKnowTheAppealOutcomePage.VerifyDoYouKnowTheAppealOutcomePage();
    }
    protected static void VerifyLearnerCoreDetailsChangeGradeAfterAppealPage()
    {
        Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbFirstName + " " + Constants.DbLastName));
        Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbDateOfBirth));
        Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbTlevel));
        Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbCoreComponent));
    }

    protected static void VerifyLearnerOsDetailsChangeGradeAfterAppealPage()
    {
        Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbFirstName + " " + Constants.DbLastName));
        Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbDateOfBirth));
        Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbTlevel));
        Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbOs1Component));
    }
}